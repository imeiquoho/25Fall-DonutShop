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

        // =========================
        // HELPER: REFRESH RECEIPT
        // =========================
        private void RefreshReceipt()
        {
            receipt.ReceiptText = container.ToString();
            receipt.Invalidate(); // forces redraw of owner-drawn receipt
        }

        // =========================
        // ADD COFFEE
        // =========================
        private void btn_AddCoffee_Click(object sender, EventArgs e)
        {
            container.AddCoffee();
            RefreshReceipt();
        }

        // =========================
        // ADD DONUT
        // =========================
        private void btn_AddDonut_Click(object sender, EventArgs e)
        {
            container.AddDonut();
            RefreshReceipt();
        }

        // =========================
        // PAY & PRINT RECEIPT
        // =========================
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            RefreshReceipt(); // final refresh still valid
        }

        // =========================
        // CLEAR ALL
        // =========================
        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            container.ClearAll();
            RefreshReceipt();
        }

        // =========================
        // CLEAR LAST
        // =========================
        private void btn_ClearLast_Click(object sender, EventArgs e)
        {
            container.ClearLast();
            RefreshReceipt();
        }
    }
}
