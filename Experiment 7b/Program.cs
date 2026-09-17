using System;
using System.Windows.Forms;

namespace DialogBoxApp
{
    public class Form1 : Form
    {
        Button btn;

        public Form1()
        {
            Text = "Dialog Box Example";
            Width = 400;
            Height = 300;

            btn = new Button();
            btn.Text = "Show Dialog Box";
            btn.Width = 150;
            btn.Height = 40;
            btn.Left = 110;
            btn.Top = 100;

            btn.Click += Btn_Click;

            Controls.Add(btn);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Hello! This is a Dialog Box.",
                "Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}