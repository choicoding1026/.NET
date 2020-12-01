using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculation
{
    public partial class MainForm : Form
    {
        public CalManager m_Manager;

        public string savedValue = string.Empty;
        public double memory = 0;
        public int i = 0;
        public bool opFlag = false;
        public bool memFlag = false;
        public string recentBtn = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            txtResultBox.Text = "0";
            btnMC.Enabled = false;
            btnMR.Enabled = false;

            m_Manager = new CalManager();
        }

        public void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            // 연산 후 초기화
            if (recentBtn == "=")
            {
                txtResultBox.Text = "0";
                txtExpBox.Text = string.Empty;
                recentBtn = string.Empty;
            }
            
            if (txtResultBox.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResultBox.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
            {
                txtResultBox.Text = txtResultBox.Text + btn.Text;
                savedValue += btn.Text;
            }
     
            /// 3자리마다 콤마 삽입            
            double v = double.Parse(txtResultBox.Text);
            txtResultBox.Text = commaProcedure(v, txtResultBox.Text);

            recentBtn = btn.Text;

        }

        public void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // 연산 후 초기화하지 않고 추가 연산
            if (recentBtn == "=")
            {
                txtExpBox.Text = string.Empty;
                recentBtn = string.Empty;
            }

            // 연산자 중복 입력 방지
            if (recentBtn == "+" || recentBtn == "-" || recentBtn == "×" || recentBtn == "÷")
            {
                return;
            }

            txtExpBox.Text += txtResultBox.Text;
            txtExpBox.Text += btn.Text;

            txtResultBox.Text = string.Empty;
            savedValue = string.Empty;

            recentBtn = btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // 연산 후 초기화
            if (recentBtn == "=")
            {
                txtResultBox.Text = "0";
                txtExpBox.Text = string.Empty;
                recentBtn = string.Empty;
            }

            if (txtResultBox.Text.Contains("."))
            {
                return;
            }
            else
            {
                txtResultBox.Text += ".";
                savedValue += ".";
            }

            recentBtn = btn.Text;
        }

        // = 버튼, 계산 수행하게 됨
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // 연산자 중복 입력 방지
            if (recentBtn == "=")
            {
                return;
            }

            string exp = this.txtExpBox.Text;
            string rst = this.txtResultBox.Text;
            string data = exp + rst;

            txtExpBox.Text += txtResultBox.Text;
            txtExpBox.Text += btn.Text;

            decimal result = 0;
            result = m_Manager.start(data);
            this.txtResultBox.Text = result.ToString();
 
            // 3자리마다 ,
            double v = double.Parse(txtResultBox.Text);
            txtResultBox.Text = commaProcedure(v, txtResultBox.Text);

            txtExpBox.Text += txtResultBox.Text;

            recentBtn = btn.Text;
        }

        // 초기화
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultBox.Text = "0";
            txtExpBox.Text = string.Empty;
            savedValue = string.Empty;
            opFlag = false;

            Button btn = sender as Button;
            recentBtn = btn.Text;
        }

        // 맨 뒤의 한 글자를 지우기
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // = 버튼 후 결과값 삭제 방지
            if (recentBtn == "=")
            {
                return;
            }

            if (txtResultBox.Text == string.Empty || txtResultBox.Text == "0")
            {
                return;
            }
            else
            {
                txtResultBox.Text = txtResultBox.Text.Remove(txtResultBox.Text.Length - 1);

                if (txtResultBox.Text.Length == 0)
                {
                    txtResultBox.Text = "0";
                }
            }

            // txtResultBox의 숫자를 지우기 때문에 연산자로 인식
            recentBtn = "+";
        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            // 연산 후 초기화
            if (recentBtn == "=")
            {
                txtResultBox.Text = "0";
                txtExpBox.Text = string.Empty;
                recentBtn = string.Empty;
            }

            Button btn = (Button)sender;

            txtResultBox.Text = btn.Text;
            txtExpBox.Text += btn.Text;

            txtResultBox.Text = string.Empty;
            savedValue = string.Empty;

            recentBtn = btn.Text;
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            string source = txtExpBox.Text;
            int count = source.Replace("(", "").Length - source.Replace(")", "").Length;

            if (count >= 0)
            {
                return;
            }
            else
            {
                Button btn = (Button)sender;

                txtExpBox.Text += txtResultBox.Text;
                txtExpBox.Text += btn.Text;

                txtResultBox.Text = string.Empty;
                savedValue = string.Empty;

                recentBtn = btn.Text;
            }
        }

        // Memory Save
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(txtResultBox.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memFlag = true;

            Button btn = (Button)sender;
            recentBtn = btn.Text;
        }

        // Memory Read
        private void btnMR_Click(object sender, EventArgs e)
        {
            if (memory < 0)
            {
                txtResultBox.Text = "(0" + memory.ToString() + ")";
            }
            else
            {
                txtResultBox.Text = memory.ToString();
            }
            memFlag = true;

            Button btn = (Button)sender;
            recentBtn = btn.Text;
        }

        // Memory Clear
        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;

            Button btn = (Button)sender;
            recentBtn = btn.Text;
        }

        // M+
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory = memory + double.Parse(txtResultBox.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            txtResultBox.Text = "0";

            Button btn = (Button)sender;
            recentBtn = btn.Text;
        }

        // M-
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memory = memory - double.Parse(txtResultBox.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            txtResultBox.Text = "0";

            Button btn = (Button)sender;
            recentBtn = btn.Text;
        }

        public string commaProcedure(double v, string s)
        {
            int pos = 0;
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');    // 소수점 아래 자리수 + 1
                if (pos == 1)   // 맨 뒤에 소수점이 있으면 그대로 리턴
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
            {
                s = string.Format("{0:N0}", v);
            }
            return s;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
