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
    public partial class g_acikmak : Form
    {
        public g_acikmak()
        {
            InitializeComponent();
        }

        private void btn_acikmak_Click(object sender, EventArgs e)
        {
            SoundPlayer acikmak = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Acıkmak.wav";
            acikmak.SoundLocation = dizin;
            acikmak.Play();
        }

        private void g_acikmak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
