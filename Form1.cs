using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "Please Enter Numbers Only";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtM.Text; // 將txtM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "Please Enter Numbers Only";
                txtM.Text = "";
            }
        }
        
    private void txtKM_KeyUp(object sender, EventArgs e)
    {
            strInput = txtKM.Text; // 將txtKM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.61);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtKM文字框清除
                txtInfo.Text = "Please Enter Numbers Only";
                txtKM.Text = "";
            }
    }
        private void txtIn_KeyUp(object sender, EventArgs e)
        {
            {
                strInput = txtIn.Text; // 將txtIn文字框的值放入strInput變數

                // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                    txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
                    txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);
                    txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.0833);
                    txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtIn文字框清除
                    txtInfo.Text = "Please Enter Numbers Only";
                    txtIn.Text = "";
                }
            }
         }
        private void txtFt_KeyUp(object sender, EventArgs e)
        {
            {
                strInput = txtFt.Text; // 將txtFt文字框的值放入strInput變數

                // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
                    txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
                    txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
                    txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);
                    txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtFt文字框清除
                    txtInfo.Text = "Please Enter Numbers Only";
                    txtFt.Text = "";
                }
            }
        }

        private void txtYard_KeyUp(object sender, EventArgs e)
        {
            strInput = txtYard.Text; // 將txtYard文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtYard文字框清除
                txtInfo.Text = "Please Enter Numbers Only";
                txtYard.Text = "";
            }
        }
           
    private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}