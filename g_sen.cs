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
    public partial class g_sen : Form
    {
        public g_sen()
        {
            InitializeComponent();
        }

        private void btn_sen_Click(object sender, EventArgs e)
        {
            SoundPlayer sen = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Sen.wav";
            sen.SoundLocation = dizin;
            sen.Play();
        }

        private void g_sen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
