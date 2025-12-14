using System;
using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddCoffee_Click(object sender, EventArgs e)
        {
            container.AddCoffee();
        }

        private void btn_AddDonut_Click(object sender, EventArgs e)
        {
            container.AddDonut();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            // Update owner-drawn receipt control
            receipt.ReceiptText = container.ToString();
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            container.ClearAll();
            receipt.ReceiptText = "";
        }

        private void btn_ClearLast_Click(object sender, EventArgs e)
        {
            container.ClearLast();
            receipt.ReceiptText = container.ToString();
        }
    }
}
