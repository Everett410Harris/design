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


        private void InventoryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e, IWin32Window Inventory)
        {
            // SHOWS THE INVENTORY PAGE OF WEBSITE
            Form F1 = new Form();
            F1.Show( owner:Inventory);
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
