namespace POSAplication.FrontEnd
{
    partial class FormBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.KodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBelis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtBeli = new System.Windows.Forms.TextBox();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dateTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBarang,
            this.NamaBarang,
            this.HargaBeli,
            this.HargaJual,
            this.Stok,
            this.TanggalBeli,
            this.Keterangan,
            this.ItemBelis});
            this.dgvBarang.Location = new System.Drawing.Point(0, 36);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.RowTemplate.Height = 29;
            this.dgvBarang.Size = new System.Drawing.Size(703, 141);
            this.dgvBarang.TabIndex = 0;
            this.dgvBarang.DoubleClick += new System.EventHandler(this.dgvBarang_DoubleClick);
            // 
            // KodeBarang
            // 
            this.KodeBarang.DataPropertyName = "KodeBarang";
            this.KodeBarang.HeaderText = "Kode";
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.Width = 80;
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "NamaBarang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NamaBarang.DefaultCellStyle = dataGridViewCellStyle1;
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Width = 180;
            // 
            // HargaBeli
            // 
            this.HargaBeli.DataPropertyName = "HargaBeli";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.HargaBeli.DefaultCellStyle = dataGridViewCellStyle2;
            this.HargaBeli.HeaderText = "HargaBeli";
            this.HargaBeli.Name = "HargaBeli";
            // 
            // HargaJual
            // 
            this.HargaJual.DataPropertyName = "HargaJual";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.HargaJual.DefaultCellStyle = dataGridViewCellStyle3;
            this.HargaJual.HeaderText = "Harga Jual";
            this.HargaJual.Name = "HargaJual";
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "Stok";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Stok.DefaultCellStyle = dataGridViewCellStyle4;
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.Width = 60;
            // 
            // TanggalBeli
            // 
            this.TanggalBeli.DataPropertyName = "TanggalBeli";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.TanggalBeli.DefaultCellStyle = dataGridViewCellStyle5;
            this.TanggalBeli.HeaderText = "Tanggal Beli";
            this.TanggalBeli.Name = "TanggalBeli";
            // 
            // Keterangan
            // 
            this.Keterangan.DataPropertyName = "Keterangan";
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Visible = false;
            // 
            // ItemBelis
            // 
            this.ItemBelis.DataPropertyName = "ItemBelis";
            this.ItemBelis.HeaderText = "ItemBelis";
            this.ItemBelis.Name = "ItemBelis";
            this.ItemBelis.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(29, 181);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tanggal Beli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Keterangan";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(123, 222);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(156, 23);
            this.txtKodeBarang.TabIndex = 9;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(123, 263);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(156, 23);
            this.txtNamaBarang.TabIndex = 10;
            // 
            // txtBeli
            // 
            this.txtBeli.Location = new System.Drawing.Point(123, 302);
            this.txtBeli.Name = "txtBeli";
            this.txtBeli.Size = new System.Drawing.Size(156, 23);
            this.txtBeli.TabIndex = 11;
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(123, 337);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(156, 23);
            this.txtJual.TabIndex = 12;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(412, 222);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(73, 23);
            this.txtStock.TabIndex = 13;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(412, 302);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(216, 23);
            this.txtKeterangan.TabIndex = 14;
            // 
            // dateTanggal
            // 
            this.dateTanggal.Location = new System.Drawing.Point(412, 263);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(200, 23);
            this.dateTanggal.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 181);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 22);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(322, 181);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 181);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Masukkan Nama Barang :";
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.Location = new System.Drawing.Point(181, 9);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(220, 23);
            this.txtCariBarang.TabIndex = 20;
            this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dateTanggal);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtJual);
            this.Controls.Add(this.txtBeli);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvBarang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBarang;
        private Button btnNew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtKodeBarang;
        private TextBox txtNamaBarang;
        private TextBox txtBeli;
        private TextBox txtJual;
        private TextBox txtStock;
        private TextBox txtKeterangan;
        private DateTimePicker dateTanggal;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Label label8;
        private TextBox txtCariBarang;
        private DataGridViewTextBoxColumn KodeBarang;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn HargaBeli;
        private DataGridViewTextBoxColumn HargaJual;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn TanggalBeli;
        private DataGridViewTextBoxColumn Keterangan;
        private DataGridViewTextBoxColumn ItemBelis;
    }
}