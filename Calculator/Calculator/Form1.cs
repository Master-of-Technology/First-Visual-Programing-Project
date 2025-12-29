using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// user-defined functiions
        /// </summary>
       
        private string Evaluate(string opreation)
        {
            var table = new DataTable();
            var value = table.Compute(opreation,"");
            return value.ToString();
        }

        private bool Char_Chking(string txt)
        {
            if (string.IsNullOrEmpty(txt)) return false;

            char lastChar = txt[txt.Length - 1];
           
            switch (lastChar)
            {
                case '.':
                case '/':
                case '*':
                case '+':
                case '-':
                case '%':
                    return false;
                default:
                    return true;
            }
        }

        private bool Point_Chking(string txt)
        {
            if (string.IsNullOrEmpty(txt)) return true;

           
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                char c = txt[i];

              
                if (c == '.')
                    return false;

                
                if (c == '+' || c == '-' || c == '*' || c == '/' || c == '%')
                    return true;
            }

          
            return true;
        }

        private bool Opreations_With_Results(string txt)
        {
            foreach (var letter in txt)
			{
			 if (letter == '=')
             {
                 return true;
             }
			}
            return false ;
        }

        /// <summary>
        /// form lading and actins
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;  // مدة ظهور الرسالة بالملي ثانية
            toolTip.InitialDelay = 500;  // التأخير قبل الظهور
            toolTip.ReshowDelay = 100;   // التأخير عند الانتقال من زر لآخر
            toolTip.ShowAlways = true;   // تظهر دائماً حتى لو النافذة ليست في الواجهة\

            toolTip.SetToolTip(but_Clear_all, "Delete all ");
            toolTip.SetToolTip(but_Clearone, "Delete one Number ");
        }

        /// <summary>
        /// button actions
        /// </summary>
       

        private void button1_Click(object sender, EventArgs e)
        {
            but_num1.BackColor = Color.SkyBlue;
            txt_Showing.Text += "1";
        }

       

        private void but_num2_Click(object sender, EventArgs e)
        {
            but_num2.BackColor = Color.SkyBlue;
            txt_Showing.Text += "2";
        }

        private void but_num3_Click(object sender, EventArgs e)
        {
            but_num3.BackColor = Color.SkyBlue;
            txt_Showing.Text += "3";
        }

        private void but_num4_Click(object sender, EventArgs e)
        {
            but_num4.BackColor = Color.SkyBlue;
            txt_Showing.Text += "4";
        }

        private void but_num5_Click(object sender, EventArgs e)
        {
            but_num5.BackColor = Color.SkyBlue;
            txt_Showing.Text += "5";
        }

        private void but_num6_Click(object sender, EventArgs e)
        {
            but_num6.BackColor = Color.SkyBlue;
            txt_Showing.Text += "6";
        }

        private void but_num7_Click(object sender, EventArgs e)
        {
            but_num7.BackColor = Color.SkyBlue;
            txt_Showing.Text += "7";
        }

        private void but_num8_Click(object sender, EventArgs e)
        {
            but_num8.BackColor = Color.SkyBlue;
            txt_Showing.Text += "8";
        }

        private void but_num9_Click(object sender, EventArgs e)
        {
            but_num9.BackColor = Color.SkyBlue;
            txt_Showing.Text += "9";
        }

        private void but_num0_Click(object sender, EventArgs e)
        {
            but_num0.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "")
            txt_Showing.Text += "0";
        }

        private void but_Point_Click(object sender, EventArgs e)
        {
            but_Point.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text) && Point_Chking(txt_Showing.Text))
            txt_Showing.Text += ".";
        }

        /// <summary>
        /// opreations actions fun
        
        private void but_sum_Click(object sender, EventArgs e)
        {
            but_sum.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text))
                txt_Showing.Text += "+";
        }

        private void but_Meduleos_Click(object sender, EventArgs e)
        {
            but_Meduleos.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text))
                txt_Showing.Text += '%';
        }

        private void but_divide_Click(object sender, EventArgs e)
        {
            but_divide.BackColor = Color.SkyBlue;
            if (Opreations_With_Results(txt_Showing.Text))
            {
                var result = Evaluate(txt_Showing.Text);
                txt_Showing.Clear();
                txt_Showing.Text += result;
            }
             if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text))
                txt_Showing.Text += '/';
        }

        private void but_multi_Click(object sender, EventArgs e)
        {
            but_multi.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text))
                txt_Showing.Text += '*';
        }

        private void but_sub_Click(object sender, EventArgs e)
        {
            but_sub.BackColor = Color.SkyBlue;
            if (txt_Showing.Text != "" && Char_Chking(txt_Showing.Text))
                txt_Showing.Text += '-';
        }

    /// <summary>
    /// Mouse leave actions
    /// </summary>
  
        private void but_num0_MouseLeave(object sender, EventArgs e)
        {
            but_num0.BackColor = Color.Gainsboro;
        }

        private void but_num1_MouseLeave(object sender, EventArgs e)
        {
            but_num1.BackColor = Color.Gainsboro;
        }

        private void but_num2_MouseLeave(object sender, EventArgs e)
        {
            but_num2.BackColor = Color.Gainsboro;
        }

        private void but_num3_MouseLeave(object sender, EventArgs e)
        {
            but_num3.BackColor = Color.Gainsboro;
        }

        private void but_num4_MouseLeave(object sender, EventArgs e)
        {
            but_num4.BackColor = Color.Gainsboro;
        }

        private void but_num5_MouseLeave(object sender, EventArgs e)
        {
            but_num5.BackColor = Color.Gainsboro;
        }

        private void but_num6_MouseLeave(object sender, EventArgs e)
        {
            but_num6.BackColor = Color.Gainsboro;
        }

        private void but_num7_MouseLeave(object sender, EventArgs e)
        {
            but_num7.BackColor = Color.Gainsboro;
        }

        private void but_num8_MouseLeave(object sender, EventArgs e)
        {
            but_num8.BackColor = Color.Gainsboro;
        }

        private void but_num9_MouseLeave(object sender, EventArgs e)
        {
            but_num9.BackColor = Color.Gainsboro;
        }

        private void but_sub_MouseLeave(object sender, EventArgs e)
        {
            but_sub.BackColor = Color.Gainsboro;
        }

        private void but_sum_MouseLeave(object sender, EventArgs e)
        {
            but_sum.BackColor = Color.Gainsboro;
        }

        private void but_multi_MouseLeave(object sender, EventArgs e)
        {
            but_multi.BackColor = Color.Gainsboro;
        }

        private void but_divide_MouseLeave(object sender, EventArgs e)
        {
            but_divide.BackColor = Color.Gainsboro;
        }

        private void but_Meduleos_MouseLeave(object sender, EventArgs e)
        {
            but_Meduleos.BackColor = Color.Gainsboro;
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Point_MouseLeave(object sender, EventArgs e)
        {
            but_Point.BackColor = Color.Gainsboro;
        }



        private void but_Clearone_Click(object sender, EventArgs e)
        {
            string word = txt_Showing.Text;
            int size = word.Length - 1;
            if (size >= 0)
            {
                word = word.Substring(0, size);
                txt_Showing.Text = word;
            }
        }

        private void but_Result_Click(object sender, EventArgs e)
        {
            string opr = txt_Showing.Text;
           var result =  Evaluate(opr);
           txt_Showing.Text = opr + Environment.NewLine + " = " + Environment.NewLine + result; 
        }

        private void but_Clear_all_Click(object sender, EventArgs e)
        {
            txt_Showing.Clear();
        }

        
       
    }
}
