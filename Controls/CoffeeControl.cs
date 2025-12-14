using System;
using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    public partial class CoffeeControl : UserControl
    {
        public CoffeeControl()
        {
            InitializeComponent();
        }

        // Label shown on the control (Coffee Order #1, etc.)
        public string LabelName
        {
            get => controllerName.Text;
            set => controllerName.Text = value;
        }

        // --------- PRICING PROPERTIES ---------

        private string SelectedSize => cb_Size.Text;

        private int CreamCount => (int)num_Cream.Value;

        private int SugarCount => (int)num_Sugar.Value;

        private bool HasWhippedCream => check_Whipped.Checked;

        // Price calculation
        public decimal Price
        {
            get
            {
                decimal basePrice =
                    SelectedSize == "Small" ? 2.00m :
                    SelectedSize == "Medium" ? 3.00m :
                    4.00m; // Large (default)

                return basePrice
                       + (CreamCount * 0.25m)
                       + (SugarCount * 0.15m)
                       + (HasWhippedCream ? 0.50m : 0m);
            }
        }

        // --------- RECEIPT OUTPUT ---------

        public override string ToString()
        {
            return
$@"{LabelName}
 • Size: {SelectedSize}
 • Cream: {CreamCount}
 • Sugar: {SugarCount}
{(check_Iced.Checked ? " • Iced\n" : "")}{(HasWhippedCream ? " • Whipped Cream\n" : "")} • Price: ${Price:F2}";
        }
    }
}
