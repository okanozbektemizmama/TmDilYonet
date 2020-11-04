using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmDilYonet
{
    public partial class Form1 : Form
    {
        public static int DilCeviriId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Dillerigetir(string AramaKey = "")
        {

            dtViewDiller.Refresh();

            using (DataClassesTMDataContext db = new DataClassesTMDataContext())
            {
                List<tblUygulamaDilCeviri> uygulamaDilCeviris = new List<tblUygulamaDilCeviri>();

                AramaKey = AramaKey.ToLower();

                uygulamaDilCeviris = db.tblUygulamaDilCeviris.ToList();

                if (!String.IsNullOrWhiteSpace(AramaKey))
                    uygulamaDilCeviris = uygulamaDilCeviris.Where(x => x.ResourceKey.ToLower().Contains(AramaKey) || x.ResourceValue.ToLower().Contains(AramaKey)).ToList();

                dtViewDiller.DataSource = uygulamaDilCeviris;
                dtViewDiller.AllowUserToAddRows = true;           

                if (uygulamaDilCeviris.Count <= 0)
                    MessageBox.Show("Aradığınız kritere uygun kayıt bulunamadı.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dillerigetir();
        }

        private void dtViewDiller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dtViewDiller.RowCount > 0)
                {
                    if (e.ColumnIndex == 4)
                    {
                        
                    }
                }
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            Dillerigetir(txtArama.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DilCeviriEkle dilCeviriEkle = new DilCeviriEkle();
            this.Hide();
            dilCeviriEkle.Closed += (s, args) => this.Close();
            dilCeviriEkle.Show();
        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Dillerigetir(txtArama.Text);
            }
        }

        private void dtViewDiller_DoubleClick(object sender, EventArgs e)
        {
            DilCeviriId = (int)dtViewDiller.CurrentRow.Cells[0].Value;
            DilCeviriEkle dilCeviriEkle = new DilCeviriEkle();
            dilCeviriEkle.Show();

            this.Hide();
            dilCeviriEkle.Closed += (s, args) => this.Close();
            dilCeviriEkle.Show();
        }
    }
}
