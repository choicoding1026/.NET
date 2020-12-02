namespace WindowsFormsCalculation
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnMP = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtExpBox = new System.Windows.Forms.TextBox();
            this.txtResultBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRB = new System.Windows.Forms.Button();
            this.btnLB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 714);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnMS, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMM, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMP, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMR, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMC, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 43);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.White;
            this.btnMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnMS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMS.Location = new System.Drawing.Point(363, 3);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(85, 37);
            this.btnMS.TabIndex = 4;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMM
            // 
            this.btnMM.BackColor = System.Drawing.Color.White;
            this.btnMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMM.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnMM.FlatAppearance.BorderSize = 0;
            this.btnMM.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnMM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMM.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMM.Location = new System.Drawing.Point(273, 3);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(84, 37);
            this.btnMM.TabIndex = 3;
            this.btnMM.Text = "M-";
            this.btnMM.UseVisualStyleBackColor = false;
            this.btnMM.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMP
            // 
            this.btnMP.BackColor = System.Drawing.Color.White;
            this.btnMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnMP.FlatAppearance.BorderSize = 0;
            this.btnMP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnMP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMP.Location = new System.Drawing.Point(183, 3);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(84, 37);
            this.btnMP.TabIndex = 2;
            this.btnMP.Text = "M+";
            this.btnMP.UseVisualStyleBackColor = false;
            this.btnMP.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.White;
            this.btnMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMR.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnMR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMR.Location = new System.Drawing.Point(93, 3);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(84, 37);
            this.btnMR.TabIndex = 1;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.White;
            this.btnMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMC.Location = new System.Drawing.Point(3, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(84, 37);
            this.btnMC.TabIndex = 0;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtResultBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtExpBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(451, 122);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txtExpBox
            // 
            this.txtExpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpBox.BackColor = System.Drawing.Color.White;
            this.txtExpBox.Enabled = false;
            this.txtExpBox.Location = new System.Drawing.Point(3, 8);
            this.txtExpBox.Name = "txtExpBox";
            this.txtExpBox.ReadOnly = true;
            this.txtExpBox.Size = new System.Drawing.Size(445, 25);
            this.txtExpBox.TabIndex = 0;
            this.txtExpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultBox
            // 
            this.txtResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultBox.BackColor = System.Drawing.Color.White;
            this.txtResultBox.Enabled = false;
            this.txtResultBox.Font = new System.Drawing.Font("굴림", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResultBox.Location = new System.Drawing.Point(3, 39);
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.ReadOnly = true;
            this.txtResultBox.Size = new System.Drawing.Size(445, 80);
            this.txtResultBox.TabIndex = 1;
            this.txtResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnPlus, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnEqual, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnDot, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnMinus, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnMulti, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDiv, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnC, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLB, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 180);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(451, 531);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(339, 427);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(109, 101);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEqual.Location = new System.Drawing.Point(227, 427);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(106, 101);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(115, 427);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 101);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDot
            // 
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDot.Location = new System.Drawing.Point(3, 427);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(106, 101);
            this.btnDot.TabIndex = 16;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(339, 321);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(109, 100);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(227, 321);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(106, 100);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(115, 321);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(106, 100);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(3, 321);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 100);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMulti.Location = new System.Drawing.Point(339, 215);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(109, 100);
            this.btnMulti.TabIndex = 11;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(227, 215);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(106, 100);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(115, 215);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(106, 100);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(3, 215);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(106, 100);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDiv.Location = new System.Drawing.Point(339, 109);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(109, 100);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(227, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(106, 100);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(115, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(106, 100);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(3, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(106, 100);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnDel.Location = new System.Drawing.Point(339, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 100);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "←";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnC.Location = new System.Drawing.Point(227, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(106, 100);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnRB
            // 
            this.btnRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRB.FlatAppearance.BorderSize = 0;
            this.btnRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRB.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnRB.Location = new System.Drawing.Point(115, 3);
            this.btnRB.Name = "btnRB";
            this.btnRB.Size = new System.Drawing.Size(106, 100);
            this.btnRB.TabIndex = 1;
            this.btnRB.Text = ")";
            this.btnRB.UseVisualStyleBackColor = true;
            this.btnRB.Click += new System.EventHandler(this.btnRightBracket_Click);
            // 
            // btnLB
            // 
            this.btnLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLB.FlatAppearance.BorderSize = 0;
            this.btnLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLB.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLB.Location = new System.Drawing.Point(3, 3);
            this.btnLB.Name = "btnLB";
            this.btnLB.Size = new System.Drawing.Size(106, 100);
            this.btnLB.TabIndex = 0;
            this.btnLB.Text = "(";
            this.btnLB.UseVisualStyleBackColor = true;
            this.btnLB.Click += new System.EventHandler(this.btnLeftBracket_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtExpBox;
        private System.Windows.Forms.TextBox txtResultBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnRB;
        private System.Windows.Forms.Button btnLB;
    }
}

