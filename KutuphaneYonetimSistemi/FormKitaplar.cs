using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        
        public FormKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbYTAKutuphane; Integrated Security = True");
        private void verilerigoster()
        {
            string sql = "select * from TableKitaplar";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void combouyeler()
        {
            string sql = "select * from TableUyeEkle";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
            }
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verilerigoster();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            combouyeler();

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                com.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                com.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                com.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                com.Parameters.AddWithValue("@p4", textBoxIsbn.Text);
                com.Parameters.AddWithValue("@p5", "False");
                com.Parameters.AddWithValue("@p6", textBoxKitapTurKodu.Text);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken hata oluştu " + ex.Message);

            }
            finally
            {
                con.Close();
            }


            verilerigoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[secilensatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridView1.Rows[secilensatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridView1.Rows[secilensatir].Cells[3].Value.ToString();
            textBoxIsbn.Text = dataGridView1.Rows[secilensatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridView1.Rows[secilensatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridView1.Rows[secilensatir].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilensatir].Cells[7].Value != DBNull.Value)
            {
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[secilensatir].Cells[7].Value;
            }
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @p1, YazarAdi = @p2,YazarSoyadi = @p3,ISBN = @p4,KitapTurKodu=@p5 WHERE ID= @p6", con);
                com.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                com.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                com.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                com.Parameters.AddWithValue("@p4", textBoxIsbn.Text);
                com.Parameters.AddWithValue("@p5", textBoxKitapTurKodu.Text);
                com.Parameters.AddWithValue("@p6", label2.Text);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken hata oluştu " + ex.Message);

            }
            finally
            {
                con.Close();
            }


            verilerigoster();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @p1, OdunAlmaTarihi = @p2,Durum = @p3 WHERE ID =@p4", con);
                    com.Parameters.AddWithValue("@p1", textBoxOduncAlan.Text);
                    com.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    com.Parameters.AddWithValue("@p3", "True");
                    com.Parameters.AddWithValue("@p4", label2.Text);
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap Ödünç verilirken hata oluştu " + ex.Message);

                }
                finally
                {
                    con.Close();
                }


                verilerigoster();

            }
            else
            {
                MessageBox.Show("Lütfen Kitap Seçiniz");
            }
        }

        private void buttonGecikmeBedeli_Click(object sender, EventArgs e)
        {
            Random randomsayi = new Random();
            int rastgelesayi = randomsayi.Next(1, 1000);
            if (label2.Text != "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int GunFarki = (int)(bugununTarihi - dateTimePicker1.Value.Date).TotalDays;
                if (GunFarki > 10)
                {
                    int gecikmebedeli = (GunFarki - 10) * 1;
                    labelGecikmeBedeli.Text = gecikmebedeli.ToString();

                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @p1, OdunAlmaTarihi = @p2,Durum = @p3 WHERE ID =@p4", con);
                    com.Parameters.AddWithValue("@p1", "");
                    com.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value;
                    com.Parameters.AddWithValue("@p3", "False");
                    com.Parameters.AddWithValue("@p4", label2.Text);
                    textBoxOduncAlan.Text = "";
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade edilirken hata oluştu " + ex.Message);

                }
                finally
                {
                    con.Close();
                }


                verilerigoster();

            }
            else
            {
                MessageBox.Show("Lütfen Kitap Seçiniz");
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxKitapTurKodu.Text = "";
            textBoxIsbn.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyadi.Text = "";
            textBoxOduncAlan.Text = "";
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aranmasonuclarigoster();
        }
        private void aranmasonuclarigoster()
        {

            string sql = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdi.Text + "%' AND YazarAdi LIKE   '" + textBoxYazarAdi.Text + "%' AND YazarSoyadi LIKE '" + textBoxYazarSoyadi.Text + "%' AND ISBN LIKE '" + textBoxIsbn.Text + "%' AND KitapTurKodu LIKE '" + textBoxKitapTurKodu.Text + "%' AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "%' ";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonButunKitaplar_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("DELETE TableKitaplar WHERE ID =@p1", con);
                    com.Parameters.AddWithValue("@p1", label2.Text);
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silinirken hata oluştu " + ex.Message);

                }
                finally
                {
                    con.Close();
                }


                verilerigoster();

            }
        }

        private void FormKitaplar_FormClosing(object sender, FormClosingEventArgs e)
        {

           
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            uyeekle uyekle = new uyeekle();
            uyekle.Show();
            

            
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program hala gelişim aşamasındadır.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
