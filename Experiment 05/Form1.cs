using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public class Form1 : Form
    {
        Label lblName;
        TextBox txtName;
        CheckBox chkAgree;
        Button btnSubmit;
        Label lblResult;

        public Form1()
        {
            Text = "Windows Forms Controls";
            Size = new Size(450, 350);

            lblName = new Label();
            lblName.Text = "Enter Name:";
            lblName.Location = new Point(50, 50);
            lblName.AutoSize = true;

            txtName = new TextBox();
            txtName.Location = new Point(150, 50);
            txtName.Width = 180;

            chkAgree = new CheckBox();
            chkAgree.Text = "I Agree";
            chkAgree.Location = new Point(150, 100);
            chkAgree.AutoSize = true;

            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(150, 150);

            lblResult = new Label();
            lblResult.Location = new Point(50, 210);
            lblResult.AutoSize = true;

            btnSubmit.Click += BtnSubmit_Click;

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
    }
}