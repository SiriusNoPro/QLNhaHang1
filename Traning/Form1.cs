namespace Traning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnEqualizer_Click(object sender, EventArgs e)
        {

        }
        private void customizeDesing()
        {
            panelMeidasubmenu.Visible = false;
            paneltoolsubmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelMeidasubmenu.Visible == true)
            {
                panelMeidasubmenu.Visible = false;
            }
            if (paneltoolsubmenu.Visible == true)
            {
                paneltoolsubmenu.Visible = false;
            }
        }
        private void Showsubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hidesubmenu();
                SubMenu.Visible = true;

            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Showsubmenu(panelMeidasubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            Showsubmenu(paneltoolsubmenu);
        }
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            this.Controls.Add(ChildForm);

            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
