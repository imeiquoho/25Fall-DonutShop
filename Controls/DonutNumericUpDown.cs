using System.Windows.Forms;

namespace _25Fall_DonutShop
{
    // Lesson 3: Derived control from NumericUpDown
    public class DonutNumericUpDown : NumericUpDown
    {
        private readonly int[] validValues = { 1, 6, 12, 24 };
        private int index = 0;

        public DonutNumericUpDown()
        {
            ReadOnly = true;
            Value = validValues[index];
        }

        // MUST be public (matches base class)
        public override void UpButton()
        {
            if (index < validValues.Length - 1)
            {
                index++;
            }

            Value = validValues[index];
        }

        // MUST be public (matches base class)
        public override void DownButton()
        {
            if (index > 0)
            {
                index--;
            }

            Value = validValues[index];
        }
    }
}
