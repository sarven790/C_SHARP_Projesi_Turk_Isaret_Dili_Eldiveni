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
    public partial class g_benim : Form
    {
        public g_benim()
        {
            InitializeComponent();
        }

        private void btn_benim_Click(object sender, EventArgs e)
        {
            SoundPlayer benim = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Benim.wav";
            benim.SoundLocation = dizin;
            benim.Play();
        }

        private void g_benim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
