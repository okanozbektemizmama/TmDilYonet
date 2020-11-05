using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Windows.Forms;

namespace TmDilYonet
{
    public partial class Form1 : Form
    {
        public static int DilCeviriId = 0;
        AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dil çeviri listesini geri göndürür.
        /// </summary>
        /// <param name="AramaKey">Arama Metni</param>
        /// <param name="resourceKey">True ise kaynak ResourceKey'e göre arama yapar.</param>
        /// <param name="resourceValue">True ise kaynak ResourceValue'e göre arama yapar.</param>
        /// <returns></returns>
        List<tblUygulamaDilCeviri> DilCevirileriGetir(string AramaKey = "", bool resourceKey = false, bool resourceValue = false)
        {
            List<tblUygulamaDilCeviri> uygulamaDilCeviris = new List<tblUygulamaDilCeviri>();

            try
            {
                using (DataClassesTMDataContext db = new DataClassesTMDataContext())
                {
                    AramaKey = AramaKey.ToLower();
                    uygulamaDilCeviris = db.tblUygulamaDilCeviris.ToList();

                    if (!String.IsNullOrWhiteSpace(AramaKey) && resourceKey == false && resourceValue == false)
                        uygulamaDilCeviris = uygulamaDilCeviris.Where(x => x.ResourceKey.ToLower().Contains(AramaKey) || x.ResourceValue.ToLower().Contains(AramaKey)).ToList();
                    else if (resourceKey && !String.IsNullOrWhiteSpace(AramaKey))
                        uygulamaDilCeviris = uygulamaDilCeviris.Where(x => x.ResourceKey.ToLower().Contains(AramaKey)).ToList();
                    else if (resourceValue && !String.IsNullOrWhiteSpace(AramaKey))
                        uygulamaDilCeviris = uygulamaDilCeviris.Where(x => x.ResourceValue.ToLower().Contains(AramaKey)).ToList();
                    else
                    {
                        if (uygulamaDilCeviris.Count > 50)
                            uygulamaDilCeviris = uygulamaDilCeviris.Take(50).ToList();
                    }
                }
            }
            catch (Exception)
            {
               
            }
            

            return uygulamaDilCeviris;
        }

        private void DilleriDoldurGrid(List<tblUygulamaDilCeviri> uygulamaDilCeviris)
        {

            try
            {
                var source = new BindingSource();
                source.DataSource = uygulamaDilCeviris;
                dtViewDiller.DataSource = source;
                dtViewDiller.AllowUserToAddRows = false;

                if (uygulamaDilCeviris.Count <= 0)
                    MessageBox.Show("Aradığınız kritere uygun kayıt bulunamadı.");
            }
            catch (Exception ex)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var dilCeviri = DilCevirileriGetir();
                DilleriDoldurGrid(dilCeviri);
            }
            catch (Exception ex)
            {

            }
            

        }

        private void dtViewDiller_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dtViewDiller.Rows[e.RowIndex];
                    string copy = row.Cells[2].Value.ToString();
                    Clipboard.SetText(copy);
                }
                catch (Exception ex)
                {

                }
                

            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            var dilCeviri = DilCevirileriGetir(txtArama.Text,false,false);
            DilleriDoldurGrid(dilCeviri);

            if (dilCeviri.Count > 0)
            {
                try
                {
                    dtViewDiller.CurrentCell = dtViewDiller.Rows[0].Cells[2];
                    Clipboard.SetText(dtViewDiller.Rows[0].Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {

                }
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DilCeviriId = 0;
                DilCeviriEkle dilCeviriEkle = new DilCeviriEkle();
                this.Hide();
                dilCeviriEkle.Closed += (s, args) => this.Close();
                dilCeviriEkle.Show();
            }
            catch (Exception ex)
            {

            }
           
        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dilCeviri = DilCevirileriGetir(txtArama.Text,true,false);
                DilleriDoldurGrid(dilCeviri);

                if (dilCeviri.Count > 0)
                {
                    try
                    {
                        dtViewDiller.CurrentCell = dtViewDiller.Rows[0].Cells[2];
                        Clipboard.SetText(dtViewDiller.Rows[0].Cells[2].Value.ToString());
                    }
                    catch (Exception ex)
                    {

                    }
                }         

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

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (txtArama.Text.Length >= 3)
            {
                var dilCeviri = DilCevirileriGetir(txtArama.Text, true,false);
                string[] searchName = new string[dilCeviri.Count];

                int index = 0;
                foreach (var item in dilCeviri)
                {
                    searchName[index] = item.ResourceKey;
                    index += 1;
                }

                txtArama.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtArama.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtArama.AutoCompleteCustomSource.AddRange(searchName);
            }
        }

        private void txtResourceValue_TextChanged(object sender, EventArgs e)
        {
            if (txtResourceValue.Text.Length >= 3)
            {
                var dilCeviri = DilCevirileriGetir(txtResourceValue.Text, false,true);
                string[] searchName = new string[dilCeviri.Count];

                int index = 0;
                foreach (var item in dilCeviri)
                {
                    searchName[index] = item.ResourceValue;
                    index += 1;
                }

                txtResourceValue.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtResourceValue.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtResourceValue.AutoCompleteCustomSource.AddRange(searchName);
            }
        }

        private void txtResourceValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var dilCeviri = DilCevirileriGetir(txtResourceValue.Text, false, true);
                DilleriDoldurGrid(dilCeviri);
                if (dilCeviri.Count > 0)
                {
                    try
                    {
                        dtViewDiller.CurrentCell = dtViewDiller.Rows[0].Cells[2];
                        Clipboard.SetText(dtViewDiller.Rows[0].Cells[2].Value.ToString());
                    }
                    catch (Exception ex)
                    {

                    }
                }         
            }
        }
    }
}
