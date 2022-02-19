namespace Calculator
{
    public partial class Calculator : Form
    {
        private string numberInput="0";
        private char op;
        private string op1;
        private string op2;

        public Calculator()
        {
            InitializeComponent();
            
            lb_value.Text = numberInput;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lb_value.Text = numberInput;
        }

        private void NumberInput(object sender, EventArgs e)
        {
            if(numberInput== "0")
            {
                numberInput = "";
            }
            numberInput += ((Button)sender).Text;
            UpdateDisplay();
        }

        private void btn_Delete(object sender, EventArgs e)
        {
            if(numberInput.Length> 1)
            {
                numberInput = numberInput.Remove(numberInput.Length - 1, 1);
            }
            else
            {
                numberInput = "0";
            }
            UpdateDisplay();
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!numberInput.Contains(",")){
                numberInput += ((Button)sender).Tag;
            }
        }

        private void btn_Polarity(object sender, EventArgs e)
        {
            char fistChar = numberInput[0];

            if (!char.IsDigit(fistChar))
            {
                numberInput = numberInput.Remove(0, 1);
            }
            else
            {
                if(lb_value.Text != "0")
                {
                    numberInput = "-" + numberInput;
                }
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {

        }
    }
}