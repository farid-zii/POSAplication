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
    public partial class FormBarang : Form
    {

        #region Singleton
        private static FormBarang _instance;
        public static FormBarang Instance()
        {
            if (_instance == null)
                _instance = new FormBarang();
            return _instance;
        }
        #endregion

        private BarangDAL barangDAL;

        private BindingSource bs;
        private bool isNew = false;

        public FormBarang()
        {
            InitializeComponent();
            barangDAL = new BarangDAL();
            bs = new BindingSource();
        }

        #region Data Binding
        private void TambahBinding()
        {
            txtKodeBarang.DataBindings.Add("Text", bs, "KodeBarang");
            txtNamaBarang.DataBindings.Add("Text", bs, "NamaBarang");
            txtBeli.DataBindings.Add("Text", bs, "HargaBeli");
            txtBeli.DataBindings[0].FormattingEnabled = true;
            txtBeli.DataBindings[0].FormatString = "N0";

            txtJual.DataBindings.Add("Text", bs, "HargaJual");
            txtJual.DataBindings[0].FormattingEnabled = true;
            txtJual.DataBindings[0].FormatString = "N0";
            txtStock.DataBindings.Add("Text", bs, "Stok");
            dateTanggal.DataBindings.Add("Value", bs, "TanggalBeli");
            txtKeterangan.DataBindings.Add("Text", bs, "Keterangan");
        }

        private void HapusBinding()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtBeli.DataBindings.Clear();
            txtJual.DataBindings.Clear();
            txtStock.DataBindings.Clear();
            dateTanggal.DataBindings.Clear();
            txtKeterangan.DataBindings.Clear();
        }
        #endregion

        private void InisialisasiAwal()
        {
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtBeli.Enabled = false;
            txtJual.Enabled = false;
            txtStock.Enabled = false;
            dateTanggal.Enabled = false;
            txtKeterangan.Enabled = false;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;

            IsiDataBarang();
            TambahBinding();
            isNew = false;
        }

        private void InisialisasiNew()
        {
            HapusBinding();
            foreach (var ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    var myTextBox = ctr as TextBox;
                    myTextBox.Enabled = true;
                    myTextBox.Text = String.Empty;
                }
                else if(ctr is Button)
                {
                    var myButton = ctr as Button;
                    myButton.Enabled = false;
                }
            }
            dateTanggal.Enabled = true;
            txtKodeBarang.Focus();
            btnSave.Enabled = true;
            isNew = true;
        }

        private void InsialisasiEdit()
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
            dateTanggal.Enabled = true;
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Focus();
            btnSave.Enabled = true;
            isNew = false;
        }


        private void InsertBarang()
        {
            try
            {
                var newBarang = new Barang
                {
                    KodeBarang = txtKodeBarang.Text,
                    NamaBarang = txtNamaBarang.Text,
                    HargaBeli = Convert.ToDecimal(txtBeli.Text),
                    HargaJual = Convert.ToDecimal(txtJual.Text),
                    Stok = Convert.ToInt32(txtStock.Text),
                    TanggalBeli = Convert.ToDateTime(dateTanggal.Value),
                    Keterangan = txtKeterangan.Text
                };
                int result = barangDAL.Insert(newBarang);
                if(result == 1) 
                {
                    MessageBox.Show($"Data Barang {newBarang.NamaBarang} Berhasil Ditambahkan");
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

        private void UpdateBarang()
        {
            try
            {
                var editBarang = new Barang
                {
                    KodeBarang = txtKodeBarang.Text,
                    NamaBarang = txtNamaBarang.Text,
                    HargaBeli = Convert.ToDecimal(txtBeli.Text),
                    HargaJual = Convert.ToDecimal(txtJual.Text),
                    Stok = Convert.ToInt32(txtStock.Text),
                    TanggalBeli = Convert.ToDateTime(dateTanggal.Value),
                    Keterangan = txtKeterangan.Text
                };
                int result = barangDAL.Update(editBarang);
                if (result == 1)
                {
                    MessageBox.Show($"Data Barang {editBarang.KodeBarang} Berhasil Edit");
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


        private void IsiDataBarang()
        {
            bs.DataSource = barangDAL.GetAll();
            dgvBarang.DataSource = bs;
        }

        private void SearchData(String nama)
        {
            try
            {
                HapusBinding();
                bs.Clear();
                var result = barangDAL.GetByNama(nama);
                bs.DataSource = result;
                dgvBarang.DataSource = bs;
                TambahBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            InisialisasiAwal();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InisialisasiNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew) 
            {
                InsertBarang();
            }
            else
            {
                UpdateBarang();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InsialisasiEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show("Apakah anda yakin akan mendelete data?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if(output == DialogResult.Yes)
            {
                try
                {
                    HapusBinding();
                    int result = barangDAL.Delete(txtKodeBarang.Text);
                    if(result == 1)
                    {
                        MessageBox.Show("Data barang berhasil di delete", "Konfirmasi",
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

        private void dgvBarang_DoubleClick(object sender, EventArgs e)
        {
            Barang curBarang = (Barang)bs.Current;
            FormPembelian.Instance().TxtKodeBarang.Text = curBarang.KodeBarang.ToString();
            FormPembelian.Instance().TxtNamaBarang.Text = curBarang.NamaBarang.ToString();
            FormPembelian.Instance().TxtHarga.Text = curBarang.HargaJual.ToString();
            FormPembelian.Instance().TxtQty.Focus();


            this.Hide();
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtCariBarang.Text.Length >= 2)
            {
                SearchData(txtCariBarang.Text);
            }
            else if (txtCariBarang.Text.Length == 0)
            {
                IsiDataBarang();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            
        }
    }
}
