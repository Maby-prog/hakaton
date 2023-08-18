
namespace CalculatorBotcamp
{
    partial class Form4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label5 = new System.Windows.Forms.Label();
            this.txtNm4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNm5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRezultatlin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.txtNm6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Калькулятор квадратных уравнений";
            // 
            // txtNm4
            // 
            this.txtNm4.Location = new System.Drawing.Point(33, 182);
            this.txtNm4.Multiline = true;
            this.txtNm4.Name = "txtNm4";
            this.txtNm4.Size = new System.Drawing.Size(31, 39);
            this.txtNm4.TabIndex = 17;
            this.txtNm4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 63);
            this.label1.TabIndex = 18;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(123, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "+";
            // 
            // txtNm5
            // 
            this.txtNm5.Location = new System.Drawing.Point(166, 183);
            this.txtNm5.Multiline = true;
            this.txtNm5.Name = "txtNm5";
            this.txtNm5.Size = new System.Drawing.Size(29, 40);
            this.txtNm5.TabIndex = 21;
            this.txtNm5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(201, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 63);
            this.label4.TabIndex = 22;
            this.label4.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(354, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 63);
            this.label6.TabIndex = 23;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(323, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 39);
            this.label7.TabIndex = 24;
            this.label7.Text = "=";
            // 
            // lblRezultatlin
            // 
            this.lblRezultatlin.AutoSize = true;
            this.lblRezultatlin.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRezultatlin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRezultatlin.Location = new System.Drawing.Point(27, 461);
            this.lblRezultatlin.Name = "lblRezultatlin";
            this.lblRezultatlin.Size = new System.Drawing.Size(206, 35);
            this.lblRezultatlin.TabIndex = 25;
            this.lblRezultatlin.Text = "Результат>>>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(320, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 35);
            this.label9.TabIndex = 26;
            this.label9.Text = "♥";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(86, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 40);
            this.label12.TabIndex = 39;
            this.label12.Text = "Формула квадратных уравнений:\r\nax  +bx + c = 0\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(186, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 9);
            this.label13.TabIndex = 40;
            this.label13.Text = "2";
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRes.Location = new System.Drawing.Point(146, 400);
            this.btnRes.Name = "btnRes";
            this.btnRes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRes.Size = new System.Drawing.Size(136, 47);
            this.btnRes.TabIndex = 41;
            this.btnRes.Text = "Х равен:";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.UseWaitCursor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // txtNm6
            // 
            this.txtNm6.Location = new System.Drawing.Point(288, 182);
            this.txtNm6.Multiline = true;
            this.txtNm6.Name = "txtNm6";
            this.txtNm6.Size = new System.Drawing.Size(29, 40);
            this.txtNm6.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(254, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 39);
            this.label8.TabIndex = 43;
            this.label8.Text = "-";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 631);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNm6);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRezultatlin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNm5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNm4);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Калькулятор квадратных уравнений";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNm4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNm5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRezultatlin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox txtNm6;
        private System.Windows.Forms.Label label8;
    }
}

