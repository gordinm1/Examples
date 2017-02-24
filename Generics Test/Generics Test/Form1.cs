using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics_Test
{
    public partial class Form1 : Form
    {

        CheckBox[] testC;
        Label[] testL;

        public Form1()
        {
            InitializeComponent();
            testC = new CheckBox[] { checkBox1, checkBox2 };
            testL = new Label[] { label1, label2 };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void changeVisibility<T> (T[] test) where T: Control
        {
            for(int i = 0; i< test.Length; i++)
            {
                test[i].Visible = !test[i].Visible;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeVisibility(testC);
            changeVisibility(testL);
        }
    }
}
