using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kitap_Kayıt_2
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }

        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=KitapListesi");
        private void Grafik_Load(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komut1 = new SqlCommand("select KitYazar,Count(*) from KitapListesi group by KitYazar", Veritabani);
            SqlDataReader okuyucu1 = komut1.ExecuteReader();
            while (okuyucu1.Read())
            {
                chart2.Series["Kitap Sayısı"].Points.AddXY(okuyucu1[0], okuyucu1[1]);
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut2 = new SqlCommand("select KitYazar,AVg(KitSayfa) from KitapListesi group by KitYazar", Veritabani);
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                chart1.Series["ort. Sayfa Sayısı"].Points.AddXY(okuyucu2[0], okuyucu2[1]);
            }
            Veritabani.Close();
        }
    }
}
