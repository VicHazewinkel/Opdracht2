namespace Oefening3
{
    public partial class CurrencyConvertor : Form
    {
        public CurrencyConvertor()
        {
            InitializeComponent();
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox_Amount.Text);
            
            if (comboBox_From.SelectedItem == "Euro" && comboBox_To.SelectedItem == "USD")
            {
                double convert = i*0.9827; 
                textBox_Converted.Text = convert + " $ (USD)";
            }
            else if (comboBox_From.SelectedItem == "British_Pound" && comboBox_To.SelectedItem == "USD")
            {
                double convert = i * 1.1325;
                textBox_Converted.Text = convert + " $ (USD)";
            }
            else if (comboBox_From.SelectedItem == "Japanse_Yen" && comboBox_To.SelectedItem == "USD")
            {
                double convert = i * 0.0086062;
                textBox_Converted.Text = convert + " $ (USD)";
            }
            else if (comboBox_From.SelectedItem == "Indiaase_Rupees" && comboBox_To.SelectedItem == "USD")
            {
                double convert = i * 0.0122;
                textBox_Converted.Text = convert + " $ (USD)";
            }
            else if (comboBox_From.SelectedItem == "Zwitserse_Franken" && comboBox_To.SelectedItem == "USD")
            {
                double convert = i * 1.0079;
                textBox_Converted.Text = convert + " $ (USD)";
            }
        }

        private void textBox_Converted_TextChanged(object sender, EventArgs e)
        {

        }
    }
}