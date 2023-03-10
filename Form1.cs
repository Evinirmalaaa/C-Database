using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace C__Database
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection(
            "server = localhost;" +
            "uid = root;" +
            "database = db_zeamart;");
        DataTable datatabl = new DataTable();
        DataTable datatabl2 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillTable();
            ComboBoxUpdate();
           

            /////Produk/////
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM produk " +
                "JOIN supplier " +
                "ON produk.id_supplier = supplier.id_supplier " +
                "ORDER BY id_produk ASC"
                , conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Byte[] img = (Byte[])(reader["gambar"]);
                MemoryStream ms = new MemoryStream(img);
                gambarProduk.Image = Image.FromStream(ms);
                txtNamaProd.Text = (String)reader["nama_produk"];
                txt_Id.Text = reader["id_produk"].ToString();
                combSupplier.SelectedItem = (String)reader["supplier"];
                txtHpp.Text = reader["hpp"].ToString();
            }
            conn.Close();

            /////Supplier/////
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM supplier", conn);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                txt_Nama_Supplier.Text = (String)reader2["supplier"];
                txt_Id_Supplier.Text = reader2["id_supplier"].ToString();
                txt_Alamat_Supplier.Text = (String)reader2["alamat_supplier"];
            }
            conn.Close();

        }

        public void resetIncrementproduk()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id_produk := 0; UPDATE produk SET id_produk = @id_produk := (@id_produk+1); " +
                "ALTER TABLE produk AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void resetIncrementsupplier()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id_supplier := 0; UPDATE supplier SET id_supplier = @id_supplier := (@id_supplier+1); " +
                "ALTER TABLE supplier AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void ComboBoxUpdate()
        {
            /////Combo box/////
            combSupplier.Items.Clear();
            conn.Open();
            DataTable dt = new DataTable("supplier");
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM supplier", conn))
            {
                da.Fill(dt);
            }

            foreach (DataRow da in dt.Rows)
            {
                combSupplier.Items.Add(da[1].ToString());
            }
            conn.Close();
        }

        public DataTable getData()
        {
            datatabl.Reset();
            datatabl = new DataTable();
            using (MySqlCommand command = new MySqlCommand
                ("SELECT id_produk,supplier,nama_produk,hpp FROM produk " +
                "JOIN supplier " +
                "ON produk.id_supplier = supplier.id_supplier " +
                "ORDER BY id_produk ASC",conn))
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                datatabl.Load(reader);
                conn.Close();
            }
            return datatabl;
        }

        public DataTable getDataSupplier()
        {
            datatabl2.Reset();
            datatabl2 = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM supplier", conn))
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                datatabl2.Load(reader);
                conn.Close();
            }
            return datatabl2;
        }

        public void fillTable()
        {
            datatabl.Clear();
            datatabl2.Clear();
            dataTabel.Columns.Clear();
            dataSupplier.Columns.Clear();
            dataTabel.DataSource = getData();
            dataSupplier.DataSource = getDataSupplier();
            /////Edit/////
            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dataTabel.Columns.Add(colEdit);

            DataGridViewButtonColumn colEdit2 = new DataGridViewButtonColumn();
            colEdit2.UseColumnTextForButtonValue = true;
            colEdit2.Text = "Edit";
            colEdit2.Name = "";
            dataSupplier.Columns.Add(colEdit2);

            /////Delete/////
            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            dataTabel.Columns.Add(colDelete);

            DataGridViewButtonColumn colDelete2 = new DataGridViewButtonColumn();
            colDelete2.UseColumnTextForButtonValue = true;
            colDelete2.Text = "Delete";
            colDelete2.Name = "";
            dataSupplier.Columns.Add(colDelete2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                gambarProduk.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        //insert produk
        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            String idsup = "";
            //get supplier id
            MySqlCommand getsupplierid = new MySqlCommand("SELECT * FROM supplier WHERE supplier = @supplier", conn);
            getsupplierid.Parameters.AddWithValue("@supplier", combSupplier.SelectedItem);

            MySqlDataReader reader = getsupplierid.ExecuteReader();
            if (reader.Read())
            {
             idsup = reader["id_supplier"].ToString();
                
            }
            conn.Close();

            conn.Open();
            MySqlCommand cmd;
            try
            {
                resetIncrementproduk();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO produk (id_supplier, nama_produk, hpp, gambar) " +
                    "VALUE(@id_supplier, @nama_produk, @hpp, @gambar)";

                cmd.Parameters.AddWithValue("@id_supplier", idsup);
                cmd.Parameters.AddWithValue("@nama_produk", txtNamaProd.Text);
                cmd.Parameters.AddWithValue("@hpp", txtHpp.Text);
                MemoryStream ms = new MemoryStream();
                gambarProduk.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                cmd.Parameters.AddWithValue("@gambar", ms.ToArray());
                cmd.ExecuteNonQuery();
                ms.Close();
                conn.Close();
                fillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }

        //edit data di tabel
        private void dataTabel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dataTabel.CurrentCell.RowIndex.ToString());
                txtNamaProd.Text = dataTabel.Rows[id].Cells[2].Value.ToString();
                txtHpp.Text = dataTabel.Rows[id].Cells[3].Value.ToString();
                txt_Id.Text = dataTabel.Rows[id].Cells[0].Value.ToString();
                combSupplier.SelectedItem = dataTabel.Rows[id].Cells[1].Value.ToString();
                

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT gambar FROM produk WHERE id_produk = @idproduk ", conn);
                cmd.Parameters.AddWithValue("@idproduk", dataTabel.Rows[id].Cells[0].Value.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Byte[] img = (Byte[])(reader["gambar"]);
                    MemoryStream ms = new MemoryStream(img);
                    gambarProduk.Image = Image.FromStream(ms);
                }
                conn.Close();
            }

            //delete produk
            if(e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataTabel.CurrentCell.RowIndex.ToString());
                conn.Open();
                MySqlCommand cmd;
                try
                {
                    resetIncrementproduk();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM produk WHERE id_produk = @idproduk";
                    cmd.Parameters.AddWithValue("@idproduk", dataTabel.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    fillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            String idsup = "";
            //get supplier id
            MySqlCommand getsupplierid = new MySqlCommand("SELECT * FROM supplier WHERE supplier = @supplier", conn);
            getsupplierid.Parameters.AddWithValue("@supplier", combSupplier.SelectedItem);

            MySqlDataReader reader = getsupplierid.ExecuteReader();
            if (reader.Read())
            {
                idsup = reader["id_supplier"].ToString();

            }
            conn.Close();

            conn.Open();
            MySqlCommand cmd;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = 
                    "UPDATE produk SET " +
                    "nama_produk = @nama_produk, " +
                    "id_supplier = @id_supplier, " +
                    "hpp = @hpp, " +
                    "gambar = @gambar " +
                    "WHERE id_produk = @id_produk";

                cmd.Parameters.AddWithValue("@id_produk", txt_Id.Text);
                cmd.Parameters.AddWithValue("@id_supplier", idsup);
                cmd.Parameters.AddWithValue("@nama_produk", txtNamaProd.Text);
                cmd.Parameters.AddWithValue("@hpp", txtHpp.Text);
                MemoryStream ms = new MemoryStream();
                gambarProduk.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                cmd.Parameters.AddWithValue("@gambar", ms.ToArray());
                cmd.ExecuteNonQuery();
                ms.Close();
                conn.Close();
                fillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        //insert supplier
        private void btnInsert_Supplier_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd;
            try
            {
                resetIncrementsupplier();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO supplier (supplier, alamat_supplier) " +
                    "VALUE(@supplier, @alamat_supplier)";

                cmd.Parameters.AddWithValue("@supplier", txt_Nama_Supplier.Text);
                cmd.Parameters.AddWithValue("@alamat_supplier", txt_Alamat_Supplier.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                ComboBoxUpdate();
                fillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        //edit supplier
        private void dataSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dataSupplier.CurrentCell.RowIndex.ToString());
                txt_Id_Supplier.Text = dataSupplier.Rows[id].Cells[0].Value.ToString();
                txt_Nama_Supplier.Text = dataSupplier.Rows[id].Cells[1].Value.ToString();
                txt_Alamat_Supplier.Text = dataSupplier.Rows[id].Cells[2].Value.ToString();
            }

            //delete supplier
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dataSupplier.CurrentCell.RowIndex.ToString());
                conn.Open();
                MySqlCommand cmd;
                try
                {
                    resetIncrementsupplier();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM supplier WHERE id_supplier = @idsupplier";
                    cmd.Parameters.AddWithValue("@idsupplier", dataSupplier.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ComboBoxUpdate();
                    fillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        //update supplier
        private void btnUpdate_Supplier_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText =
                    "UPDATE supplier SET " +
                    "supplier = @supplier, " +
                    "alamat_supplier = @alamat_supplier " +
                    "WHERE id_supplier = @id_supplier";

                cmd.Parameters.AddWithValue("@id_supplier", txt_Id_Supplier.Text);
                cmd.Parameters.AddWithValue("@alamat_supplier", txt_Alamat_Supplier.Text);
                cmd.Parameters.AddWithValue("@supplier", txt_Nama_Supplier.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                ComboBoxUpdate();
                fillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Sear_Supplier_Click(object sender, EventArgs e)
        {
            datatabl2.DefaultView.RowFilter = 
                string.Format("CONVERT(id_supplier, System.String) LIKE '%{0}%' " +
                "OR alamat_supplier LIKE '%{0}%' " +
                "OR supplier LIKE '%{0}%'",
                txt_searSupplier.Text.Trim());
        }

        private void Sear_Produk_Click(object sender, EventArgs e)
        {
            datatabl.DefaultView.RowFilter =
                string.Format("CONVERT(id_produk, System.String) LIKE '%{0}%' " +
                "OR CONVERT(nama_produk, System.String) LIKE '%{0}%' " +
                "OR supplier LIKE '%{0}%'" +
                "OR CONVERT(hpp, System.String) LIKE '%{0}%'",
                txt_searProduk.Text.Trim());
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
