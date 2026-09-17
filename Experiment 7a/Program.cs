using System;
using System.Windows.Forms;

namespace WindowsValidation
{
    public class MainForm : Form
    {
        Label lblName, lblEmail, lblAge, lblPassword;
        TextBox txtName, txtEmail, txtAge, txtPassword;
        Button btnSubmit;

        public MainForm()
        {
            Text = "Data Validation";
            Width = 400;
            Height = 350;

            lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new System.Drawing.Point(40, 40);
            lblName.AutoSize = true;

            txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(150, 40);
            txtName.Width = 180;

            lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new System.Drawing.Point(40, 90);
            lblEmail.AutoSize = true;

            txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(150, 90);
            txtEmail.Width = 180;

            lblAge = new Label();
            lblAge.Text = "Age:";
            lblAge.Location = new System.Drawing.Point(40, 140);
            lblAge.AutoSize = true;

            txtAge = new TextBox();
            txtAge.Location = new System.Drawing.Point(150, 140);
            txtAge.Width = 180;

            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(40, 190);
            lblPassword.AutoSize = true;

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(150, 190);
            txtPassword.Width = 180;
            txtPassword.PasswordChar = '*';

            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new System.Drawing.Point(150, 240);
            btnSubmit.Click += BtnSubmit_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSubmit);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            if (txtEmail.Text == "" || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.");
                txtEmail.Focus();
                return;
            }

            int age;

            if (!int.TryParse(txtAge.Text, out age) || age < 18)
            {
                MessageBox.Show("Age must be a number and should be 18 or above.");
                txtAge.Focus();
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must contain at least 6 characters.");
                txtPassword.Focus();
                return;
            }

            MessageBox.Show("Validation Successful!");
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}