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
    public partial class g_bu : Form
    {
        public g_bu()
        {
            InitializeComponent();
        }

        private void btn_bu_Click(object sender, EventArgs e)
        {
            SoundPlayer bu = new SoundPlayer();
            string dizin4 = Application.StartupPath + "\\Bu.wav";
            bu.SoundLocation = dizin4;
            bu.Play();
        }

        private void g_bu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
