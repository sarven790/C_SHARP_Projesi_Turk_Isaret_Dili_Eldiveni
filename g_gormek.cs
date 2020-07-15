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
    public partial class g_gormek : Form
    {
        public g_gormek()
        {
            InitializeComponent();
        }

        private void btn_gormek_Click(object sender, EventArgs e)
        {
            SoundPlayer gormek = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Görmek.wav";
            gormek.SoundLocation = dizin;
            gormek.Play();
        }

        private void g_gormek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
