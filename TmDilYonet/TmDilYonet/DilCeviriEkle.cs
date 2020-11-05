using System;
using System.Linq;
using System.Windows.Forms;

namespace TmDilYonet
{
    public partial class DilCeviriEkle : Form
    {
        public DilCeviriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string resourceKey = txtResourceKey.Text;
            string resourceValue = txtResourceValue.Text;
            string dilId = txtUygulamaDilId.Text;

            if (!String.IsNullOrWhiteSpace(resourceKey) && !String.IsNullOrWhiteSpace(resourceValue) && !String.IsNullOrWhiteSpace(dilId))
            {
                using (DataClassesTMDataContext db = new DataClassesTMDataContext())
                {
                    tblUygulamaDilCeviri tblUygulamaDilCeviri = new tblUygulamaDilCeviri();

                    if (lblHiddenDilCeviriId.Text != "0")
                        tblUygulamaDilCeviri = db.tblUygulamaDilCeviris.FirstOrDefault(x => x.AutoId.ToString() == lblHiddenDilCeviriId.Text);

                    tblUygulamaDilCeviri.ResourceKey = resourceKey;
                    tblUygulamaDilCeviri.ResourceValue = resourceValue;
                    tblUygulamaDilCeviri.UygulamaDilId = Convert.ToInt32(dilId);

                    if (lblHiddenDilCeviriId.Text == "0")
                        db.tblUygulamaDilCeviris.InsertOnSubmit(tblUygulamaDilCeviri);

                    db.SubmitChanges();

                    MessageBox.Show("İşlem başarıyla kayıt edildi.");

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerleri lütfen kontrol ediniz.");
            }

        }

        private void DilCeviriEkle_Load(object sender, EventArgs e)
        {
            int dilCeviriId = Form1.DilCeviriId;
            lblHiddenDilCeviriId.Text = dilCeviriId.ToString();

            txtResourceKey.Text = "";
            txtResourceValue.Text = "";
            txtUygulamaDilId.Text = "";

            if (dilCeviriId != 0)
            {
                using (DataClassesTMDataContext db = new DataClassesTMDataContext())
                {
                    var dilCeviri = db.tblUygulamaDilCeviris.FirstOrDefault(x => x.AutoId == dilCeviriId);

                    txtResourceKey.Text = dilCeviri.ResourceKey;
                    txtResourceValue.Text = dilCeviri.ResourceValue;
                    txtUygulamaDilId.Text = dilCeviri.UygulamaDilId.ToString();
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
