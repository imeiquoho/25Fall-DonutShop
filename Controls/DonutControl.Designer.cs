namespace _25Fall_DonutShop
{
    partial class DonutControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.controllerName = new System.Windows.Forms.Label();
            this.cb_Flavor = new System.Windows.Forms.ComboBox();
            this.donutAmount = new DonutNumericUpDown();

            this.controllerName.AutoSize = true;
            this.controllerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.controllerName.Location = new System.Drawing.Point(20, 10);
            this.controllerName.Text = "Donut";

            this.cb_Flavor.Items.AddRange(new object[]
            {
                "Glazed", "Chocolate", "Sprinkles", "Boston Cream"
            });
            this.cb_Flavor.Location = new System.Drawing.Point(20, 50);
            this.cb_Flavor.Text = "Glazed";

            this.donutAmount.Location = new System.Drawing.Point(180, 50);

            this.Controls.Add(this.controllerName);
            this.Controls.Add(this.cb_Flavor);
            this.Controls.Add(this.donutAmount);

            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Size = new System.Drawing.Size(300, 100);
        }

        private System.Windows.Forms.Label controllerName;
        private System.Windows.Forms.ComboBox cb_Flavor;
        private DonutNumericUpDown donutAmount;
    }
}
