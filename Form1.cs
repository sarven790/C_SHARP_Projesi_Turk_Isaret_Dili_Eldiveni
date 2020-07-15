using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Media;
//using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private string veri;
        private string[] pots;
        int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            try
            {

                veri = serialPort1.ReadLine();
                pots = veri.Split('_');

                this.Invoke(new EventHandler(DisplayText));
            }
            catch { }

        }
        private void DisplayText(object sender, EventArgs e)
        {

            try
            {

                label1.Text = veri.ToString();

              

                if(( (Convert.ToInt16(pots[1])>140 && Convert.ToInt16(pots[1])<150) || (Convert.ToInt16(pots[2]) > 140 && Convert.ToInt16(pots[2]) < 155) ) && ( (Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100 ) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39)  && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Benim";

                }
                else if (((Convert.ToInt16(pots[1]) > -15 && Convert.ToInt16(pots[1]) <-5) || (Convert.ToInt16(pots[2]) > -10 && Convert.ToInt16(pots[2]) < -3)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7])< 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Sen";

                }
                else if (((Convert.ToInt16(pots[1]) > 0 && Convert.ToInt16(pots[1]) < 15) || (Convert.ToInt16(pots[2]) > 10 && Convert.ToInt16(pots[2]) < 20)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Bu";


                }
                else if (((Convert.ToInt16(pots[1]) > 140 && Convert.ToInt16(pots[1]) < 150) || (Convert.ToInt16(pots[2]) > -180 && Convert.ToInt16(pots[2]) < -170)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 100)) && (Convert.ToInt16(pots[9]) > 100))
                {

                    textBox1.Text = "Acıkmak";

                }
                else if (((Convert.ToInt16(pots[1]) > 55 && Convert.ToInt16(pots[1]) < 70) || (Convert.ToInt16(pots[2]) > -60 && Convert.ToInt16(pots[2]) < -50)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 40 && Convert.ToInt16(pots[7]) < 99) && (Convert.ToInt16(pots[8]) > 100) && (Convert.ToInt16(pots[9]) > 100)))
                {

                    textBox1.Text = "Acımak";

                }         
                else if (((Convert.ToInt16(pots[1]) > 55 && Convert.ToInt16(pots[1]) < 65) || (Convert.ToInt16(pots[2]) > -80 && Convert.ToInt16(pots[2]) < -65)) && ((Convert.ToInt16(pots[6]) > 40 && Convert.ToInt16(pots[6]) < 99) && (Convert.ToInt16(pots[7]) > 40 && Convert.ToInt16(pots[7]) < 99) && (Convert.ToInt16(pots[8]) > 40 && Convert.ToInt16(pots[8]) < 99) && (Convert.ToInt16(pots[9]) > 40 && Convert.ToInt16(pots[9]) < 99)))
                {

                    textBox1.Text = "Ben";

                }
                else if (((Convert.ToInt16(pots[1]) > 60 && Convert.ToInt16(pots[1]) < 70) || (Convert.ToInt16(pots[2]) > -70 && Convert.ToInt16(pots[2]) < -50)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 100) && (Convert.ToInt16(pots[9]) > 100)))
                {

                    textBox1.Text = "Bilmek";

                }
                else if (((Convert.ToInt16(pots[1]) > 170 && Convert.ToInt16(pots[1]) < 180) || (Convert.ToInt16(pots[2]) > -115 && Convert.ToInt16(pots[2]) < -105)) && ((Convert.ToInt16(pots[6]) > 40 && Convert.ToInt16(pots[6]) < 99) && (Convert.ToInt16(pots[7]) > 40 && Convert.ToInt16(pots[7]) < 99) && (Convert.ToInt16(pots[8]) > 40 && Convert.ToInt16(pots[8]) < 99) && (Convert.ToInt16(pots[9]) > 40 && Convert.ToInt16(pots[9]) < 99)))
                {

                    textBox1.Text = "Yemek";

                }             
                else if (((Convert.ToInt16(pots[4]) > -20 && Convert.ToInt16(pots[4]) < -10) || (Convert.ToInt16(pots[5]) > -70 && Convert.ToInt16(pots[5]) < -55)) && ((Convert.ToInt16(pots[6]) > 40 && Convert.ToInt16(pots[6]) < 99) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Kola";

                }
                if (((Convert.ToInt16(pots[1]) > 50 && Convert.ToInt16(pots[1]) < 65) || (Convert.ToInt16(pots[2]) > -80 && Convert.ToInt16(pots[2]) < -70)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 40 && Convert.ToInt16(pots[7]) < 100) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Senin";

                }
                else if (((Convert.ToInt16(pots[3]) > -175 && Convert.ToInt16(pots[3]) < -160) && (Convert.ToInt16(pots[4]) > -10 && Convert.ToInt16(pots[4]) < 0) || (Convert.ToInt16(pots[5]) > -60 && Convert.ToInt16(pots[5]) < -40)) && ((Convert.ToInt16(pots[6]) > 40 && Convert.ToInt16(pots[6]) < 99) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Baba";

                }
                else if (((Convert.ToInt16(pots[4]) > 0 && Convert.ToInt16(pots[4]) < 15) || (Convert.ToInt16(pots[5]) > -65 && Convert.ToInt16(pots[5]) < -50)) && ((Convert.ToInt16(pots[6]) > 100 ) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    textBox1.Text = "Göz";

                }
                else if (((Convert.ToInt16(pots[4]) > 10 && Convert.ToInt16(pots[4]) < 20) || (Convert.ToInt16(pots[5]) > -90 && Convert.ToInt16(pots[5]) < -80)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                  if (((Convert.ToInt16(pots[4]) > -5 && Convert.ToInt16(pots[4]) < 5) || (Convert.ToInt16(pots[5]) > -75 && Convert.ToInt16(pots[5]) < -60)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                    {
                        textBox1.Text = "Abla";
                    }


                }
                else if (((Convert.ToInt16(pots[4]) > -40 && Convert.ToInt16(pots[4]) < -25) || (Convert.ToInt16(pots[5]) > -80 && Convert.ToInt16(pots[5]) < -70)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                {

                    if (((Convert.ToInt16(pots[4]) > -25 && Convert.ToInt16(pots[4]) < -15) || (Convert.ToInt16(pots[5]) > -55 && Convert.ToInt16(pots[5]) < -45)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39)))
                    {
                        textBox1.Text = "Görmek";
                    }


                }               
                else if (((Convert.ToInt16(pots[1]) > 50 && Convert.ToInt16(pots[1]) < 60) || (Convert.ToInt16(pots[2]) > -80 && Convert.ToInt16(pots[2]) < -60)) && ((Convert.ToInt16(pots[6]) > 0 && Convert.ToInt16(pots[6]) < 39) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39)) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39))
                {

                    if (((Convert.ToInt16(pots[1]) > 30 && Convert.ToInt16(pots[1]) < 50) || (Convert.ToInt16(pots[2]) > -70 && Convert.ToInt16(pots[2]) < -50)) && ((Convert.ToInt16(pots[6]) > 0 && Convert.ToInt16(pots[6]) < 39) && (Convert.ToInt16(pots[7]) > 0 && Convert.ToInt16(pots[7]) < 39) && (Convert.ToInt16(pots[8]) > 0 && Convert.ToInt16(pots[8]) < 39)) && (Convert.ToInt16(pots[9]) > 0 && Convert.ToInt16(pots[9]) < 39))
                    {

                        textBox1.Text = "Ağabey";

                    }


                }
                else if (((Convert.ToInt16(pots[1]) > 5 && Convert.ToInt16(pots[1]) < 15) || (Convert.ToInt16(pots[2]) > -70 && Convert.ToInt16(pots[2]) < -60)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 100) && (Convert.ToInt16(pots[9]) > 100)))
                {

                    if (((Convert.ToInt16(pots[1]) > -5 && Convert.ToInt16(pots[1]) < 5) || (Convert.ToInt16(pots[2]) > -80 && Convert.ToInt16(pots[2]) < -70)) && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 100) && (Convert.ToInt16(pots[9]) > 100)))
                    {
                        textBox1.Text = "Et";
                    }

                }
                else if (((Convert.ToInt16(pots[1]) > 135 && Convert.ToInt16(pots[1]) < 145) || (Convert.ToInt16(pots[2]) > -125 && Convert.ToInt16(pots[2]) < -110))/* && ((Convert.ToInt16(pots[6]) > 100) && (Convert.ToInt16(pots[7]) > 100) && (Convert.ToInt16(pots[8]) > 100) && (Convert.ToInt16(pots[9]) > 100))*/)
                {

                    if (((Convert.ToInt16(pots[1]) > 135 && Convert.ToInt16(pots[1]) < 145) || (Convert.ToInt16(pots[2]) > -125 && Convert.ToInt16(pots[2]) < -110)) && ((Convert.ToInt16(pots[6]) > 40 && Convert.ToInt16(pots[6]) < 99) && (Convert.ToInt16(pots[7]) > 40 && Convert.ToInt16(pots[7]) < 99) && (Convert.ToInt16(pots[8]) > 40 && Convert.ToInt16(pots[8]) < 99) && (Convert.ToInt16(pots[9]) > 40 && Convert.ToInt16(pots[9]) < 99)))
                    {
                        textBox1.Text = "Süt";
                    }

                }

                // textBox1.AppendText(pots[4]+" "+pots[6]);

                timer1.Start();
            }
            catch
            {


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {

                serialPort1.PortName = "COM5";
                serialPort1.BaudRate = 115200;
                serialPort1.DataBits = 8;
                serialPort1.Handshake = Handshake.None;

                serialPort1.Open();
                serialPort1.ReadTimeout = 500;

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter = counter + 1;

            if (counter == 20)
            {

                counter = 0;
                label1.Text = "";
                veri = null;
                //serialPort1.Close();
                timer1.Stop();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newPage = new Form2();       
            newPage.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SoundPlayer baba = new SoundPlayer();
            string dizin1 = Application.StartupPath + "\\Baba.wav";
            baba.SoundLocation = dizin1;

            SoundPlayer benim = new SoundPlayer();
            string dizin2 = Application.StartupPath + "\\Benim.wav";
            benim.SoundLocation = dizin2;

            SoundPlayer sen = new SoundPlayer();
            string dizin3 = Application.StartupPath + "\\Sen.wav";
            sen.SoundLocation = dizin3;

            SoundPlayer bu = new SoundPlayer();
            string dizin4 = Application.StartupPath + "\\Bu.wav";
            bu.SoundLocation = dizin4;

            SoundPlayer acikmak = new SoundPlayer();
            string dizin5 = Application.StartupPath + "\\Acıkmak.wav";
            acikmak.SoundLocation = dizin5;

            SoundPlayer acimak = new SoundPlayer();
            string dizin6 = Application.StartupPath + "\\Acımak.wav";
            acimak.SoundLocation = dizin6;

            SoundPlayer ben = new SoundPlayer();
            string dizin7 = Application.StartupPath + "\\Ben.wav";
            ben.SoundLocation = dizin7;

            SoundPlayer bilmek = new SoundPlayer();
            string dizin8 = Application.StartupPath + "\\Bilmek.wav";
            bilmek.SoundLocation = dizin8;

            SoundPlayer yemek = new SoundPlayer();
            string dizin9 = Application.StartupPath + "\\Yemek.wav";
            yemek.SoundLocation = dizin9;

            SoundPlayer kola = new SoundPlayer();
            string dizin10 = Application.StartupPath + "\\Kola.wav";
            kola.SoundLocation = dizin10;

            SoundPlayer senin = new SoundPlayer();
            string dizin11 = Application.StartupPath + "\\Senin.wav";
            senin.SoundLocation = dizin11;

            SoundPlayer goz = new SoundPlayer();
            string dizin12 = Application.StartupPath + "\\Göz.wav";
            goz.SoundLocation = dizin12;

            SoundPlayer abla = new SoundPlayer();
            string dizin13 = Application.StartupPath + "\\Abla.wav";
            abla.SoundLocation = dizin13;

            SoundPlayer gormek = new SoundPlayer();
            string dizin14 = Application.StartupPath + "\\Görmek.wav";
            gormek.SoundLocation = dizin14;

            SoundPlayer agabey = new SoundPlayer();
            string dizin15 = Application.StartupPath + "\\Ağabey.wav";
            agabey.SoundLocation = dizin15;

            SoundPlayer et = new SoundPlayer();
            string dizin16 = Application.StartupPath + "\\Et.wav";
            et.SoundLocation = dizin16;

            SoundPlayer sut = new SoundPlayer();
            string dizin17 = Application.StartupPath + "\\Süt.wav";
            sut.SoundLocation = dizin17;


            if (textBox1.Text == "Baba")
            {
                baba.Play();
            }
            else if (textBox1.Text == "Benim")
            {
                benim.Play();
            }

            else if (textBox1.Text == "Sen")
            {
                sen.Play();
            }
            else if (textBox1.Text == "Bu")
            {
                bu.Play();
            }
            else if (textBox1.Text == "Acıkmak")
            {
                acikmak.Play();
            }
            else if (textBox1.Text == "Acimak")
            {
                acimak.Play();
            }
            else if (textBox1.Text == "Ben")
            {
                ben.Play();
            }
            else if (textBox1.Text == "Bilmek")
            {
                bilmek.Play();
            }
            else if (textBox1.Text == "Yemek")
            {
                yemek.Play();
            }
            else if (textBox1.Text == "Kola")
            {
                kola.Play();
            }
            else if (textBox1.Text == "Senin")
            {
                senin.Play();
            }
            else if (textBox1.Text == "Göz")
            {
                goz.Play();
            }
            else if (textBox1.Text == "Abla")
            {
                abla.Play();
            }
            else if (textBox1.Text == "Görmek")
            {
                gormek.Play();
            }
            else if (textBox1.Text == "Ağabey")
            {
                agabey.Play();
            }
            else if (textBox1.Text == "Et")
            {
                et.Play();
            }
            else if (textBox1.Text == "Süt")
            {
                sut.Play();
            }

        }
    }
}

