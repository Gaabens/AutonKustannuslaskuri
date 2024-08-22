namespace AutonKustannuslaskuri
{
    public partial class KustannusForm : Form
    {
        public KustannusForm()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, kustannukset;

            laina = Convert.ToDouble(LainaTB.Text);

            nesteet = Convert.ToDouble(NesteetTB.Text);

            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);

            pesut = Convert.ToDouble(PesutTB.Text);

            huollot = Convert.ToDouble(HuollotTB.Text);

            renkaat = Convert.ToDouble(RenkaatTB.Text);

            muut = Convert.ToDouble(MuutKulutTB.Text);

            kilometrit = Convert.ToDouble(KilometritCB.Text);

            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut) / (kilometrit / 12);

            VastausLB.Text = "Kustannukset kilometriä kohti ovat:" + kustannukset;

            VastausLB.Visible = true;

        }

    }

}
