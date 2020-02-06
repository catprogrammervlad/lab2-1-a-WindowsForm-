using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1_a_WindowsForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            // create and fill array
            int[] array = new int[4];
            String array_text = "";
            for (int i = 0; i < 4; i++)
            {
                array[i] = random.Next(-10, 10);
                array_text += array[i] + " ";
            }

            // find index of first negative element
            int index_negative = 0;
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < 0)
                {
                    index_negative = i;
                    break;
                }
                else
                {
                    continue;
                }
            }

            // find index of last positive element
            int index_positive = 0;
            for (int i = 4 - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    index_positive = i;
                    break;
                }
                else
                {
                    continue;
                }
            }

            int buffer;
            buffer = array[index_positive];
            array[index_positive] = array[index_negative];
            array[index_negative] = buffer;

            string array_text_2 = "";
            for (int i = 0; i < 4; i++)
            {
                array_text_2 += array[i] + " ";
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(array[i] + " ");
            }

            textBox1.Text = array_text;
            textBox2.Text = array_text_2;

        }
    }
}
