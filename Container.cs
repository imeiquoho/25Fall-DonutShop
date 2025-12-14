using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    public partial class Container : UserControl
    {
        private List<UserControl> userControlList;
        private int yAxis = 5;
        private int countCoffee = 0;
        private int countDonut = 0;

        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            userControlList = new List<UserControl>();
            panel.AutoScroll = true;
        }

        // =========================
        // ADD COFFEE
        // =========================
        public void AddCoffee()
        {
            countCoffee++;

            CoffeeControl coffee = new CoffeeControl();
            coffee.LabelName = "Coffee Order #" + countCoffee;
            coffee.Name = coffee.LabelName;
            coffee.Location = new Point(20, yAxis - panel.VerticalScroll.Value);

            yAxis += coffee.Height + 5;

            userControlList.Add(coffee);
            panel.Controls.Add(coffee);
        }

        // =========================
        // ADD DONUT
        // =========================
        public void AddDonut()
        {
            countDonut++;

            DonutControl donut = new DonutControl();
            donut.LabelName = "Donut Order #" + countDonut;
            donut.Name = donut.LabelName;
            donut.Location = new Point(20, yAxis - panel.VerticalScroll.Value);

            yAxis += donut.Height + 5;

            userControlList.Add(donut);
            panel.Controls.Add(donut);
        }

        // =========================
        // TOTAL CALCULATION
        // =========================
        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (UserControl control in userControlList)
            {
                if (control is CoffeeControl coffee)
                    total += coffee.Price;
                else if (control is DonutControl donut)
                    total += donut.Price;
            }

            return total;
        }

        // =========================
        // RECEIPT OUTPUT
        // =========================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("--------------------");

            if (userControlList.Count == 0)
            {
                sb.AppendLine("No items ordered.");
                return sb.ToString();
            }

            foreach (UserControl ctrl in userControlList)
            {
                sb.AppendLine(ctrl.ToString());
                sb.AppendLine();
            }

            sb.AppendLine("--------------------");
            sb.AppendLine($"TOTAL: ${GetTotal():F2}");

            return sb.ToString();
        }

        // =========================
        // CLEAR ALL
        // =========================
        public void ClearAll()
        {
            yAxis = 5;
            countCoffee = 0;
            countDonut = 0;

            userControlList.Clear();
            panel.Controls.Clear();
        }

        // =========================
        // CLEAR LAST
        // =========================
        public void ClearLast()
        {
            if (userControlList.Count == 0)
            {
                MessageBox.Show(
                    "There are no items.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            UserControl last = userControlList[userControlList.Count - 1];

            if (last is CoffeeControl)
                countCoffee--;
            else if (last is DonutControl)
                countDonut--;

            panel.Controls.Remove(last);
            userControlList.RemoveAt(userControlList.Count - 1);

            yAxis -= last.Height + 5;
        }
    }
}
