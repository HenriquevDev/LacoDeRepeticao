using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacoDeRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonexecutar_Click(object sender, EventArgs e)
        {
            listFor.Items.Add(1);
            listFor.Items.Add(2);
            listFor.Items.Add(3);
            listFor.Items.Add(4);
            listFor.Items.Add(5);
            listFor.Items.Add(6);
            listFor.Items.Add(7);
            listFor.Items.Add(8);
            listFor.Items.Add(9);
            listFor.Items.Add(10);
        }
    }
}
