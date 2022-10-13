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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbYTAKutuphane; Integrated Security = True");

        private void kayitol_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            try
            {
                if (checkBox1.Checked.ToString()== "True")
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO TableKutuphaneYoneticileri (KullaniciAdi,Sifre) VALUES (@p1,@p2)", con);
                    com.Parameters.AddWithValue("@p1", textBox1.Text);
                    com.Parameters.AddWithValue("@p2", textBox2.Text.ToString());
                    com.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bot olmadığını kanıtla!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
                
                
               
            }
            catch (Exception ex )
            {

                MessageBox.Show("Eklenirken Hata Oluştu!!",ex.Message);
            }
            finally
            {

                MessageBox.Show("Kayıt oluştu");
                con.Close();
                FormGiris frmgiriss = new FormGiris();
                frmgiriss.ShowDialog();
               
            }

            
            
         
            
            
            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiris frmgiris1 = new FormGiris();
            frmgiris1.ShowDialog();
        }
    }
}
