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
    public partial class g_kola : Form
    {
        public g_kola()
        {
            InitializeComponent();
        }

        private void btn_kola_Click(object sender, EventArgs e)
        {
            SoundPlayer kola = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Kola.wav";
            kola.SoundLocation = dizin;
            kola.Play();
        }

        private void g_kola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
