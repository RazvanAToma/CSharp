namespace GUI_Oppgave_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fetch Radius and transform to number:
            double radius = double.Parse(radiusTextBox.Text);

            // Calculate Area:
            double area = Math.PI * Math.Pow(radius, 2);

            // Calculate Circumference:
            double circumference = Math.PI * radius * 2;

            // Set Values:
            areaTextBox.Text = area.ToString();
            circumferenceTextBox.Text = circumference.ToString();
        }
    }
}
