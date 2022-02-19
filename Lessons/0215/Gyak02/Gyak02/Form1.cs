namespace Gyak02
{
    public partial class Form1 : Form
    {
        private bool actual = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            actual = !actual;
            if (actual) {
                lbl_hello.Text = "Hello World!";
            }
            else
            {
                lbl_hello.Text = "";
            }
            
        }

        private void btn_caluclate_Click(object sender, EventArgs e)
        {
            try
            {
                double convert = Double.Parse(textbox_c.Text);
                Console.WriteLine(convert);

                double result = convert + 273.15;
                label_k.Text = result.ToString() + " K";
            }
            catch (FormatException)
            {
                label_k.Text = $"Unable to parse '{textbox_c.Text}'";
                //Console.WriteLine($"Unable to parse '{textbox_c.Text}'");
            }



        }
    }
}