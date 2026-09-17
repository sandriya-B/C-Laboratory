using System;
using System.Windows.Forms;

namespace DataValidation
{
    public class Form1 : Form
    {
        TextBox txtName;
        TextBox txtAge;
        TextBox txtEmail;
        Button btnSubmit;

        public Form1()
        {
            Text = "Control Data Validation";
            Width = 400;
            Height = 300;

            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Left = 30;
            lblName.Top = 40;

            txtName = new TextBox();
            txtName.Left = 120;
            txtName.Top = 40;

            Label lblAge = new Label();
            lblAge.Text = "Age:";
            lblAge.Left = 30;
            lblAge.Top = 80;

            txtAge = new TextBox();
            txtAge.Left = 120;
            txtAge.Top = 80;

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Left = 30;
            lblEmail.Top = 120;

            txtEmail = new TextBox();
            txtEmail.Left = 120;
            txtEmail.Top = 120;

            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Left = 120;
            btnSubmit.Top = 170;

            btnSubmit.Click += ValidateData;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSubmit);
        }

        private void ValidateData(object? sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name");
            }
            else if (!int.TryParse(txtAge.Text, out int age) ||
                     age < 1 || age > 100)
            {
                MessageBox.Show("Enter Valid Age");
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Enter Valid Email");
            }
            else
            {
                MessageBox.Show("Data Validation Successful!");
            }
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}