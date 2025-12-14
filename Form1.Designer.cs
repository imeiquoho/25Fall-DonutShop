namespace _25Fall_DonutShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btn_AddCoffee = new System.Windows.Forms.Button();
            this.btn_AddDonut = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_ClearLast = new System.Windows.Forms.Button();
            this.container = new _25Fall_DonutShop.Container();
            this.receipt = new _25Fall_DonutShop.ReceiptControl();
            this.SuspendLayout();
            // 
            // btn_AddCoffee
            // 
            this.btn_AddCoffee.Location = new System.Drawing.Point(12, 12);
            this.btn_AddCoffee.Name = "btn_AddCoffee";
            this.btn_AddCoffee.Size = new System.Drawing.Size(88, 74);
            this.btn_AddCoffee.TabIndex = 1;
            this.btn_AddCoffee.Text = "Add Coffee";
            this.btn_AddCoffee.UseVisualStyleBackColor = true;
            this.btn_AddCoffee.Click += new System.EventHandler(this.btn_AddCoffee_Click);
            // 
            // btn_AddDonut
            // 
            this.btn_AddDonut.Location = new System.Drawing.Point(106, 12);
            this.btn_AddDonut.Name = "btn_AddDonut";
            this.btn_AddDonut.Size = new System.Drawing.Size(88, 74);
            this.btn_AddDonut.TabIndex = 2;
            this.btn_AddDonut.Text = "Add Donut";
            this.btn_AddDonut.UseVisualStyleBackColor = true;
            this.btn_AddDonut.Click += new System.EventHandler(this.btn_AddDonut_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.Location = new System.Drawing.Point(12, 415);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(182, 74);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "Pay and Print Receipt";
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(12, 335);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(88, 74);
            this.btn_ClearAll.TabIndex = 5;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_ClearLast
            // 
            this.btn_ClearLast.Location = new System.Drawing.Point(12, 255);
            this.btn_ClearLast.Name = "btn_ClearLast";
            this.btn_ClearLast.Size = new System.Drawing.Size(88, 74);
            this.btn_ClearLast.TabIndex = 6;
            this.btn_ClearLast.Text = "Clear Last";
            this.btn_ClearLast.UseVisualStyleBackColor = true;
            this.btn_ClearLast.Click += new System.EventHandler(this.btn_ClearLast_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(219, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(340, 480);
            this.container.TabIndex = 0;
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(570, 12);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(220, 480);
            this.receipt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.btn_ClearLast);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_AddDonut);
            this.Controls.Add(this.btn_AddCoffee);
            this.Controls.Add(this.container);
            this.Name = "Form1";
            this.Text = "Donut Shop";
            this.ResumeLayout(false);
        }

        #endregion

        private Container container;
        private System.Windows.Forms.Button btn_AddCoffee;
        private System.Windows.Forms.Button btn_AddDonut;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_ClearLast;
        private ReceiptControl receipt;
    }
}
