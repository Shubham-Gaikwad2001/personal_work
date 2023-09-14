using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Mgt_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
             if (tb_Username.Text == "A" && tb_Password.Text == "A")
            {
                MessageBox.Show("Login complete", "Sussesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

               frm_Add_Product obj = new frm_Add_Product();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            lbl_Note.Text = "invalid Username Or Password ";
            lbl_Note.Visible = true;
            lbl_Note.ForeColor = Color.Red;
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }
        }
    }

