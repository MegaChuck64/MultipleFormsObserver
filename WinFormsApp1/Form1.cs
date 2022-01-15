namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StaticComport.BufferChanged += StaticComport_BufferChanged;
        }

        private void StaticComport_BufferChanged(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(StaticComport.Buffer);
        }

        private void OpenForm2Button_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}