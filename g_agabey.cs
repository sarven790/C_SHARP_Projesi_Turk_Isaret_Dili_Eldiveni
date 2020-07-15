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
    public partial class g_agabey : Form
    {
        public g_agabey()
        {
            InitializeComponent();
        }

        private void btn_agabey_Click(object sender, EventArgs e)
        {
            SoundPlayer agabey = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Ağabey.wav";
            agabey.SoundLocation = dizin;
            agabey.Play();
        }

        private void g_agabey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
