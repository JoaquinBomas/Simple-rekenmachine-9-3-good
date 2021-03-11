using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpele_Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = 0;
                decimal operand2 = 0;
                string operant = "";
                operand1 = Convert.ToDecimal(txtOperand1.Text);
                operant = txtOperator.Text;

                operand2 = Convert.ToDecimal(txtOperand2.Text);
                bool gelukt = Decimal.TryParse(txtOperand2.Text, out operand2);
                if (gelukt == false)
                {
                    throw new OverflowException("Operand2 is ongeldig.");
                }
                else
                {
                    throw new Exception("algemene melding.");
                }

                //Calculate(operand1, operant, operand2);

            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private decimal Calculate(decimal operand1, string operant, decimal operand2)
        {

            try
            {
                decimal resultaat = 0;

                if (operant == "*")
                {
                    resultaat = operand1 * operand2;
                    txtResult.Text = Convert.ToString(resultaat);
                }

                if (operant == "/")
                {
                    resultaat = operand1 / operand2;
                    txtResult.Text = Convert.ToString(resultaat);
                }

                if (operant == "-")
                {
                    resultaat = operand1 - operand2;
                    txtResult.Text = Convert.ToString(resultaat);
                }

                if (operant == "+")
                {
                    resultaat = operand1 + operand2;
                    txtResult.Text = Convert.ToString(resultaat);
                }

                return resultaat;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            

        }

        //exit button 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
