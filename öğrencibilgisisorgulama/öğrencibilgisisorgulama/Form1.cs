using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace öğrencibilgisisorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            // Öğrenci bilgilerini al
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            // Doğrulama
            Type type = typeof(Ogrenci);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                // Özelliğin değerini al
                object value = prop.GetValue(ogrenci);
                // Attribute'u al
                var attribute = (ZorunluAlanAttribute)prop.GetCustomAttribute(typeof(ZorunluAlanAttribute));

                if (attribute != null && string.IsNullOrWhiteSpace(value?.ToString()))
                {
                    MessageBox.Show(attribute.HataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Eğer tüm alanlar doluysa ekrana yaz
            label4.Text = $"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Bölüm: {ogrenci.Bolum}";
        }
        }
    }

