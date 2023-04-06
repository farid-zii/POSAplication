namespace POSAplication.FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnHitungLuasSegitiga.Click += BtnHitungLuasSegitiga_Click;
        }

        private void BtnHitungLuasSegitiga_Click(object? sender, EventArgs e)
        {
            double alas = Convert.ToDouble(txtAlas.Text);
            double tinggi = Convert.ToDouble(txtTinggi.Text);
            double luasSegitiga = 0.5 * alas * tinggi;
            txtLuas.Text = luasSegitiga.ToString();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World !!";
            MessageBox.Show("Hello .NET Core Desktop");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //Konversi dari tipe text ke tipe Double
            double dbBil1 = Convert.ToDouble(txtBil1.Text);
            double dbBil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = 0.0;
            if (rbtnTambah.Checked)
            {
               hasil = dbBil1 + dbBil2;
              
            }
            else if (rbtnKurang.Checked)
            {
              hasil = dbBil1 - dbBil2;
               
            }
            if (rbtnKali.Checked)
            {
               hasil = dbBil1 * dbBil2;

            }
            if (rbtnBagi.Checked)
            {
                hasil = dbBil1 / dbBil2;

            }
            txtHasil.Text = hasil.ToString();

        }
    }
}