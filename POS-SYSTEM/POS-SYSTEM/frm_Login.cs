using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            RoundedTextBox roundedTextBox = new RoundedTextBox
            {
                Width = 200,
                Height = 30,
                BorderRadius = 20,
                Location = new Point(50, 50), // Adjust location as needed
                BackColor = Color.White
            };
            this.Controls.Add(roundedTextBox);
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
