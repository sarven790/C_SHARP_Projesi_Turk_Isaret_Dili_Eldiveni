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
    public partial class g_baba : Form
    {
        public g_baba()
        {
            InitializeComponent();
        }

        private void btn_baba_Click(object sender, EventArgs e)
        {
            SoundPlayer baba = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Baba.wav";
            baba.SoundLocation = dizin;
            baba.Play();
        }

        private void g_baba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
