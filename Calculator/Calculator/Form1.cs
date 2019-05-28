using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Author: Buddy van Peer
 Creation Date: 21/05/19
 Version: 1.0
 */

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        /* Methods for buttons 0-9
         * When clicked the relative number is displayed in the calculator's textbox */
        public void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }
        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }
        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }
        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }
        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }
        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }
        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        // Clears the textbox
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Displays a decimal point when the point button is clicked
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        // Variables for calculating sums and getting a result
        double result = 0;
        double num = 0;
        double num1 = 0; 
        double num2 = 0;
        // Booleans to check which artihmetic button was clicked
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        // Checks to see if input is valid then makes approopriate boolean true
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num1))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            txtDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }
        // Checks to see if input is valid then makes approopriate boolean true
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num1))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }              

            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }
        // Checks to see if input is valid then makes approopriate boolean true
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num1))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }                

            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }
        // Checks to see if input is valid then makes approopriate boolean true
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num1))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        // Checks to see if input is valid then checks which boolean is true and calculates result on appropriate arithmetic
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num2))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            if (plusButtonClicked)
            {
                result = BasicMath.Arithmetic.Add(num1, num2);
            }
            else if (minusButtonClicked)
            {
                result = BasicMath.Arithmetic.Sub(num1, num2);
            }
            else if (divideButtonClicked)
            {
                result = BasicMath.Arithmetic.Div(num1, num2);
            }
            else if (multiplyButtonClicked)
            {
                result = BasicMath.Arithmetic.Mult(num1, num2);
            }

            txtDisplay.Text = result.ToString();
            num1 = 0;
        }

        // Checks to see if input is valid then calculates square root of the input
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            if (num >= 0)
            {
                txtDisplay.Text = BasicMath.Algebraic.Sqrt(num).ToString();
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error");
                txtDisplay.Text = "0";
            }
        }       

        // Alternative way to clear the textbox via menu item
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Alternative way to quit application via menu item
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Checks to see if input is valid then calculates cube root of the input
        private void BtnCbrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            txtDisplay.Text = BasicMath.Algebraic.Cbrt(num).ToString();
        }

        // Checks to see if input is valid then calculates the inverse of the input
        private void BtnInv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            txtDisplay.Text = BasicMath.Algebraic.inverse(num).ToString();
        }

        /* Checks to see if input is valid and a radiobutton has been checked, 
         * then calculates the sine of the input in the desired unit */
        private void BtnSin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            if (rbDegrees.Checked)
            {
                double radians = num * (Math.PI / 180);

                txtDisplay.Text = BasicMath.Trigonometric.Sin(radians).ToString();
            }
            else if (rbRadians.Checked)
            {
                txtDisplay.Text = BasicMath.Trigonometric.Sin(num).ToString();
            }
            else
            {
                MessageBox.Show("Please select degrees or radians", "Choose a unit");
            }           
        }
        /* Checks to see if input is valid and a radiobutton has been checked, 
         * then calculates the cosine of the input in the desired unit */
        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            if (rbDegrees.Checked)
            {
                double radians = num * (Math.PI / 180);

                txtDisplay.Text = BasicMath.Trigonometric.Cos(radians).ToString();
            }
            else if (rbRadians.Checked)
            {
                txtDisplay.Text = BasicMath.Trigonometric.Cos(num).ToString();
            }
            else
            {
                MessageBox.Show("Please select degrees or radians", "Choose a unit");
            }
        }
        /* Checks to see if input is valid a radiobutton has been checked,
         * then calculates the tangent of the input in the desired unit.
         * If  the input is 90 or 270 degrees then undefined displays in textbox*/
        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && !double.TryParse(txtDisplay.Text, out num))
            {
                MessageBox.Show(txtDisplay.Text + " is not a double");
            }

            if (rbDegrees.Checked)
            {
                if (num == 90 || num == 270)
                {
                    txtDisplay.Text = "Undefined";                    
                }
                else
                {
                    double radians = num * (Math.PI / 180);

                    txtDisplay.Text = BasicMath.Trigonometric.Tan(radians).ToString();
                }
            }
            else if (rbRadians.Checked)
            {
                txtDisplay.Text = BasicMath.Trigonometric.Tan(num).ToString();
            }
            else
            {
                MessageBox.Show("Please select degrees or radians", "Choose a unit");
            }
        }
    }
}
