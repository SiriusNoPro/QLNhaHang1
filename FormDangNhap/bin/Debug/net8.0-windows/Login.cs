using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public string _label = "default value";
        public bool _password = false;
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public bool password
        {
            get { return _password; }
            set { _password = value; }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_paint(object sender, PaintEventArgs e)
        {
            label1.Text = Label;
            if (password)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
