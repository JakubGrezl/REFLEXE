using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFLEXE
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Nakrm()
        {
            progressBar1.Value = Math.Clamp(progressBar1.Value + 10,0,100);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Nakrm();
        }
    }
}
