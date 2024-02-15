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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=KitapListesi");
        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komut = new SqlCommand("select * from Table_1 where KullanıcıAd=@ad and Şifre=@parola", Veritabani);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@parola", textBox2.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                Form1 ana = new Form1();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            Veritabani.Close();
        }
    }
}
