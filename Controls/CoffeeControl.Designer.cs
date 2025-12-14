namespace _25Fall_DonutShop
{
    partial class CoffeeControl
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
            this.cb_Size = new System.Windows.Forms.ComboBox();
            this.num_Cream = new System.Windows.Forms.NumericUpDown();
            this.num_Sugar = new System.Windows.Forms.NumericUpDown();
            this.check_Iced = new System.Windows.Forms.CheckBox();
            this.check_Whipped = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.num_Cream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sugar)).BeginInit();
            this.SuspendLayout();

            this.controllerName.AutoSize = true;
            this.controllerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.controllerName.Location = new System.Drawing.Point(20, 10);
            this.controllerName.Text = "Coffee";

            this.cb_Size.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            this.cb_Size.Location = new System.Drawing.Point(20, 50);
            this.cb_Size.Text = "Large";

            this.num_Cream.Location = new System.Drawing.Point(20, 80);
            this.num_Cream.Maximum = 10;

            this.num_Sugar.Location = new System.Drawing.Point(120, 80);
            this.num_Sugar.Maximum = 10;

            this.check_Iced.Location = new System.Drawing.Point(220, 50);
            this.check_Iced.Text = "Iced";

            this.check_Whipped.Location = new System.Drawing.Point(220, 80);
            this.check_Whipped.Text = "Whipped Cream";

            this.Controls.Add(this.controllerName);
            this.Controls.Add(this.cb_Size);
            this.Controls.Add(this.num_Cream);
            this.Controls.Add(this.num_Sugar);
            this.Controls.Add(this.check_Iced);
            this.Controls.Add(this.check_Whipped);

            this.BackColor = System.Drawing.Color.Brown;
            this.Size = new System.Drawing.Size(300, 120);

            ((System.ComponentModel.ISupportInitialize)(this.num_Cream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label controllerName;
        private System.Windows.Forms.ComboBox cb_Size;
        private System.Windows.Forms.NumericUpDown num_Cream;
        private System.Windows.Forms.NumericUpDown num_Sugar;
        private System.Windows.Forms.CheckBox check_Iced;
        private System.Windows.Forms.CheckBox check_Whipped;
    }
}
