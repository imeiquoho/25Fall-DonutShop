using System;
using System.Drawing;
using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    public class ReceiptControl : UserControl
    {
        private string receiptText = "";

        public string ReceiptText
        {
            get { return receiptText; }
            set
            {
                receiptText = value;
                Invalidate(); // force redraw
            }
        }

        public ReceiptControl()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrWhiteSpace(receiptText))
                return;

            using (Brush brush = new SolidBrush(Color.Black))
            {
                RectangleF rect = new RectangleF(
                    10,
                    10,
                    this.Width - 20,
                    this.Height - 20
                );

                e.Graphics.DrawString(
                    receiptText,
                    this.Font,
                    brush,
                    rect
                );
            }
        }
    }
}
