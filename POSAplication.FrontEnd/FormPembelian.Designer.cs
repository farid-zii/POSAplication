namespace POSAplication.FrontEnd
{
    partial class FormPembelian
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKodeSup = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaSup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotaBeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNota = new System.Windows.Forms.DateTimePicker();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.NoNotaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Supplier";
            // 
            // TxtKodeSup
            // 
            this.TxtKodeSup.Location = new System.Drawing.Point(106, 35);
            this.TxtKodeSup.Name = "TxtKodeSup";
            this.TxtKodeSup.ReadOnly = true;
            this.TxtKodeSup.Size = new System.Drawing.Size(112, 23);
            this.TxtKodeSup.TabIndex = 3;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(12, 155);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.ReadOnly = true;
            this.txtKodeBarang.Size = new System.Drawing.Size(88, 23);
            this.txtKodeBarang.TabIndex = 5;
            this.txtKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodeBarang_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // txtNamaSup
            // 
            this.txtNamaSup.Location = new System.Drawing.Point(106, 73);
            this.txtNamaSup.Name = "txtNamaSup";
            this.txtNamaSup.ReadOnly = true;
            this.txtNamaSup.Size = new System.Drawing.Size(180, 23);
            this.txtNamaSup.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telp";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(375, 35);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ReadOnly = true;
            this.txtAlamat.Size = new System.Drawing.Size(180, 23);
            this.txtAlamat.TabIndex = 11;
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(375, 73);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.ReadOnly = true;
            this.txtTelp.Size = new System.Drawing.Size(180, 23);
            this.txtTelp.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "No Nota";
            // 
            // txtNotaBeli
            // 
            this.txtNotaBeli.Location = new System.Drawing.Point(58, 6);
            this.txtNotaBeli.Name = "txtNotaBeli";
            this.txtNotaBeli.ReadOnly = true;
            this.txtNotaBeli.Size = new System.Drawing.Size(112, 23);
            this.txtNotaBeli.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tanggal";
            // 
            // dtNota
            // 
            this.dtNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNota.Location = new System.Drawing.Point(466, 6);
            this.dtNota.Name = "dtNota";
            this.dtNota.Size = new System.Drawing.Size(96, 23);
            this.dtNota.TabIndex = 16;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(106, 155);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(180, 23);
            this.txtNamaBarang.TabIndex = 17;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(292, 155);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(63, 23);
            this.txtQty.TabIndex = 18;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(361, 155);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(102, 23);
            this.txtHarga.TabIndex = 19;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(469, 155);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 23);
            this.txtSubtotal.TabIndex = 20;
            this.txtSubtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubtotal_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Harga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "SubTotal";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoNotaBeli,
            this.KodeBarang,
            this.Nama,
            this.ItemBeli,
            this.Qty,
            this.hargaBeli,
            this.Subtotal});
            this.dgvPembelian.Location = new System.Drawing.Point(0, 213);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.RowTemplate.Height = 25;
            this.dgvPembelian.Size = new System.Drawing.Size(603, 150);
            this.dgvPembelian.TabIndex = 26;
            // 
            // NoNotaBeli
            // 
            this.NoNotaBeli.DataPropertyName = "NoNotaBeli";
            this.NoNotaBeli.HeaderText = "NoNotaBeli";
            this.NoNotaBeli.Name = "NoNotaBeli";
            this.NoNotaBeli.Visible = false;
            // 
            // KodeBarang
            // 
            this.KodeBarang.DataPropertyName = "KodeBarang";
            this.KodeBarang.HeaderText = "Kode";
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.Width = 60;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "NamaBarang";
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.Name = "Nama";
            this.Nama.Width = 220;
            // 
            // ItemBeli
            // 
            this.ItemBeli.DataPropertyName = "ItemBeliId";
            this.ItemBeli.HeaderText = "ItemBeliId";
            this.ItemBeli.Name = "ItemBeli";
            this.ItemBeli.Visible = false;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Jumlah";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 60;
            // 
            // hargaBeli
            // 
            this.hargaBeli.DataPropertyName = "hargabeli";
            this.hargaBeli.HeaderText = "Harga Beli";
            this.hargaBeli.Name = "hargaBeli";
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 120;
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 394);
            this.Controls.Add(this.dgvPembelian);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.dtNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotaBeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.TxtKodeSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "FormPembelian";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private Label label2;
        private TextBox TxtKodeSup;
        private TextBox txtKodeBarang;
        private Label label3;
        private TextBox txtNamaSup;
        private Label label4;
        private Label label5;
        private TextBox txtAlamat;
        private TextBox txtTelp;
        private Label label6;
        private TextBox txtNotaBeli;
        private Label label7;
        private DateTimePicker dtNota;
        private TextBox txtNamaBarang;
        private TextBox txtQty;
        private TextBox txtHarga;
        private TextBox txtSubtotal;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgvPembelian;
        private DataGridViewTextBoxColumn NoNotaBeli;
        private DataGridViewTextBoxColumn KodeBarang;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn ItemBeli;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn hargaBeli;
        private DataGridViewTextBoxColumn Subtotal;
    }
}