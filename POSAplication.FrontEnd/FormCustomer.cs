using POSAplication.FrontEnd.DAL;
using POSAplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAplication.FrontEnd
{
    public partial class FormCustomer : Form
    {
        private CustomersDAL customerDAL;

        private BindingSource bs;
        private bool isNew = false;

        public FormCustomer()
        {
            InitializeComponent();
            customerDAL = new CustomersDAL();
            bs = new BindingSource();
        }

        private void TambahBinding()
        {
            txtID.DataBindings.Add("Text", bs, "CustomerId");
            txtNama.DataBindings.Add("Text", bs, "Nama");
            txtAlamat.DataBindings.Add("Text", bs, "Alamat");
            txtTelp.DataBindings.Add("Text", bs, "Telp");
            date.DataBindings.Add("Value", bs, "TanggalJoin");
        }

        private void ClearBinding()
        {
            txtID.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtTelp.DataBindings.Clear();
            date.DataBindings.Clear();
        }

        private void InisialisasiAwal()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelp.Enabled = false;
            date.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;

            IsiDataCustomer();
            TambahBinding();
            isNew = false;
        }

        private void InisialisasiNew()
        {
            ClearBinding();
            foreach (var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    var myTextBox = ctr as TextBox;
                    myTextBox.Enabled = true;
                    myTextBox.Text = String.Empty;
                }
                else if (ctr is Button)
                {
                    var myButton = ctr as Button;
                    myButton.Enabled = false;
                }
            }
            date.Enabled = true;
            txtID.Focus();
            btnSave.Enabled = true;
            isNew = true;
        }

        private void InsialisasiUpdate()
        {
            foreach (var ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    var myTextBox = ctr as TextBox;
                    myTextBox.Enabled = true;
                    myTextBox.Text = String.Empty;
                }
                else if (ctr is Button)
                {
                    var myButton = ctr as Button;
                    myButton.Enabled = false;
                }
            }
            date.Enabled = true;
            txtID.Enabled = false;
            txtNama.Focus();
            btnSave.Enabled = true;
            isNew = false;
        }

        private void InsertCustomer()
        {
            try
            {
                var newCustomer = new Customer
                {
                    CustomerId = Convert.ToInt32(txtID.Text),
                    Nama = txtNama.Text,
                    Alamat = txtAlamat.Text,
                    Telp = txtTelp.Text,
                    TanggalJoin = Convert.ToDateTime(date.Value)
                };
                int result = customerDAL.Insert(newCustomer);
                if (result == 1)
                {
                    MessageBox.Show($"Data Customer {newCustomer.Nama} Berhasil Ditambahkan");
                    InisialisasiAwal();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan Data", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateCustomer()
        {
            try
            {
                var editCustomer = new Customer
                {
                    CustomerId = Convert.ToInt32(txtID.Text),
                    Nama = txtNama.Text,
                    Alamat = txtAlamat.Text,
                    Telp = txtTelp.Text,
                    TanggalJoin = Convert.ToDateTime(date.Value)
                };
                int result = customerDAL.Update(editCustomer);
                if (result == 1)
                {
                    MessageBox.Show($"Data Customer {editCustomer.CustomerId} Berhasil Edit");
                    InisialisasiAwal();
                }
                else
                {
                    MessageBox.Show("Gagal Edit Data", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void IsiDataCustomer()
        {
            bs.DataSource = customerDAL.GetAll();
            dgvCustomer.DataSource = bs;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            InisialisasiAwal();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InisialisasiNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                InsertCustomer();
            }
            else
            {
                UpdateCustomer();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InsialisasiUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show("Apakah anda yakin akan mendelete data?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (output == DialogResult.Yes)
            {
                try
                {
                    ClearBinding();
                    int result = customerDAL.Delete(Convert.ToInt32(txtID.Text));
                    if (result == 1)
                    {
                        MessageBox.Show("Data Customer berhasil di delete", "Konfirmasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InisialisasiAwal();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal di delete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            bs.DataSource = customerDAL.ByNama();
            dgvCustomer.DataSource = bs;
        }

        private void btnALamat_Click(object sender, EventArgs e)
        {
            bs.DataSource = customerDAL.ByAlamat();
            dgvCustomer.DataSource = bs;
        }
    }
}
