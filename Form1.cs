namespace Calculator
{
    public partial class Form1 : Form
    {
        private calcController calcController;

        public Form1()
        {
            InitializeComponent();
            calcController = new calcController();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonclear();
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonAllClear();
        }

        private void buttonSqrRoot_Click(object sender, EventArgs e)
        {

        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.arithmetic('/');
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.arithmetic('*');
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.arithmetic('-');
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.arithmetic('+');
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.equals();
        }

        private void buttonSwitchSign_Click(object sender, EventArgs e)
        {

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("1");
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("6");
        }
        private void buttonSeven_click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("7");
        }


        private void buttonEight_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("8");
        }
        
        private void buttonNine_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress("9");
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = calcController.buttonNumberPress(".");
        }

      
    }
}