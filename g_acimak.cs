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
    public partial class g_acimak : Form
    {
        public g_acimak()
        {
            InitializeComponent();
        }

        private void btn_acimak_Click(object sender, EventArgs e)
        {
            SoundPlayer acimak = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Acımak.wav";
            acimak.SoundLocation = dizin;
            acimak.Play();
        }

        private void g_acimak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
