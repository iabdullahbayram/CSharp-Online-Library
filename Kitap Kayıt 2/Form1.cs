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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=KitapListesi");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet2.KitapListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            // TODO: Bu kod satırı 'dataSet1.KitapListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }
        
        void temizle()
        {
            textadi.Text = "";
            textsayfa.Text = "";
            textucret.Text = "";
            textyazar.Text = "";
            textnumara.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textadi.Focus();

        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            this.kitapListesiTableAdapter.Fill(this.dataSet1.KitapListesi);
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komut = new SqlCommand("insert into KitapListesi (KitAd,KitYazar,KitSayfa,KitÜcret,KitYaşam) values (@a,@y,@s,@ü,@ya)",Veritabani);
            komut.Parameters.AddWithValue("@a", textadi.Text);
            komut.Parameters.AddWithValue("@y", textyazar.Text);
            komut.Parameters.AddWithValue("@s", textsayfa.Text);
            komut.Parameters.AddWithValue("@ü", textucret.Text);
            komut.Parameters.AddWithValue("@ya", label7.Text);
            
            komut.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Kitap Eklendi");
        }
        
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "False";
        }

        private void buttontemiz_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textnumara.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textadi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textsayfa.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textucret.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textyazar.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            label7.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            if (label7.Text == "True")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            
            
            
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutsil = new SqlCommand("Delete From KitapListesi where KitNo=@sil", Veritabani);
            komutsil.Parameters.AddWithValue("@sil", textnumara.Text);
            komutsil.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Kayıt Silindi");
            temizle();
            this.kitapListesiTableAdapter.Fill(this.dataSet1.KitapListesi);
        }

        private void buttonguncel_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update KitapListesi Set KitAd=@ad,KitYazar=@yazar,KitSayfa=@sayfa,KitÜcret=@ücret,KitYaşam=@yaşam Where KitNo=@no", Veritabani);
            komutgüncelle.Parameters.AddWithValue("@ad", textadi.Text);
            komutgüncelle.Parameters.AddWithValue("@yazar", textyazar.Text);
            komutgüncelle.Parameters.AddWithValue("@sayfa", textsayfa.Text);
            komutgüncelle.Parameters.AddWithValue("@ücret", textucret.Text);
            komutgüncelle.Parameters.AddWithValue("@yaşam", label7.Text);
            komutgüncelle.Parameters.AddWithValue("@no", textnumara.Text);
            komutgüncelle.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Güncellendi");
            temizle();
            this.kitapListesiTableAdapter.Fill(this.dataSet1.KitapListesi);
        }

        private void buttonistat_Click(object sender, EventArgs e)
        {
            istatistik ist = new istatistik();
            ist.Show();
        }

        private void buttongraf_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.Show();
        }
    }
}
