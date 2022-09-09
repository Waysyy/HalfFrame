using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Z3Course3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] symbols = { "Рамка 1", "Рамка 2", "Рамка 3" };
            listBox1.Items.AddRange(symbols);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vivod = "";
            string vivod2 = "";
            string[] rtfStrings = richTextBox1.Text.Split(new char[] { '\n' });
            string[] storona = new string[rtfStrings.Length];
            string verh = "";

            for(int i = 0; i < rtfStrings.Length; ++i)
            {
                string tmp = rtfStrings[0];
                string MaxLenght = rtfStrings[i];
                if (MaxLenght.Length > tmp.Length) 
                {
                    tmp = MaxLenght;
                }
                verh = tmp;
            }

            for (int i = 0; i< rtfStrings.Length; ++i )
            {
                storona[i] = "|";
            }
            for (int i = 0; i < storona.Length; ++i)
            {
                string MaxL = "";
                MaxL = rtfStrings[i];

                vivod += Convert.ToString(storona[i]) + " " + rtfStrings[i];
                    for (int j = 0; j < verh.Length; ++j)
                    {
                     
                    if (MaxL.Length < verh.Length+1 && MaxL.Length != verh.Length)
                        {
                            vivod += "  ";
                            MaxL += "1";
                        }
                    }
                vivod += Convert.ToString(storona[i]) + "\n";
                
                /*vivod += Convert.ToString(storona[i]) + empty.PadRight(verh, ' ') + rtfStrings[i]
                + empty.PadRight(verh*2, ' ') + Convert.ToString(storona[i]) + "\n";*/
                
                
                
            }
            for (int i = 0; i < verh.Length; ++i)
            {
                vivod2 += " -";
            }
            
            string selectedSymbols = listBox1.SelectedItem.ToString();
            MessageBox.Show( vivod2 + "\n" + vivod +  vivod2);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
