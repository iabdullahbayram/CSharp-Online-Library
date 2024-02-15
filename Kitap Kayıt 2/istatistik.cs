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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=KitapListesi");

        private void istatistik_Load(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komut = new SqlCommand("select count(*) from KitapListesi",Veritabani);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                toplamKitap.Text = okuyucu[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from KitapListesi Where KitYaşam=1", Veritabani);
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                yaşayanSayısı.Text = okuyucu2[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from KitapListesi Where KitYaşam=0", Veritabani);
            SqlDataReader okuyucu3 = komut3.ExecuteReader();
            while (okuyucu3.Read())
            {
                ölüSayısı.Text = okuyucu3[0].ToString();

            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(KitYazar)) from KitapListesi", Veritabani);
            SqlDataReader okuyucu4 = komut4.ExecuteReader();
            while (okuyucu4.Read())
            {
                farklıYazar.Text = okuyucu4[0].ToString();

            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut5 = new SqlCommand("select sum(KitÜcret) from KitapListesi", Veritabani);
            SqlDataReader okuyucu5 = komut5.ExecuteReader();
            while (okuyucu5.Read())
            {
                toplamÜcret.Text = okuyucu5[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komut6 = new SqlCommand("select AVg(KitÜcret) from KitapListesi", Veritabani);
            SqlDataReader okuyucu6 = komut6.ExecuteReader();
            while (okuyucu6.Read())
            {
                ortalamaÜcret.Text = okuyucu6[0].ToString();
            }
            Veritabani.Close();
        }
    }
}

