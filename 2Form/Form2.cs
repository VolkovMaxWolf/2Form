using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GetNumbers();
            ShowNumbers();

        }

        private void FindMaxSpeed(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 && textBox1.Text != "" && char.IsLetter(Convert.ToChar(textBox1.Text)))
            {
                textBox2.Text = Convert.ToString(GetMaxSpeed
                    (Convert.ToChar(textBox1.Text)));
            }
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] == '-' && arr[i] != ',')
                {
                    return false;
                }
            }
            return true;
        }
        private int GetMaxSpeed(char ch)
        {
            switch (ch)
            {
                case 'a': return 300;
                case 'в': return 45;
                case 'м': return 245;
                case 'с': return 1200;
                case 'п': return 450;
                default: return 0;
            }
        }
        private void GetNumbers()
        {

            for (int i = 10; i < 100; i++)
            {
                if (Math.Abs(i % 10 - (i - i % 10) / 10) <= 1)
                textBox3.AppendText(i + " ");
            }
            textBox3.AppendText(Environment.NewLine);


            int j = 9;
            while (j < 100)
            {
                j++;
                if (Math.Abs(j % 10 - (j - j % 10) / 10) <= 1)
                    textBox3.AppendText(j + " ");
            }
            textBox3.AppendText(Environment.NewLine);


            int k = 10;
            do
            {
                if (Math.Abs(k % 10 - (k - k % 10) / 10) <= 1)
                    textBox3.AppendText(k + " ");
                k++;
            }
            while (k < 100);
            textBox3.AppendText(Environment.NewLine);
        }
        private void ShowNumbers()
        {
            int first = 9;
            int second = 4;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    textBox4.AppendText(first + " ");
                }
                first--;
                textBox4.AppendText(Environment.NewLine);
                for (int j = 0; j < i; j++)
                {
                    textBox4.AppendText(second + " ");
                }
                second--;
                textBox4.AppendText(Environment.NewLine);
            }

        }
    }
}
