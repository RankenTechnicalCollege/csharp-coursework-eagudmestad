using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class frmInventory : Form
    {
        List<Item> inventoryItems = new List<Item>();
        string accessKey;
        int foundPosition;
        public frmInventory()
        {
            InitializeComponent();

            //Program contains pre-populated list of items
            inventoryItems.Add(new Item("Felt Road Bike", "1234-1234", 3000.00, 2000.00, 1, "Felt Inc."));
            inventoryItems.Add(new Item("Giant Road Bike", "4321-4321", 2000.00, 1000.00, 1, "Giant Inc."));
            inventoryItems.Add(new Item("Specialized Road Bike", "5678-5678", 4000.00, 1000.00, 1, "Specialized Inc."));
            accessKey = "777";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            bool duplicateUpcs = false;
            lblAddError.Visible = false;

            //Checks for duplicate UPCs
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if(inventoryItems[i].Upc.Equals(txtAddUpc.Text))
                {
                    duplicateUpcs = true;
                }
            }

            if(duplicateUpcs)
            {
                //If UPC is duplicate - don't add item to the list
                lblAddError.Visible = true;
                lblAddError.Text = "This UPC already exists.  Item not added.";
            }
            else if(txtAddAccessKey.Text == accessKey)
            {
                //If UPC is unique - add item to the list
                inventoryItems.Add(new Item(txtAddName.Text, txtAddUpc.Text, double.Parse(txtAddStorePrice.Text), double.Parse(txtAddCostPerCase.Text), int.Parse(txtAddUnitsPerCase.Text), txtAddDistributor.Text));
                txtAddUpc.Text = "";
                txtAddUnitsPerCase.Text = "";
                txtAddStorePrice.Text = "";
                txtAddName.Text = "";
                txtAddDistributor.Text = "";
                txtAddCostPerCase.Text = "";
                txtAddAccessKey.Text = "";
            }
            else
            {
                //Invalid access key
                lblAddError.Visible = true;
                lblAddError.Text = "Invalid access key.";
            }
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if(inventoryItems[i].Name.ToLower().Contains(txtNameSearch.Text.ToLower()))
                {
                    found = true;
                    foundPosition = i;
                    lblItemName.Text = inventoryItems[i].Name;
                    lblItemUpc.Text = inventoryItems[i].Upc;
                    lblItemUnitsPerCase.Text = inventoryItems[i].UnitsPerCase.ToString("C");
                    lblItemStorePrice.Text = inventoryItems[i].StorePrice.ToString("C");
                    lblItemDistributor.Text = inventoryItems[i].Distributor;
                    lblItemCostPerCase.Text = inventoryItems[i].CostPerCase.ToString("C");
                    grpUpdateItem.Visible = true;
                    grpDeleteItem.Visible = true;
                }
            }

            if(!found)
            {
                lblItemName.Text = "ITEM NOT FOUND";
                lblItemUpc.Text = "ITEM NOT FOUND";
                lblItemUnitsPerCase.Text = "ITEM NOT FOUND";
                lblItemStorePrice.Text = "ITEM NOT FOUND";
                lblItemDistributor.Text = "ITEM NOT FOUND";
                lblItemCostPerCase.Text = "ITEM NOT FOUND";
                grpUpdateItem.Visible = false;
                grpDeleteItem.Visible = false;
                foundPosition = -1;
            }
        }

        private void btnUpcSearch_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if(inventoryItems[i].Upc.Equals(txtUpcSearch.Text))
                {
                    found = true;
                    foundPosition = i;
                    lblItemName.Text = inventoryItems[i].Name;
                    lblItemUpc.Text = inventoryItems[i].Upc;
                    lblItemUnitsPerCase.Text = inventoryItems[i].UnitsPerCase.ToString("C");
                    lblItemStorePrice.Text = inventoryItems[i].StorePrice.ToString("C");
                    lblItemDistributor.Text = inventoryItems[i].Distributor;
                    lblItemCostPerCase.Text = inventoryItems[i].CostPerCase.ToString("C");
                    grpUpdateItem.Visible = true;
                    grpDeleteItem.Visible = true;
                }
            }

            if(!found)
            {
                lblItemName.Text = "ITEM NOT FOUND";
                lblItemUpc.Text = "ITEM NOT FOUND";
                lblItemUnitsPerCase.Text = "ITEM NOT FOUND";
                lblItemStorePrice.Text = "ITEM NOT FOUND";
                lblItemDistributor.Text = "ITEM NOT FOUND";
                lblItemCostPerCase.Text = "ITEM NOT FOUND";
                grpUpdateItem.Visible = false;
                grpDeleteItem.Visible = false;
                foundPosition = -1;
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if(txtUpdateAccessKey.Text == "777")
            {
                //valid permissions to update
                lblUpdateError.Visible = false;

                //Update the item
                inventoryItems[foundPosition].StorePrice = double.Parse(txtUpdatePrice.Text);
                //Updates the label
                lblItemStorePrice.Text = inventoryItems[foundPosition].StorePrice.ToString("C");
                //Clear the textboxes
                txtUpdatePrice.Text = "";
                txtUpdateAccessKey.Text = "";
            }
            else
            {
                //invalid permissions to update
                lblUpdateError.Visible = true;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if(txtDeleteItemAccessKey.Text == "777" && txtDeleteItemUpc.Text == inventoryItems[foundPosition].Upc)
            {
                //delete item
                lblDeleteError.Visible = false;
                inventoryItems.RemoveAt(foundPosition);
                txtDeleteItemUpc.Text = "";
                txtDeleteItemAccessKey.Text = "";

                lblItemName.Text = "";
                lblItemUpc.Text = "";
                lblItemUnitsPerCase.Text = "";
                lblItemStorePrice.Text = "";
                lblItemDistributor.Text = "";
                lblItemCostPerCase.Text = "";
                grpUpdateItem.Visible = false;
                grpDeleteItem.Visible = false;
                foundPosition = -1;
            }
            else
            {
                //invalid access key
                lblDeleteError.Visible = true;
            }
        }
    }
}
