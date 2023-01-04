using InventoryManagment.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment.Forms
{
    public partial class Features : Form
    {
        private FunctionalController FController;
        public Features()
        {
            InitializeComponent();
            FController = new FunctionalController();
        }

        private void buttonDisplayProfits_Click(object sender, EventArgs e)
        {
            FController.calculateProfits(dataGridView);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void HistoryOfTransactions_Click(object sender, EventArgs e)
        {
            FController.changeToHistoryTable(dataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FController.changeToCategoryTable(dataGridView);
        }
    }
}
