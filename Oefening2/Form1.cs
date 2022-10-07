using Oefening1;  

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Uitspraak_Click(object sender, EventArgs e)
        {

        }

        private void button_LaatHoren_Click(object sender, EventArgs e)
        {
            if (CheckBox_koe.Checked)
            {
                Oefening1.Koe koe = new Koe(5, "Varken"); 
            }
            if (CheckBox_varken.Checked)
            {

            }
        }
    }
}