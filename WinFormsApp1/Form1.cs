using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace WinFormsApp1
{
    
  
   
    public partial class Form1 : Form
      

    {
        public int password;
        public int sayac = 2;
        public bool kartGirildi = false;
        
        
        public Form1()
        {       
            InitializeComponent();
            Color bcolor = Color.FromArgb(255, 130, 100);
            BackColor = bcolor;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            label1.Text = "Şifre Giriniz:";
            label1.Font = new Font("", 14, FontStyle.Bold);
            MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackgroundImage = Properties.Resources.Slider_CL01_Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        void GirisEkran()
        {
            button1.Visible = false;
            button2.Visible = true;
           // button3.Visible = true;   Hızlı Giris !
            button4.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            password = random.Next(1000, 10000);
            MessageBox.Show(Convert.ToString("Şifreniz: " + password));
            kartGirildi = true;
            int para;
            Random rand = new Random();
            para = rand.Next(0, 100000);
            GirisEkran();
   
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool eksikGiris = false;
            if (kartGirildi == false)
                MessageBox.Show("Kartınızı Takınız.");
            if (kartGirildi == true) { 
            if (input.Length != 4)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız. Lütfen Tekrar Deneyin");
                eksikGiris = true;
            }
            else
                eksikGiris = false;
                if (eksikGiris == false)
                {
                    if (input == Convert.ToString(password))
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else

                        MessageBox.Show("Hatalı Giriş Yaptınız. " + sayac + " Hakkınız Kaldı !");
                    sayac--;
                    if (sayac < 0)
                    {
                        MessageBox.Show("3 Kez Hatalı Giriş Yaptınız Kartınız Bloke Olmuştur.");
                        this.Close();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

