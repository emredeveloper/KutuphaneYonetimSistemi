using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        

        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbYTAKutuphane; Integrated Security = True");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TableKutuphaneYoneticileri WHERE KullaniciAdi =\'" + textBoxKullaniciAdi.Text + "\' AND Sifre=\'" + textBoxSifre.Text + "\';", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Kullan�c� Ad� ve �ifre Do�ru");
                    FormKitaplar frmktp = new FormKitaplar();
                    this.Hide();
                    frmktp.ShowDialog();
                    con.Close();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Giri� Yap�l�rken Hata Olu�tu!!!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
            
            

        }

        private void buttonGiris_MouseMove(object sender, MouseEventArgs e)
        {
            
            buttonGiris.BackColor = Color.AliceBlue;
        }

        private void buttonGiris_MouseLeave(object sender, EventArgs e)
        {
            buttonGiris.BackColor= Color.White;
        }

       
        

        private void textBoxSifre_MouseUp(object sender, MouseEventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 3000;
            tool.InitialDelay = 1000;
            tool.ReshowDelay = 500;
            tool.ToolTipIcon = ToolTipIcon.Info;
            tool.ForeColor = Color.Red;
            tool.Show("�ifrenizi Giriniz!", textBoxSifre);
        }

        private void textBoxKullaniciAdi_MouseUp(object sender, MouseEventArgs e)
        {

            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 3000;
            tool.InitialDelay = 1000;
            tool.ReshowDelay = 500;
            tool.ToolTipIcon = ToolTipIcon.Info;
            tool.ForeColor = Color.Red;
            tool.Show("Kullan�c� Ad�n�z� Giriniz!", textBoxKullaniciAdi);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ncelikle sa� taraftan bilgilerimizi giriyoruz. Girdikten sonra kar��m�za ��kan ekranda Kitaplar ile ilgili i�lemler yapacaks�n�z. E�er Durum i�areti tikli ise kitap �d�n� verilmi�tir anlam�na gelir. Gecikme bedeli ise her 10 g�nden sonra 1 TL olarak hesaplanmaktad�r.", "Nas�l Kullan�l�r?", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
            {
                try
                {
                    VisitLink();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

             void VisitLink()
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/cihatemrekaratas");
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayitol frmkayit = new kayitol();
            frmkayit.ShowDialog(); 

        }
    }
}