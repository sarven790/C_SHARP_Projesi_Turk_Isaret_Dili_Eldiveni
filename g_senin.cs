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
    public partial class g_senin : Form
    {
        public g_senin()
        {
            InitializeComponent();
        }

        private void btn_senin_Click(object sender, EventArgs e)
        {
            SoundPlayer senin = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Senin.wav";
            senin.SoundLocation = dizin;
            senin.Play();
        }

        private void g_senin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
