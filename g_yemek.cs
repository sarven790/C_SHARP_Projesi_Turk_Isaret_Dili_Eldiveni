using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp6
{
    public partial class g_yemek : Form
    {
        public g_yemek()
        {
            InitializeComponent();
        }

        private void btn_yemek_Click(object sender, EventArgs e)
        {
            SoundPlayer yemek = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Yemek.wav";
            yemek.SoundLocation = dizin;
            yemek.Play();
        }

        private void g_yemek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
