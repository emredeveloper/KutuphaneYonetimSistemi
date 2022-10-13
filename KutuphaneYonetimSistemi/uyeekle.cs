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
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbYTAKutuphane; Integrated Security = True");

        private void uyelerigoster()
        {
            string sql = "select * from TableUyeEkle";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bilgi Ekle");
            }
        }
        private void uyeekle_Load(object sender, EventArgs e)
        {
            uyelerigoster();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO TableUyeEkle (Adi,Soyadi,Telefon,Cinsiyet) VALUES (@p1,@p2,@p3,@p4)", con);
                if (textBox1.Text != "")
                {
                    com.Parameters.AddWithValue("@p1", textBox1.Text);

                }
                else if (textBox1.Text== dataGridView1.Rows[0].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Aynı isim olamaz");
                }
                else
                {
                    MessageBox.Show("Lütfen İsim Giriniz");

                }
                if (textBox2.Text!= "")
                {
                    com.Parameters.AddWithValue("@p2", textBox2.Text);

                }
                else
                {
                    MessageBox.Show("Lütfen Soyadınızı giriniz");
                }
                if (textBox3.Text != "")
                {
                    com.Parameters.AddWithValue("@p3", textBox3.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen Telefon Numaranızı giriniz");
                }
                

               

                if (radioButton1.Checked.ToString() == "True")
                {
                    com.Parameters.AddWithValue("@p4", radioButton1.Text);
                }
                else
                {
                    com.Parameters.AddWithValue("@p4", radioButton2.Text);
                }



                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               //  MessageBox.Show("Üye Eklenirken hata oluştu " + ex.Message);

            }
            finally
            {
                con.Close();
            }
            
            uyelerigoster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }

        
}

