using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public class Form1 : Form
    {
        Label lblName;
        TextBox txtName;
        Button btnSubmit;
        CheckBox chkAgree;
        Label lblResult;

        public Form1()
        {
            // Form properties
            Text = "Windows Forms Controls";
            Size = new Size(450, 350);

            // Label
            lblName = new Label();
            lblName.Text = "Enter Name:";
            lblName.Location = new Point(50, 50);
            lblName.AutoSize = true;

            // TextBox
            txtName = new TextBox();
            txtName.Location = new Point(150, 50);
            txtName.Width = 180;

            // CheckBox
            chkAgree = new CheckBox();
            chkAgree.Text = "I Agree";
            chkAgree.Location = new Point(150, 100);
            chkAgree.AutoSize = true;

            // Button
            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(150, 150);

            // Button click event
            btnSubmit.Click += BtnSubmit_Click;

            // Result Label
            lblResult = new Label();
            lblResult.Location = new Point(50, 210);
            lblResult.AutoSize = true;

            // Add controls to form
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(chkAgree);
            Controls.Add(btnSubmit);
            Controls.Add(lblResult);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (chkAgree.Checked)
            {
                lblResult.Text = "Hello " + txtName.Text;
            }
            else
            {
                lblResult.Text = "Please select I Agree.";
            }
        }

        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}