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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
       

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ShowDialog();
        }
   
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
