using MyBazarPOSApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBazarPOSApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }  

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text !="" && txtPassword.Text != "")
            {
                DataTable dataTable = new DataTable();
                dataTable = DBAccess.FillDataTable("Select * from user_tb where Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'COLLATE SQL_Latin1_General_CP1_CS_AS and IsActive=1", dataTable);
                if (dataTable != null && dataTable.Rows.Count>0)
                {
                    MessageBox.Show("Login successfull.", "Rezaul POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Username or password Incorrect!.", "Rezaul POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Please enter username or password", "Rezaul POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
