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
    public partial class g_bilmek : Form
    {
        public g_bilmek()
        {
            InitializeComponent();
        }

        private void btn_bilmek_Click(object sender, EventArgs e)
        {
            SoundPlayer bilmek = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Bilmek.wav";
            bilmek.SoundLocation = dizin;
            bilmek.Play();
        }

        private void g_bilmek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
