using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCHash
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_Greeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!!환영합니다!!!!","환영 인사",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}
