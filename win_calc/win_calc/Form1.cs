using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_calc
{
    public partial class Form1 : Form
    {
        //Since we have decimal we use Double to store numbers
        Double value = 0;
        //To catch the operate pressed a string variable is made
        string operation = "";
        //A Boolean is needed so that numbers don't keep appending, but resets itself
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        //This method takes the button that is clicked for 0-9 and ., which it then appends the screen
        private void button_Click(object sender, EventArgs e)
        {   
            //After a button is clicked removes the 0 that is shown on start or when a operator is clicked 

            if((result.Text == "0")||(operation_pressed))
            {
                result.Clear();
            }

            //stops resetting the screen
            operation_pressed = false;
            //Button b takes the value of the button clicked to output into the screen
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        //When CE is clicked return screen to 0
        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        //When operators are clicked
        private void operator_click(object sender, EventArgs e)
        {
            //Button b takes the operator that was pressed and puts it in the empty operation string
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            //The small text should display the previous number input and the operator
            equation.Text = (value + " " + operation).ToString();

        }

        //When equals is pressed 
        private void button16_Click(object sender, EventArgs e)
        {
            //The small text is no longer needed after having found the valu of the input
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    /*Here we display on the screen 
                    the addition of the stored number + the number currently on the screen same for the rest*/
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end of switch
        }

        //By pressing clear the screen gonna go back to 0 and also make value = 0 again
        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
