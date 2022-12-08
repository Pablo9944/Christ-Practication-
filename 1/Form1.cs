namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // начальный цвет 153,180,209
            // желаемый  цвет 0,102,204

            for (byte r = 153, g =  180, b = 209; r >=0 & g >= 102 & b >= 204; r-=30,g-=15,b-=1 ,await Task.Delay(70))
            {
             
                label1.ForeColor = Color.FromArgb(r,g,b);

            }
            label1.ForeColor = Color.FromArgb(0, 102, 204);
            
            await Task.Delay(1000);

            for (byte r = 0, g = 102, b = 204; r <= 153 & g <= 180 & b <= 209; r += 30, g += 15, b += 1, await Task.Delay(70))
            {

                label1.ForeColor = Color.FromArgb(r, g, b);

            }
           
            label1.ForeColor = Color.FromArgb(153, 180, 209);

        }
    }
}