using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public bool bpBakiyeSorgulama = false;
        public bool bpParaCekme = false;
        public bool bpParaYatırma = false;
        public bool bpAnamenu = true;
        public bool bpSonIslem = false;
        public bool bpDoviz = false;
        public bool bpDovizAlEkran = false;
        public bool bpDovizAlındı = false;
        public bool bpDovizBakiyesi = false;
        public bool bpDovizGuncellendi = false;
        public bool bpDovizSatEkran = false;
        public bool bpOdemeEkran = false;
        public bool bpFaturaEkran = false;
        public bool bpEodemeler = false;
        public bool bpEgitimOde = false;
        public bool bpSinavOde = false;
        public string[] dovizBirimleri = { "Gram Altın", "Çeyrek Altın", "Yarım Altın", "Cumhuriyet Altını", "Dolar", "Euro" };
        public int[] guncelDovizler= { 0, 0, 0, 0, 0, 0 };
        private readonly Panel pnl = new Panel();
        public int para, guncelpara, dovizbirim, faturatutar;
        public double doviz, gunceldoviz, sdoviz;
        public string dovizCesidi;
        
            

        public int DovizBirim
        {
            get { return dovizbirim; }
        }
        public int [] gunceldovizler
        {
            get { return guncelDovizler; }
        }
        public string[] dovizbirimleri
        {
            get { return dovizBirimleri; }
        }

        public double DovizMiktar
        {
            get { return doviz; }
        }
        public double DovizSon
        {
            get { return doviz; }
        }
        public int Para
        {
            get { return para; }
            set
            {
                if (value >= 0)
                {
                    para = value;
                }
            }   
        }
        int bakiye()
        {
            int para;
            Random rand = new Random();
            para = rand.Next(0, 100000);
            return para;
        }
        string dovizMiktarı()
        {
            Random rand = new Random();
            doviz = dovizAyar();
            dovizbirim = rand.Next(dovizBirimleri.Length);
            string dovizSon = Convert.ToString(doviz) + " " + dovizBirimleri[dovizbirim];
            switch (dovizBirimleri[dovizbirim])
            {
                case "Gram Altın":
                    gunceldovizler[0] += Convert.ToInt32(doviz);
                    break;
                case "Çeyrek Altın":
                    gunceldovizler[1] += Convert.ToInt32(doviz);
                    break;
                case "Yarım Altın":
                    gunceldovizler[2] += Convert.ToInt32(doviz);
                    break;
                case "Cumhuriyet Altın":
                    gunceldovizler[3] += Convert.ToInt32(doviz);
                    break;
                case "Dolar":
                    gunceldovizler[4] += Convert.ToInt32(doviz);
                    break;
                case "Euro":
                    gunceldovizler[5] += Convert.ToInt32(doviz);
                    break;
            }
            return dovizSon;
        }
        int dovizAyar()
        {
            int doviz;
            Random rand = new Random();
            doviz = rand.Next(0, 100);
            return doviz;
        }
        void buttonsDefault()
        {
            button1.Text = "Bakiyeni Kontrol Et.";
            button2.Text = "Hesabından Para Çek";
            button3.Text = "Hesabına Para Yükle";
            button4.Text = "Döviz İşlemleri";
            button5.Text = "Ödeme İşlemleri";
            button6.Text = "İptal";
            button7.Text = "Para Yatır";
            button8.Text = "Fatura Kodunu Okutun ve Ödeyin";
            button9.Text = "Elektrik Ödemeleri";
            button11.Text = "İptal";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button1.BackColor = Color.LightCoral;
            button2.BackColor = Color.LightCoral;
            button3.BackColor = Color.LightCoral;
            button4.BackColor = Color.LightCoral;
            button5.BackColor = Color.LightCoral;
            button6.BackColor = Color.LightCoral;
            button7.BackColor = Color.LightCoral;
            button8.BackColor = Color.LightCoral;
            button9.BackColor = Color.LightCoral;
            button10.BackColor = Color.LightCoral;
            button11.BackColor = Color.LightCoral;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            button9.Cursor = Cursors.Hand;
            button10.Cursor = Cursors.Hand;
            button11.Cursor = Cursors.Hand;
            label1.Text = Convert.ToString(DateTime.Now);
         // BackColor = Color.DarkViolet;
            Color bcolor = Color.FromArgb(255, 130, 100);
            BackColor = bcolor;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Font = new Font("", 20, FontStyle.Regular);
            numericUpDown1.Increment = 100;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Visible = false;
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox1.Font = new Font("", 18, FontStyle.Regular);
            comboBox1.Visible = false;
            label4.Text = "Alış";
            label5.Text = "Satış";
            label6.Text = "Alış Fiyatı";
            label7.Text = "Satış Fiyatı";
            label4.Font = new Font("", 18, FontStyle.Bold);
            label5.Font = new Font("", 18, FontStyle.Bold);
            label6.Font = new Font("", 14, FontStyle.Bold);
            label7.Font = new Font("", 14, FontStyle.Bold);
            textBox2.Visible = false;
            textBox2.Enabled = false;
            textBox2.Font = new Font("", 18, FontStyle.Regular);
            label3.Text = Convert.ToString(guncelpara) + " TL";             // + Environment.NewLine + dovizCesidi;
            label8.Visible = false;
            label8.Font = new Font("", 18, FontStyle.Bold);
            label8.Text = "Lütfen Döviz Seçiniz";
            comboBox1.SelectedIndex = -1;
            MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
        void tbxVisib (int input)
        {
            if (input == 1)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
            if (input == 2)
            {
                textBox1.Visible = true;
            }
      
        }
        void nmcVisib(int input)
        {
            if (input== 1)
            {
                numericUpDown1.Visible = false;
            }
            if(input == 2)
            {
                numericUpDown1.Visible = true;
            }
        }
        void lblVisib(int input)
        {
            if (input == 1)
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            if (input == 2)
            {
                label2.Location = new Point(49, 158);
                label2.ForeColor = Color.Black;
                label2.Size = new Size(label2.PreferredWidth, label2.PreferredHeight);
                label2.Text = "Bakiyeniz";
                label2.Font = new Font("", 24, FontStyle.Regular);
                label2.Visible = true;
                label3.ForeColor = Color.Black;
                label3.Size = new Size(label2.PreferredWidth, label2.PreferredHeight);
                if (bpDovizAlındı)
                {
                    label3.Text = Convert.ToString(guncelpara) + " TL" +
                        Environment.NewLine + comboBox1.Text + gunceldoviz; 

                }
                label3.Font = new Font("", 24, FontStyle.Regular);
                label3.Visible = true;
            }

        }

        void pnlVisib(int input)
            {
                if (input == 1)
                {
                    pnl.Visible = false;
                }
                if (input == 2)
                {
                    pnl.Location = new Point(0, 100);  //39,100
                    pnl.Size = new Size(300, 267);    // 315, 267
                    this.Controls.Add(pnl);
                    pnl.BackColor = Color.DarkGray;
                    pnl.Visible = true;
                }
                
            }
            
        
        void Anamenu()
        {
            buttonsDefault();
            pnlVisib(1);
            lblVisib(1);
            nmcVisib(1);
            tbxVisib(1);
            button11.Visible = true;
            bpParaCekme = false;
            bpBakiyeSorgulama = false;
            bpAnamenu = true;
            bpDoviz = false;
            bpOdemeEkran = false;
            bpFaturaEkran = false;
            bpEodemeler = false;
            bpDovizAlEkran = false;
            bpEgitimOde = false;
            bpDovizSatEkran = false;
            bpSinavOde = false;
            bpParaYatırma = false;
            bpSonIslem = false;
            bpDovizBakiyesi = false;
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            label8.Visible = false;
            bpDovizGuncellendi = false;
            numericUpDown1.Value = 0;
            label1.Visible = true;
        }

        void bakiyeSorgulama()
        {
            bpBakiyeSorgulama = true;
            bpParaCekme = false;
            button6.Visible = true;
            button11.Visible = false;
            GenelEkran();
            pnlVisib(2);
            lblVisib(2);
            bpAnamenu = false;
            button7.Visible = true;
            button7.Text = "Döviz Bakiyesi";
        }
        void DovizBakiyesi()
        {
            button7.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            button11.Visible = false;
            pnlVisib(1);
            lblVisib(1);
            comboBox1.Visible = true;
            comboBox1.Items.Add("Gram Altın");
            comboBox1.Items.Add("Çeyrek Altın");
            comboBox1.Items.Add("Yarım Altın");
            comboBox1.Items.Add("Cumhuriyet Altını");
            comboBox1.Items.Add("Dolar");
            comboBox1.Items.Add("Euro");
            bpDovizBakiyesi = true;
            label8.Visible = true;

        }
        void ParaCekme()
        {
            button7.Visible = false;
            button3.Visible = true;
            button3.Text = "Para Çek";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            button11.Visible = false;
            button6.Text = "Ana Menü";
            nmcVisib(2);
            pnlVisib(1);
            lblVisib(1);
            tbxVisib(1);
            bpParaCekme = true;
            bpBakiyeSorgulama = false;
            bpAnamenu = false;
            bpParaYatırma = false;
            numericUpDown1.Maximum = Para;
        }


        void ParaYatırma()
        {
            button3.Visible = false;
            button7.Visible = true;
            button7.Text = "Para Yatır";
            button3.Text = "Para Yatır";
            button4.Visible = false;
            button5.Visible = false;
            button6.Text = "Ana Menü";
            button6.Visible = true;
            button11.Visible = false;
            nmcVisib(2);
            pnlVisib(1);
            lblVisib(1);
            tbxVisib(1);
            bpBakiyeSorgulama = false;
            bpAnamenu = false;
            bpParaCekme = false;
            bpParaYatırma = true;
            numericUpDown1.Maximum = 100000;
        }

        void SonIslem(int input)
        {
            bpSonIslem = true;
            tbxVisib(2);
            nmcVisib(1);
            button3.Visible = false;
            bpAnamenu = false;
            button7.Visible = false;
            button8.Visible = false;
            button6.Visible = true;
            button11.Visible = false;

            if (input == 1)
            {
                Para -= Convert.ToInt32(numericUpDown1.Value);
                if (Para <= 0)
                    guncelpara = 0;

                if (Para != 0)
                {
                    guncelpara = Para;
                }
            }
            if (input == 2)
            {
                guncelpara = Para + Convert.ToInt32(numericUpDown1.Value);
            }
            if (input == 3)
            {
                double dovizpara = sdoviz * Convert.ToDouble(numericUpDown1.Value);
                double k = Para - dovizpara;
                textBox2.Visible = true;
                if (k <= 0)
                {
                    guncelpara = 0;
                }
                if (k != 0)
                {
                    guncelpara = Convert.ToInt32(k);
                }
                
                switch (comboBox1.Text)
                {
                    case "Gram Altın":
                        gunceldovizler[0] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[0];
                        break;
                    case "Çeyrek Altın":
                        gunceldovizler[1] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[1];
                        break;
                    case "Yarım Altın":
                        gunceldovizler[2] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[2];
                        break;
                    case "Cumhuriyet Altın":
                        gunceldovizler[3] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[3];
                        break;
                    case "Dolar":
                        gunceldovizler[4] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[4];
                        break;
                    case "Euro":
                        gunceldovizler[5] += Convert.ToInt32(numericUpDown1.Value);
                        textBox2.Text = comboBox1.Text + " " + gunceldovizler[5];
                        break;
                }
            }
            if (input == 4)
            {
                double dovizpara = sdoviz * Convert.ToDouble(numericUpDown1.Value);
                double k = Para + dovizpara;
                textBox2.Visible = true;
                if (k <= 0)
                {
                    guncelpara = 0;
                }
                if (k != 0)
                {
                    guncelpara = Convert.ToInt32(k);
                }

                switch (comboBox1.Text)
                {
                    case "Gram Altın":
                        if (gunceldovizler[0] == 0)
                        {
                            MessageBox.Show("Elinizde Hiç Gram Altın Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Gram Altın Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[0] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[0];
                        }
                        break;
                    case "Çeyrek Altın":
                        if (gunceldovizler[1] == 0)
                        {
                            MessageBox.Show("Elinizde Hiç Çeyrek Altın Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Çeyrek Altın Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[1] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[1];
                        }
                        break;
                    case "Yarım Altın":
                        if (gunceldovizler[2] == 0)
                        {
                            MessageBox.Show("Elinizde Hiç Yarım Altın Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Yarım Altın Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[2] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[2];
                        }
                        break;
                    case "Cumhuriyet Altın":
                        if (gunceldovizler[3] == 0)
                        {
                            MessageBox.Show("Elinizde Hiç Cumhuriyet Altını Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Cumhuriyet Altın Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[3] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[3];
                        }
                        break;
                    case "Dolar":
                        if (gunceldovizler[4] == 0)
                        {
                            MessageBox.Show("Elinizde Hiç Dolar Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Dolar Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[4] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[4];
                        }
                        break;
                    case "Euro":
                        if (gunceldovizler[5] == 0)
                        {
                            MessageBox.Show ("Elinizde Hiç Euro Bulunmamaktadır.");
                            textBox1.Text = "Elinizde Hiç Euro Bulunmamaktadır.";
                            textBox2.Text = "İyi Günler Dileriz";
                        }
                        else
                        {
                            gunceldovizler[5] -= Convert.ToInt32(numericUpDown1.Value);
                            textBox2.Text = comboBox1.Text + " " + gunceldovizler[5];
                        }
                        break;
                }
            }
            if(input == 5)
            {
                if (guncelpara <= 0)
                {
                    MessageBox.Show("Yetersiz Bakiye.");
                    Anamenu();
                }
                else
                {
                    Para -= faturatutar;
                    if (Para <= 0)
                        guncelpara = 0;

                    if (Para != 0)
                    {
                        guncelpara = Para;
                    }
                    MessageBox.Show(Convert.ToString(faturatutar) + " TL ödenmiştir.");
                }
            }
            if(input == 6)
            {
                button1.Visible = false;
                button9.Visible = false;
                button2.Visible = false;
                if (guncelpara <= 0)
                {
                    MessageBox.Show("Yetersiz Bakiye.");
                    Anamenu();
                }
                else
                {
                    Para -= 30;
                    if (Para <= 0)
                        guncelpara = 0;

                    if (Para != 0)
                    {
                        guncelpara = Para;
                    }
                    if (bpEgitimOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Lise Kaydınız Yapılmıştır.");
                    }

                    if (bpSinavOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Liseye Giriş Sınavı Kaydınız Yapılmıştır.");
                    }
                }
            }
            if(input == 7)
            {
                
                button1.Visible = false;
                button9.Visible = false;
                button2.Visible = false;
                if (guncelpara <= 0)
                {
                    MessageBox.Show("Yetersiz Bakiye.");
                    Anamenu();
                }
                else
                {
                    Para -= 60;
                    if (Para <= 0)
                        guncelpara = 0;

                    if (Para != 0)
                    {
                        guncelpara = Para;
                    }
                    if (bpEgitimOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Lise Kaydınız Yapılmıştır.");
                    }

                    if (bpSinavOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Liseye Giriş Sınavı Kaydınız Yapılmıştır.");
                    }
                }
            }
            if (input == 8)
            {
               
                button1.Visible = false;
                button9.Visible = false;
                button2.Visible = false;
                if (guncelpara <= 0)
                {
                    MessageBox.Show("Yetersiz Bakiye.");
                    Anamenu();
                }
                else
                {
                    Para -= 90;
                    if (Para <= 0)
                        guncelpara = 0;

                    if (Para != 0)
                    {
                        guncelpara = Para;
                    }
                    if (bpEgitimOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Lise Kaydınız Yapılmıştır.");
                    }

                    if (bpSinavOde)
                    {
                        MessageBox.Show("30 TL ödenmiştir. Liseye Giriş Sınavı Kaydınız Yapılmıştır.");
                    }
                }
            }
            ParaGuncelle();
            textBox1.Text = "Kalan Bakiyeniz: " + guncelpara;
        }
        
        void Doviz()
        {
            GenelEkran();
            comboBox1.Visible = true;
            button4.Text = "Döviz Sat";
            button5.Text = "Döviz Al";
            button6.Text = "Anamenü";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            bpParaYatırma = false;
            bpDoviz = true;
            button7.Visible = true;
            button6.Visible = true;
            button11.Visible = false;
            button7.Text = "Alış Satış Güncelle";
            comboBox1.Items.Add("Gram Altın");
            comboBox1.Items.Add("Çeyrek Altın");
            comboBox1.Items.Add("Yarım Altın");
            comboBox1.Items.Add("Cumhuriyet Altını");
            comboBox1.Items.Add("Dolar");
            comboBox1.Items.Add("Euro");
            bpAnamenu = false;
        }
        void DovizGuncelle()
        {
            switch (comboBox1.Text)
            {
                case "Gram Altın":
                    sdoviz = 420;
                    label6.Text = "412";
                    label7.Text = "420";
                    break;
                case "Çeyrek Altın":
                    sdoviz = 661;
                    label6.Text = "647";
                    label7.Text = "661";
                    break;
                case "Yarım Altın":
                    sdoviz = 1323;
                    label6.Text = "1290";
                    label7.Text = "1323";
                    break;
                case "Cumhuriyet Altını":
                    sdoviz = 2679;
                    label6.Text = "2638";
                    label7.Text = "2679";
                    break;

                case "Dolar":
                    sdoviz = 7.3;
                    label6.Text = "7";
                    label7.Text = "7,3";
                    break;
                case "Euro":
                    sdoviz = 8.4;
                    label6.Text = "8,4";
                    label7.Text = "8,8";
                    break;
            }
        }
        void DovizAlEkran(int input)
        {
            numericUpDown1.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            comboBox1.Visible = false; 
            button6.Text = "Anamenü";
            button6.Visible = true;
            button11.Visible = false;
            bpAnamenu = false;
            bpDoviz = false;
            if (input == 1)
            {
                button7.Text = "Döviz Al";
                bpDovizAlEkran = true;
                switch (comboBox1.Text)
                {
                    case "Gram Altın":
                        numericUpDown1.Maximum = para / 420;
                        break;
                    case "Çeyrek Altın":
                        numericUpDown1.Maximum = para / 661;
                        break;
                    case "Yarım Altın":
                        numericUpDown1.Maximum = para / 1323;
                        break;
                    case "Cumhuriyet Altını":
                        numericUpDown1.Maximum = para / 2679;
                        break;

                    case "Dolar":
                        numericUpDown1.Maximum = Convert.ToDecimal(para / 7.3);
                        break;
                    case "Euro":
                        numericUpDown1.Maximum = Convert.ToDecimal(para / 8.8);
                        break;
                }
            }
            if (input == 2)
            {
                button7.Text = "Döviz Sat";
                bpDovizSatEkran = true;
                switch (comboBox1.Text)
                {
                    case "Gram Altın":
                        numericUpDown1.Maximum = gunceldovizler[0];
                        break;
                    case "Çeyrek Altın":
                        numericUpDown1.Maximum = gunceldovizler[1];
                        break;
                    case "Yarım Altın":
                        numericUpDown1.Maximum = gunceldovizler[2];
                        break;
                    case "Cumhuriyet Altını":
                        numericUpDown1.Maximum = gunceldovizler[3];
                        break;

                    case "Dolar":
                        numericUpDown1.Maximum = gunceldovizler[4];
                        break;
                    case "Euro":
                        numericUpDown1.Maximum = gunceldovizler[5];
                        break;
                }
            }



        }
        void DovizAlSon(int input)
        {
            if(input == 1)
            SonIslem(3);
            if (input == 2)
                SonIslem(4);
        }
        void OdemeEkran()
        {
            GenelEkran();
            bpOdemeEkran =true;
            bpEodemeler = false;
            button6.Visible = true;
            button11.Visible = false;
            bpAnamenu = false;
            button1.Visible = true;
            button9.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
            label1.Visible = false;
            button1.Text = "Fatura Ödemeleri";
            button4.Text = "Eğitim Ödemeleri";

        }
        void FaturaEkran(int input)
        {
            bpOdemeEkran = false;
            if (input == 1)
            {
                bpFaturaEkran = true;
                button1.Visible = false;
                button9.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button6.Visible = true;
                button11.Visible = false;
                button9.Text = "Elektrik Ödemeleri";
                button2.Text = "Su Ödemeleri";
                button4.Text = "Telefon Ödemeleri";
                button3.Text = "Doğalgaz Ödemeleri";
            }
            if(input == 2)
            {
                bpEodemeler = true;
                button6.Visible = true;
                button11.Visible = false;
                button4.Visible = false;
                button9.Visible = true;
                button10.Visible = true;
                button9.Text = "Kayıt Ödemeleri";
                button10.Text = "Sınav Ödemeleri";
            }
        }
        void FaturaOdeme()
        {
            GenelEkran();
            button10.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button8.Visible = true;
        }

        void EgitimOdeme()
        {
            bpEgitimOde = true;
            button6.Visible = true;
            button11.Visible = false;
            button9.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button10.Visible = false;
            button1.Text = "Lise Kaydı (30 TL)";
            button2.Text = "Üniversite Kaydı(60 TL)";
            button3.Text = "Yüksek Lisans Kaydı (90 TL)";
        }

        void SinavOdeme()
        {
            bpSinavOde = true;
            button6.Visible = true;
            button11.Visible = false;
            button9.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button10.Visible = false;
            button1.Text = "Liseye Giriş Sınav Ücreti (30 TL)";
            button2.Text = "Üniversite Giriş Sınav Ücreti (60 TL)";
            button3.Text = "Yüksek Lisansa Giriş Sınav Ücreti (90 TL)";
        }

        void GenelEkran()
        {
            button1.Visible = false;
            button9.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Text = "Para Çekme";
            button5.Text = "Para Yatırma";
            button6.Text = "Ana Menü";
            label1.Visible = false;
        }

        public Form2()
        {
            InitializeComponent();
            para = bakiye();
            dovizCesidi = dovizMiktarı();
            guncelpara = para;
            buttonsDefault();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackgroundImage = Properties.Resources.Slider_CL01_Background;
            FormClosing += Form2_Closing;    
        }
        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        void ParaGuncelle()
        {
                if (guncelpara != 0)
                {
                    Para = guncelpara;
                }     
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bpAnamenu)
            {
                bakiyeSorgulama();
            }
            if (bpOdemeEkran)
            {
                FaturaEkran(1);
            }
            if (bpEodemeler)
            {
                SonIslem(6);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bpAnamenu)
            {
                GenelEkran();
                ParaCekme();
            }
            if (bpFaturaEkran)
            {
                FaturaOdeme();
            }
            if (bpEodemeler)
            {
                SonIslem(7);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bpAnamenu)
            {
                GenelEkran();
                ParaYatırma();
                button3.Visible = true;
                numericUpDown1.Visible = true;
            }
       
            if (bpParaCekme)
            {
                SonIslem(1);
            }
            if (bpDoviz)
            {
                DovizAlEkran(1);
            }
            if (bpFaturaEkran)
            {
                FaturaOdeme();
            }
            if (bpEodemeler)
            {
                SonIslem(8);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bpBakiyeSorgulama)
            {
                ParaCekme();
            }
            if(bpAnamenu)
            {
                Doviz();
            }
            if (bpDoviz & comboBox1.SelectedIndex !=-1)
            {
                if (bpDovizGuncellendi)
                {
                    if (comboBox1.Text == dovizBirimleri[0] || comboBox1.Text == dovizBirimleri[1] || comboBox1.Text == dovizBirimleri[2] || comboBox1.Text == dovizBirimleri[3] || comboBox1.Text == dovizBirimleri[4] || comboBox1.Text == dovizBirimleri[5])
                    {
                        DovizAlEkran(2);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Döviz Seçiniz.");
                    }
                }
                else if(bpDovizGuncellendi == false)
                    MessageBox.Show("Lütfen Döviz Fiyatlarını Güncelleyiniz.");

            }
            if (bpFaturaEkran)
            {
                FaturaOdeme();
            }
            if (bpOdemeEkran)
            {
                FaturaEkran(2);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bpFaturaEkran)
            {
                FaturaOdeme();
            }
            if (bpEodemeler)
            {
                EgitimOdeme();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bpEodemeler)
            {
                SinavOdeme();
            
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            faturatutar = random.Next(20, 250);
            SonIslem(5);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bpDovizGuncellendi = false;
            if (bpDovizBakiyesi)
            {
                label8.Visible = true;
                if (gunceldovizler.Length == 0)
                    label8.Text = "Lütfen Döviz Seçiniz";
                else if (gunceldovizler.Length > 0)
                {
                    switch (comboBox1.Text)
                    {
                        case "Gram Altın":
                            label8.Text = Convert.ToString(gunceldovizler[0]);
                            break;
                        case "Çeyrek Altın":
                            label8.Text = Convert.ToString(gunceldovizler[1]);
                            break;
                        case "Yarım Altın":
                            label8.Text = Convert.ToString(gunceldovizler[2]);
                            break;
                        case "Cumhuriyet Altın":
                            label8.Text = Convert.ToString(gunceldovizler[3]);
                            break;
                        case "Dolar":
                            label8.Text = Convert.ToString(gunceldovizler[4]);
                            break;
                        case "Euro":
                            label8.Text = Convert.ToString(gunceldovizler[5]);
                            break;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bpBakiyeSorgulama)
            {
                ParaYatırma();
            }
            if(bpDoviz)
            {
                if (bpDovizGuncellendi)
                {
                    if (comboBox1.Text == dovizBirimleri[0] || comboBox1.Text == dovizBirimleri[1] || comboBox1.Text == dovizBirimleri[2] || comboBox1.Text == dovizBirimleri[3] || comboBox1.Text == dovizBirimleri[4] || comboBox1.Text == dovizBirimleri[5])
                    {
                        DovizAlEkran(1);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Döviz Seçiniz.");
                    }
                }
                else if (bpDovizGuncellendi == false)
                    MessageBox.Show("Lütfen Döviz Fiyatlarını Güncelleyiniz.");

            }
            if (bpAnamenu)
            {
                OdemeEkran();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bpParaYatırma)
            {
                SonIslem(2);
            }
            if(bpDoviz)
            {
                DovizGuncelle();
                bpDovizGuncellendi = true;
            }
            if (bpDovizAlEkran)
            {
                DovizAlSon(1);
            }
            if (bpDovizSatEkran)
            {
                DovizAlSon(2);
            }
            if (bpBakiyeSorgulama)
            {
                DovizBakiyesi();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bpEgitimOde || bpFaturaEkran || bpOdemeEkran || bpDovizAlEkran || bpDovizSatEkran || bpBakiyeSorgulama || bpParaCekme ||bpParaYatırma || bpDoviz || bpSinavOde)
            {
                Anamenu();
            }
            if(bpDovizAlEkran)
            {
                bpDovizAlındı = true;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (bpAnamenu)
            {
                Application.Exit();
            }
        }
    }

}
