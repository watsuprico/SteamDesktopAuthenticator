using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Steam_Desktop_Authenticator
{
    public partial class InputForm : MaterialForm
    {
        public bool Canceled = false;
        private bool userClosed = true;

        private readonly MaterialSkinManager materialSkinManager;
        public InputForm(string label, bool password = false)
        {
            InitializeComponent();
            this.labelText.Text = label;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            if (password)
            {
                this.txtBox.PasswordChar = '*';
                this.txtBox.UseSystemPasswordChar = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBox.Text))
            {
                this.Canceled = true;
                this.userClosed = false;
                this.Close();
            }
            else
            {
                this.Canceled = false;
                this.userClosed = false;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Canceled = true;
            this.userClosed = false;
            this.Close();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.userClosed)
            {
                // Set Canceled = true when the user hits the X button.
                this.Canceled = true;
            }
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtBox.Text))
                {
                    this.Canceled = true;
                    this.userClosed = false;
                    this.Close();
                }
                else
                {
                    this.Canceled = false;
                    this.userClosed = false;
                    this.Close();
                }
            }
        }
    }
}
