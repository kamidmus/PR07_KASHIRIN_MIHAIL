using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASHIRIN_M_PR07_GIT
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ;
        }
        public AdminForm()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void btnShowFio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Каширин Михаил Дмитриевич", "ФИО",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
