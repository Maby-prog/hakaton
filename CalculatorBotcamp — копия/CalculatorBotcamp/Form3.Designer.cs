
namespace CalculatorBotcamp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRezultatlin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNm5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNm4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Линейный калькулятор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(26, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Результат>>>";
            // 
            // lblRezultatlin
            // 
            this.lblRezultatlin.AutoSize = true;
            this.lblRezultatlin.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRezultatlin.Location = new System.Drawing.Point(318, 498);
            this.lblRezultatlin.Name = "lblRezultatlin";
            this.lblRezultatlin.Size = new System.Drawing.Size(34, 35);
            this.lblRezultatlin.TabIndex = 21;
            this.lblRezultatlin.Text = "♥";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(251, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Второе число:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(45, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Первое число:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(204, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 39);
            this.label7.TabIndex = 35;
            this.label7.Text = "=";
            // 
            // txtNm5
            // 
            this.txtNm5.Location = new System.Drawing.Point(296, 206);
            this.txtNm5.Multiline = true;
            this.txtNm5.Name = "txtNm5";
            this.txtNm5.Size = new System.Drawing.Size(40, 40);
            this.txtNm5.TabIndex = 32;
            this.txtNm5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(109, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 63);
            this.label8.TabIndex = 30;
            this.label8.Text = "x";
            // 
            // txtNm4
            // 
            this.txtNm4.Location = new System.Drawing.Point(63, 206);
            this.txtNm4.Multiline = true;
            this.txtNm4.Name = "txtNm4";
            this.txtNm4.Size = new System.Drawing.Size(40, 40);
            this.txtNm4.TabIndex = 29;
            this.txtNm4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.txtNm4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Формула линейных уравнений:\r\nax = b\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRes.Location = new System.Drawing.Point(152, 432);
            this.btnRes.Name = "btnRes";
            this.btnRes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRes.Size = new System.Drawing.Size(136, 47);
            this.btnRes.TabIndex = 40;
            this.btnRes.Text = "Х равен:";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.UseWaitCursor = true;
            this.btnRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(434, 631);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNm5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNm4);
            this.Controls.Add(this.lblRezultatlin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Линейный калькулятор";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRezultatlin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNm5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNm4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRes;
    }
}

