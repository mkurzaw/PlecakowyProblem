using ConsoleApp2;
namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seed = int.Parse(textBoxSeed.Text);
            int n = int.Parse(textBoxN.Text);
            int total = int.Parse(textBoxTotal.Text);
            Generator generator_mass = new Generator(n, seed);
            Generator generator_value = new Generator(n, seed+1);

            //textBoxValues2.Text=generator_mass.ToString();
            //textBoxValues2.Text=generator_value.ToString();
            listBox1.Items.Clear();
            for(int i = 0; i < n; i++)
            {
               listBox1.Items.Add (i + 1 + ".m:" + generator_mass.numbers[i] + "   v:" + generator_value.numbers[i] + Environment.NewLine);
            }
           

            
            
            int mass = 0;
            int value = 0;


            for (int i = 1; i < generator_value.numbers.Count; i++)
            {
                if (generator_mass.numbers[i] < total)
                {
                    
                    mass = generator_mass.numbers[i] + mass;
                    value = generator_value.numbers[i] + value;


                    total = total - generator_mass.numbers[i];
                }
                
                   
            }
            textBoxValues.Text = "Masa: " + mass +Environment.NewLine+ "Wartosc: " + value;
            

            
        }

        private void textBoxValues_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxValues2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}