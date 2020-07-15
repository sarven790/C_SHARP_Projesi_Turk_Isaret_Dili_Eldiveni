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
    public partial class g_et : Form
    {
        public g_et()
        {
            InitializeComponent();
        }

        private void btn_et_Click(object sender, EventArgs e)
        {
            SoundPlayer et = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Et.wav";
            et.SoundLocation = dizin;
            et.Play();
        }

        private void g_et_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
