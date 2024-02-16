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
    public partial class Telka : UserControl
    {
        public Telka()
        {
            InitializeComponent();
        }

        private void Telka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VypniZapni();
        }
        private void VypniZapni()
        {
            if (string.IsNullOrWhiteSpace(pictureBox1.ImageLocation))
            {
                pictureBox1.ImageLocation = "https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExemRtN3NzazJheTJ3dmEzaXlhcjJwY2VzZm15MjN2dDlyNXBrZ2UyOCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/3o6ZtpRoYe9wbyfcBi/giphy.gif";
            }
            else
            {
                pictureBox1.ImageLocation = " ";
            }
        }
    }
}
