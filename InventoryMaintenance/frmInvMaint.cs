using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null;
        private List<InvItem> displayItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();

            displayItems = new List<InvItem>(invItems);

            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem item in displayItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem invItem = (InvItem)invItems[i];
                string message = $"Are you sure you want to delete {invItem.Description}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(invItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShow.Text == "All")
            {
                displayItems = new List<InvItem>(invItems);
                FillItemListBox();
            }
            else if (comboBoxShow.Text == "Under $10")
            {
                var displayItemsQuery = from invItem in invItems
                                        where invItem.Price < 10
                                        select invItem;

                displayItems.Clear();
                foreach (var item in displayItemsQuery)
                {
                    displayItems.Add(item);
                }

                FillItemListBox();

            }
            else if (comboBoxShow.Text == "Order By Price")
            {
                var displayItemsQuery = from invItem in invItems
                                        orderby invItem.Price
                                        select invItem;

                displayItems.Clear();
                foreach (var item in displayItemsQuery)
                {
                    displayItems.Add(item);
                }

                FillItemListBox();
            }
        }
    }
}
