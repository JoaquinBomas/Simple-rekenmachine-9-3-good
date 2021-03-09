﻿using System;
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
            decimal operand1 = 0;
            decimal operand2 = 0;
            string operator;
            operand1 = Convert.ToDecimal(txtOperand1.Text);
            operator = txtOperator.Text;

            operand2 = Convert.ToDecimal(txtOperand2.Text);

            Calculate(operand1, operator, operand2);
        }

        private decimal Calculate(decimal operand1, string operator, decimal operand2)
        {
            decimal resultaat = 0;

            if (operator == "*")
            {
                resultaat = operand1 * operand2;
            }

            return resultaat;
        }

        //exit button 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}