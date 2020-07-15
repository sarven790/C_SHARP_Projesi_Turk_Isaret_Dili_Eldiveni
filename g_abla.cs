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
    public partial class g_abla : Form
    {
        public g_abla()
        {
            InitializeComponent();
        }

        private void btn_abla_Click(object sender, EventArgs e)
        {
            SoundPlayer abla = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Abla.wav";
            abla.SoundLocation = dizin;
            abla.Play();
        }

        private void g_abla_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;              
        }
    }
}
