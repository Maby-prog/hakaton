
namespace CalculatorBotcamp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNm1 = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplay = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResault11 = new System.Windows.Forms.Label();
            this.lblResault = new System.Windows.Forms.Label();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNm2 = new System.Windows.Forms.TextBox();
            this.txtNm3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(37, 233);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.UseWaitCursor = true;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первое число:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Второе число:";
            this.label2.UseWaitCursor = true;
            // 
            // txtNm1
            // 
            this.txtNm1.Location = new System.Drawing.Point(231, 88);
            this.txtNm1.Multiline = true;
            this.txtNm1.Name = "txtNm1";
            this.txtNm1.Size = new System.Drawing.Size(180, 39);
            this.txtNm1.TabIndex = 3;
            this.txtNm1.UseWaitCursor = true;
            this.txtNm1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(131, 233);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.UseWaitCursor = true;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiplay
            // 
            this.btnMultiplay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMultiplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiplay.Location = new System.Drawing.Point(231, 233);
            this.btnMultiplay.Name = "btnMultiplay";
            this.btnMultiplay.Padding = new System.Windows.Forms.Padding(2, 15, 0, 0);
            this.btnMultiplay.Size = new System.Drawing.Size(60, 60);
            this.btnMultiplay.TabIndex = 6;
            this.btnMultiplay.Text = "*";
            this.btnMultiplay.UseVisualStyleBackColor = false;
            this.btnMultiplay.UseWaitCursor = true;
            this.btnMultiplay.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(334, 233);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.UseWaitCursor = true;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblResault11
            // 
            this.lblResault11.AutoSize = true;
            this.lblResault11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResault11.Location = new System.Drawing.Point(31, 537);
            this.lblResault11.Name = "lblResault11";
            this.lblResault11.Size = new System.Drawing.Size(206, 35);
            this.lblResault11.TabIndex = 8;
            this.lblResault11.Text = "Результат>>>";
            this.lblResault11.UseWaitCursor = true;
            // 
            // lblResault
            // 
            this.lblResault.AutoSize = true;
            this.lblResault.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResault.Location = new System.Drawing.Point(314, 537);
            this.lblResault.Name = "lblResault";
            this.lblResault.Size = new System.Drawing.Size(34, 35);
            this.lblResault.TabIndex = 9;
            this.lblResault.Text = "♥";
            this.lblResault.UseWaitCursor = true;
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new System.Drawing.Point(38, 328);
            this.btnSin.Name = "btnSin";
            this.btnSin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSin.Size = new System.Drawing.Size(122, 52);
            this.btnSin.TabIndex = 10;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.UseWaitCursor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos.Location = new System.Drawing.Point(273, 328);
            this.btnCos.Name = "btnCos";
            this.btnCos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCos.Size = new System.Drawing.Size(122, 52);
            this.btnCos.TabIndex = 11;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.UseWaitCursor = true;
            this.btnCos.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTan.Location = new System.Drawing.Point(38, 413);
            this.btnTan.Name = "btnTan";
            this.btnTan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnTan.Size = new System.Drawing.Size(122, 52);
            this.btnTan.TabIndex = 12;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.UseWaitCursor = true;
            this.btnTan.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCot
            // 
            this.btnCot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCot.Location = new System.Drawing.Point(273, 413);
            this.btnCot.Name = "btnCot";
            this.btnCot.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCot.Size = new System.Drawing.Size(122, 52);
            this.btnCot.TabIndex = 13;
            this.btnCot.Text = "cot";
            this.btnCot.UseVisualStyleBackColor = false;
            this.btnCot.UseWaitCursor = true;
            this.btnCot.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Обычный калькулятор, тригонометрический";
            this.label5.UseWaitCursor = true;
            // 
            // txtNm2
            // 
            this.txtNm2.Location = new System.Drawing.Point(231, 141);
            this.txtNm2.Multiline = true;
            this.txtNm2.Name = "txtNm2";
            this.txtNm2.Size = new System.Drawing.Size(180, 39);
            this.txtNm2.TabIndex = 4;
            this.txtNm2.UseWaitCursor = true;
            this.txtNm2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // txtNm3
            // 
            this.txtNm3.Location = new System.Drawing.Point(189, 379);
            this.txtNm3.Multiline = true;
            this.txtNm3.Name = "txtNm3";
            this.txtNm3.Size = new System.Drawing.Size(48, 49);
            this.txtNm3.TabIndex = 15;
            this.txtNm3.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(434, 631);
            this.Controls.Add(this.txtNm3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCot);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.lblResault);
            this.Controls.Add(this.lblResault11);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplay);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtNm2);
            this.Controls.Add(this.txtNm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор обычный и тригонометрический";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNm1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplay;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResault11;
        private System.Windows.Forms.Label lblResault;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNm2;
        private System.Windows.Forms.TextBox txtNm3;
    }
}