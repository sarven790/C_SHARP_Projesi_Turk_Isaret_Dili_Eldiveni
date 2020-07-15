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
    public partial class g_sut : Form
    {
        public g_sut()
        {
            InitializeComponent();
        }

        private void btn_sut_Click(object sender, EventArgs e)
        {
            SoundPlayer sut = new SoundPlayer();
            string dizin = Application.StartupPath + "\\Süt.wav";
            sut.SoundLocation = dizin;
            sut.Play();
        }

        private void g_sut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.s = 0;
        }
    }
}
