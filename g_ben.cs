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
    public partial class g_ben : Form
    {
        public g_ben()
        {
            InitializeComponent();
        }

        private void btn_ben_Click(object sender, EventArgs e)
        {
            SoundPlayer ben = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Ben.wav";
            ben.SoundLocation = dizin;
            ben.Play();
        }

        private void g_ben_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
