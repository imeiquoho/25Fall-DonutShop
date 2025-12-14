using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    public partial class DonutControl : UserControl
    {
        public DonutControl()
        {
            InitializeComponent();
        }

        // Label shown on the control (Donut Order #1, etc.)
        public string LabelName
        {
            get => controllerName.Text;
            set => controllerName.Text = value;
        }

        // --------- PRICING PROPERTIES ---------

        private string SelectedFlavor => cb_Flavor.Text;

        private int Quantity => (int)donutAmount.Value;

        public decimal Price
        {
            get
            {
                return Quantity * 1.25m;
            }
        }

        // --------- RECEIPT OUTPUT ---------

        public override string ToString()
        {
            return
$@"{LabelName}
 • Flavor: {SelectedFlavor}
 • Quantity: {Quantity}
 • Price: ${Price:F2}";
        }
    }
}
