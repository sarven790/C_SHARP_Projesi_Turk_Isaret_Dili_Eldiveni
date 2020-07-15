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
    public partial class g_goz : Form
    {
        public g_goz()
        {
            InitializeComponent();
        }

        private void btn_goz_Click(object sender, EventArgs e)
        {
            SoundPlayer goz = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Göz.wav";
            goz.SoundLocation = dizin;
            goz.Play();
        }

        private void g_goz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
