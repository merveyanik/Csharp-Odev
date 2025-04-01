namespace formuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakitTuketimi = txtYakitTuketimi.Text;

            // Bilgileri birleştirerek mesaj kutusunda gösteriyoruz
            string mesaj = $"Araba Bilgileri:\n\n" +
                           $" Marka: {marka}\n" +
                           $" Model: {model}\n" +
                           $" Renk: {renk}\n" +
                           $" Kapı Sayısı: {kapiSayisi}\n" +
                           $" Pencere Sayısı: {pencereSayisi}\n" +
                           $" 100 km’de Yakıt Tüketimi: {yakitTuketimi} Litre";

            MessageBox.Show(mesaj, "Araba Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
