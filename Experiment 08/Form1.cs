using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "MDI Application";
            this.IsMdiContainer = true;

            // Menu Strip
            MenuStrip menuStrip = new MenuStrip();

            // File Menu
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");

            // New
            ToolStripMenuItem newMenu = new ToolStripMenuItem("New");
            newMenu.Click += NewMenu_Click;

            // Exit
            ToolStripMenuItem exitMenu = new ToolStripMenuItem("Exit");
            exitMenu.Click += ExitMenu_Click;

            // Add items to File
            fileMenu.DropDownItems.Add(newMenu);
            fileMenu.DropDownItems.Add(exitMenu);

            // Window Menu
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");

            // Add menus
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(windowMenu);

            // Add MenuStrip to Form
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;
        }

        private void NewMenu_Click(object? sender, EventArgs e)
        {
            Form childForm = new Form();

            childForm.Text = "Child Form";
            childForm.Width = 400;
            childForm.Height = 300;

            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ExitMenu_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}