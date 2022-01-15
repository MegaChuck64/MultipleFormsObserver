using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StaticComport.BufferChanged += StaticComport_BufferChanged;
        }

        private void StaticComport_BufferChanged(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(StaticComport.Buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticComport.PopulateBuffer();
        }
    }
}
