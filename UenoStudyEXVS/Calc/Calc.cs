using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private enum CalcType : short
        {
            plus,
            minus,
            multiplication,
            division
        }
        
        private void Calc_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeForm();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "アプリケーションエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if(btn.Name == this.plus.Name)
                {
                    this.plusResult.Text = Run(this.textBox1.Text, this.textBox2.Text, CalcType.plus).ToString("#,##0.###");
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message, "変換エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "アプリケーションエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeForm()
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
        }
        
        private double Run(string val1, string val2, CalcType type)
        {
            double dVal1, dVal2, result = 0;
            if (!double.TryParse(val1, out dVal1))
            {
                throw new InvalidCastException("引数１を数値に変換出来ません。");
            }
            if (!double.TryParse(val2, out dVal2))
            {
                throw new InvalidCastException("引数２を数値に変換出来ません。");
            }

            switch (type)
            {
                case CalcType.plus:
                    result = dVal1 + dVal2;
                    break;
            }
            return result;
        }

        private bool LeapYearCheck(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }

            return false;
        }
    }
}
