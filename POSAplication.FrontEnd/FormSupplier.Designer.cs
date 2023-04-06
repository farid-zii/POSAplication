namespace POSAplication.FrontEnd
{
    partial class FormSupplier
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
            this.txtNamaSupplier = new System.Windows.Forms.Label();
            this.txtNamaSup = new System.Windows.Forms.TextBox();
            this.dgvSup = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.AutoSize = true;
            this.txtNamaSupplier.Location = new System.Drawing.Point(24, 18);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(142, 15);
            this.txtNamaSupplier.TabIndex = 0;
            this.txtNamaSupplier.Text = "Masukkan Nama Supplier";
            // 
            // txtNamaSup
            // 
            this.txtNamaSup.Location = new System.Drawing.Point(172, 15);
            this.txtNamaSup.Name = "txtNamaSup";
            this.txtNamaSup.Size = new System.Drawing.Size(292, 23);
            this.txtNamaSup.TabIndex = 1;
            this.txtNamaSup.TextChanged += new System.EventHandler(this.txtNamaSup_TextChanged);
            // 
            // dgvSup
            // 
            this.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSup.Location = new System.Drawing.Point(0, 104);
            this.dgvSup.Name = "dgvSup";
            this.dgvSup.RowTemplate.Height = 25;
            this.dgvSup.Size = new System.Drawing.Size(704, 319);
            this.dgvSup.TabIndex = 2;
            this.dgvSup.DoubleClick += new System.EventHandler(this.dgvSup_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 423);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSup);
            this.Controls.Add(this.txtNamaSup);
            this.Controls.Add(this.txtNamaSupplier);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtNamaSupplier;
        private TextBox txtNamaSup;
        private DataGridView dgvSup;
        private Button btnSearch;
    }
}