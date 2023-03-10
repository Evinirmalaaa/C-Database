namespace C__Database
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTabel = new System.Windows.Forms.DataGridView();
            this.gambarProduk = new System.Windows.Forms.PictureBox();
            this.txtNamaProd = new System.Windows.Forms.TextBox();
            this.txtHpp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.combSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataSupplier = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Id_Supplier = new System.Windows.Forms.TextBox();
            this.txt_Alamat_Supplier = new System.Windows.Forms.TextBox();
            this.txt_Nama_Supplier = new System.Windows.Forms.TextBox();
            this.btnUpdate_Supplier = new System.Windows.Forms.Button();
            this.btnInsert_Supplier = new System.Windows.Forms.Button();
            this.txt_searProduk = new System.Windows.Forms.TextBox();
            this.Sear_Produk = new System.Windows.Forms.Button();
            this.Sear_Supplier = new System.Windows.Forms.Button();
            this.txt_searSupplier = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTabel
            // 
            this.dataTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabel.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataTabel.Location = new System.Drawing.Point(675, 507);
            this.dataTabel.Margin = new System.Windows.Forms.Padding(4);
            this.dataTabel.Name = "dataTabel";
            this.dataTabel.RowHeadersWidth = 51;
            this.dataTabel.Size = new System.Drawing.Size(1047, 233);
            this.dataTabel.TabIndex = 0;
            this.dataTabel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabel_CellClick);
            // 
            // gambarProduk
            // 
            this.gambarProduk.Location = new System.Drawing.Point(23, 474);
            this.gambarProduk.Margin = new System.Windows.Forms.Padding(4);
            this.gambarProduk.Name = "gambarProduk";
            this.gambarProduk.Size = new System.Drawing.Size(187, 234);
            this.gambarProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarProduk.TabIndex = 1;
            this.gambarProduk.TabStop = false;
            // 
            // txtNamaProd
            // 
            this.txtNamaProd.Location = new System.Drawing.Point(373, 507);
            this.txtNamaProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaProd.Name = "txtNamaProd";
            this.txtNamaProd.Size = new System.Drawing.Size(283, 22);
            this.txtNamaProd.TabIndex = 2;
            // 
            // txtHpp
            // 
            this.txtHpp.Location = new System.Drawing.Point(373, 573);
            this.txtHpp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHpp.Name = "txtHpp";
            this.txtHpp.Size = new System.Drawing.Size(283, 22);
            this.txtHpp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 542);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 576);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga Per Produk";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(373, 605);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 28);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // combSupplier
            // 
            this.combSupplier.FormattingEnabled = true;
            this.combSupplier.Location = new System.Drawing.Point(373, 539);
            this.combSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.combSupplier.Name = "combSupplier";
            this.combSupplier.Size = new System.Drawing.Size(283, 24);
            this.combSupplier.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id_Produk";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(373, 475);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(283, 22);
            this.txt_Id.TabIndex = 12;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(558, 605);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 28);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataSupplier
            // 
            this.dataSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSupplier.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataSupplier.Location = new System.Drawing.Point(671, 205);
            this.dataSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dataSupplier.Name = "dataSupplier";
            this.dataSupplier.RowHeadersWidth = 51;
            this.dataSupplier.Size = new System.Drawing.Size(1044, 247);
            this.dataSupplier.TabIndex = 14;
            this.dataSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSupplier_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Id_Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nama Supplier";
            // 
            // txt_Id_Supplier
            // 
            this.txt_Id_Supplier.Enabled = false;
            this.txt_Id_Supplier.Location = new System.Drawing.Point(129, 173);
            this.txt_Id_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id_Supplier.Name = "txt_Id_Supplier";
            this.txt_Id_Supplier.ReadOnly = true;
            this.txt_Id_Supplier.Size = new System.Drawing.Size(528, 22);
            this.txt_Id_Supplier.TabIndex = 20;
            // 
            // txt_Alamat_Supplier
            // 
            this.txt_Alamat_Supplier.Location = new System.Drawing.Point(129, 237);
            this.txt_Alamat_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Alamat_Supplier.Name = "txt_Alamat_Supplier";
            this.txt_Alamat_Supplier.Size = new System.Drawing.Size(528, 22);
            this.txt_Alamat_Supplier.TabIndex = 19;
            // 
            // txt_Nama_Supplier
            // 
            this.txt_Nama_Supplier.Location = new System.Drawing.Point(129, 205);
            this.txt_Nama_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nama_Supplier.Name = "txt_Nama_Supplier";
            this.txt_Nama_Supplier.Size = new System.Drawing.Size(528, 22);
            this.txt_Nama_Supplier.TabIndex = 18;
            // 
            // btnUpdate_Supplier
            // 
            this.btnUpdate_Supplier.Location = new System.Drawing.Point(558, 274);
            this.btnUpdate_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate_Supplier.Name = "btnUpdate_Supplier";
            this.btnUpdate_Supplier.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate_Supplier.TabIndex = 21;
            this.btnUpdate_Supplier.Text = "Update";
            this.btnUpdate_Supplier.UseVisualStyleBackColor = true;
            this.btnUpdate_Supplier.Click += new System.EventHandler(this.btnUpdate_Supplier_Click);
            // 
            // btnInsert_Supplier
            // 
            this.btnInsert_Supplier.Location = new System.Drawing.Point(129, 274);
            this.btnInsert_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert_Supplier.Name = "btnInsert_Supplier";
            this.btnInsert_Supplier.Size = new System.Drawing.Size(100, 28);
            this.btnInsert_Supplier.TabIndex = 22;
            this.btnInsert_Supplier.Text = "Insert";
            this.btnInsert_Supplier.UseVisualStyleBackColor = true;
            this.btnInsert_Supplier.Click += new System.EventHandler(this.btnInsert_Supplier_Click);
            // 
            // txt_searProduk
            // 
            this.txt_searProduk.Location = new System.Drawing.Point(831, 173);
            this.txt_searProduk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searProduk.Name = "txt_searProduk";
            this.txt_searProduk.Size = new System.Drawing.Size(889, 22);
            this.txt_searProduk.TabIndex = 23;
            // 
            // Sear_Produk
            // 
            this.Sear_Produk.Location = new System.Drawing.Point(671, 172);
            this.Sear_Produk.Margin = new System.Windows.Forms.Padding(4);
            this.Sear_Produk.Name = "Sear_Produk";
            this.Sear_Produk.Size = new System.Drawing.Size(148, 25);
            this.Sear_Produk.TabIndex = 24;
            this.Sear_Produk.Text = "Search";
            this.Sear_Produk.UseVisualStyleBackColor = true;
            this.Sear_Produk.Click += new System.EventHandler(this.Sear_Produk_Click);
            // 
            // Sear_Supplier
            // 
            this.Sear_Supplier.Location = new System.Drawing.Point(674, 474);
            this.Sear_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.Sear_Supplier.Name = "Sear_Supplier";
            this.Sear_Supplier.Size = new System.Drawing.Size(145, 25);
            this.Sear_Supplier.TabIndex = 26;
            this.Sear_Supplier.Text = "Search";
            this.Sear_Supplier.UseVisualStyleBackColor = true;
            this.Sear_Supplier.Click += new System.EventHandler(this.Sear_Supplier_Click);
            // 
            // txt_searSupplier
            // 
            this.txt_searSupplier.Location = new System.Drawing.Point(831, 474);
            this.txt_searSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searSupplier.Name = "txt_searSupplier";
            this.txt_searSupplier.Size = new System.Drawing.Size(886, 22);
            this.txt_searSupplier.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1704, 123);
            this.panel1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Thistle;
            this.label8.Location = new System.Drawing.Point(144, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 76);
            this.label8.TabIndex = 1;
            this.label8.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C__Database.Properties.Resources.image_1__2_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1685, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sear_Supplier);
            this.Controls.Add(this.txt_searSupplier);
            this.Controls.Add(this.Sear_Produk);
            this.Controls.Add(this.txt_searProduk);
            this.Controls.Add(this.btnInsert_Supplier);
            this.Controls.Add(this.btnUpdate_Supplier);
            this.Controls.Add(this.txt_Id_Supplier);
            this.Controls.Add(this.txt_Alamat_Supplier);
            this.Controls.Add(this.txt_Nama_Supplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataSupplier);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combSupplier);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHpp);
            this.Controls.Add(this.txtNamaProd);
            this.Controls.Add(this.gambarProduk);
            this.Controls.Add(this.dataTabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTabel;
        private System.Windows.Forms.PictureBox gambarProduk;
        private System.Windows.Forms.TextBox txtNamaProd;
        private System.Windows.Forms.TextBox txtHpp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox combSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Id_Supplier;
        private System.Windows.Forms.TextBox txt_Alamat_Supplier;
        private System.Windows.Forms.TextBox txt_Nama_Supplier;
        private System.Windows.Forms.Button btnUpdate_Supplier;
        private System.Windows.Forms.Button btnInsert_Supplier;
        private System.Windows.Forms.TextBox txt_searProduk;
        private System.Windows.Forms.Button Sear_Produk;
        private System.Windows.Forms.Button Sear_Supplier;
        private System.Windows.Forms.TextBox txt_searSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

