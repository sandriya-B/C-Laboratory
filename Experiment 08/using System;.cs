using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDIApplication
{
    public class Form1 : Form
    {
        MenuStrip menuStrip;
        ToolStripMenuItem fileMenu;
        ToolStripMenuItem newMenu;
        ToolStripMenuItem exitMenu;
        ToolStripMenuItem windowMenu;

        public Form1()
        {
            // Main Form settings
            this.Text = "MDI Application";
            this.IsMdiContainer = true;
            this.Width = 800;
            this.Height = 500;

            // Create MenuStrip
            menuStrip = new MenuStrip();

            // File Menu
            fileMenu = new ToolStripMenuItem("File");

            // New Menu Item
            newMenu = new ToolStripMenuItem("New");
            newMenu.Click += NewMenu_Click;

            // Exit Menu Item
            exitMenu = new ToolStripMenuItem("Exit");
            exitMenu.Click += ExitMenu_Click;

            // Add New and Exit to File
            fileMenu.DropDownItems.Add(newMenu);
            fileMenu.DropDownItems.Add(exitMenu);

            // Window Menu
            windowMenu = new ToolStripMenuItem("Window");

            // Add menus to MenuStrip
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(windowMenu);

            // Set Window menu for MDI child arrangement
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
            this.MdiWindowListItem = windowMenu;
        }

        // New menu event
        private void NewMenu_Click(object sender, EventArgs e)
        {
            Form child = new Form();

            child.Text = "Child Form";
            child.Width = 400;
            child.Height = 300;

            child.MdiParent = this;
            child.Show();
        }

        // Exit menu event
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Main method
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}