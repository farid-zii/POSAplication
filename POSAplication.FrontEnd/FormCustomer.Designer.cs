namespace POSAplication.FrontEnd
{
    partial class FormCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnName = new System.Windows.Forms.Button();
            this.btnALamat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Join";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 23);
            this.txtID.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(130, 111);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(201, 23);
            this.txtNama.TabIndex = 6;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(130, 149);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(201, 23);
            this.txtAlamat.TabIndex = 7;
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(456, 72);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(201, 23);
            this.txtTelp.TabIndex = 8;
            // 
            // date
            // 
            this.date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date.Location = new System.Drawing.Point(457, 111);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 23);
            this.date.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(138, 210);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(364, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(479, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(83, 239);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 25;
            this.dgvCustomer.Size = new System.Drawing.Size(529, 150);
            this.dgvCustomer.TabIndex = 14;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(629, 239);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 15;
            this.btnName.Text = "By Nama";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // btnALamat
            // 
            this.btnALamat.Location = new System.Drawing.Point(629, 280);
            this.btnALamat.Name = "btnALamat";
            this.btnALamat.Size = new System.Drawing.Size(75, 23);
            this.btnALamat.TabIndex = 16;
            this.btnALamat.Text = "By Alamat";
            this.btnALamat.UseVisualStyleBackColor = true;
            this.btnALamat.Click += new System.EventHandler(this.btnALamat_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.btnALamat);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNama;
        private TextBox txtAlamat;
        private TextBox txtTelp;
        private DateTimePicker date;
        private Button btnInsert;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCustomer;
        private Button btnName;
        private Button btnALamat;
    }
}