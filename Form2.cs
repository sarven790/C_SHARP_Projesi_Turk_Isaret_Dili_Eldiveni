using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {

        public Form2()
        {  
            InitializeComponent();  
        }

        public static int s = 0;
        private void benim_Click(object sender, EventArgs e)
        {
            g_benim newPage = new g_benim();

            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void sen_Click(object sender, EventArgs e)
        {
            g_sen newPage = new g_sen();

            if (s == 0)
            {                
                newPage.Show();
                s = 1;
            }
        }

        private void bu_Click(object sender, EventArgs e)
        {
            g_bu newPage = new g_bu();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void acikmak_Click(object sender, EventArgs e)
        {
            g_acikmak newPage = new g_acikmak();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void acimak_Click(object sender, EventArgs e)
        {
            g_acimak newPage = new g_acimak();
            if (s == 0)
            {

                newPage.Show();
                s = 1;

            }
           
        }

        private void ben_Click(object sender, EventArgs e)
        {
            g_ben newPage = new g_ben();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void bilmek_Click(object sender, EventArgs e)
        {
            g_bilmek newPage = new g_bilmek();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void yemek_Click(object sender, EventArgs e)
        {
            g_yemek newPage = new g_yemek();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void kola_Click(object sender, EventArgs e)
        {
            g_kola newPage = new g_kola();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void senin_Click(object sender, EventArgs e)
        {
            g_senin newPage = new g_senin();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void baba_Click(object sender, EventArgs e)
        {
            g_baba newPage = new g_baba();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void goz_Click(object sender, EventArgs e)
        {
            g_goz newPage = new g_goz();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void abla_Click(object sender, EventArgs e)
        {
            g_abla newPage = new g_abla();

            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void gormek_Click(object sender, EventArgs e)
        {
            g_gormek newPage = new g_gormek();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void agabey_Click(object sender, EventArgs e)
        {
            g_agabey newPage = new g_agabey();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void et_Click(object sender, EventArgs e)
        {
            g_et newPage = new g_et();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }

        private void sut_Click(object sender, EventArgs e)
        {
            g_sut newPage = new g_sut();
            if (s == 0)
            {
                newPage.Show();
                s = 1;
            }
        }
    }
}
