using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDesignRSC
{
    public partial class RSCHome : Form
    {
        public RSCHome()
        {
            InitializeComponent();
        }


        private void InventroyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // SHOWS THE INVENTORY PAGE OF WEBSITE
            Form F2 = new Form();
            F2.Show();
            InventroyLink.LinkVisited = true;
            try 
            {
                LinkVisted();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

        private void LinkVisted()
        {
            //CHANGE THE COLOR OF THE LINK TEXT
            InventroyLink.LinkVisited = true;
        }
    }
}
