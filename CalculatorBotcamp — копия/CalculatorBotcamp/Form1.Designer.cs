
namespace CalculatorBotcamp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLinkCalculator = new System.Windows.Forms.LinkLabel();
            this.lblLinkCalculator3 = new System.Windows.Forms.LinkLabel();
            this.lblLinkCalculator2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl1.Location = new System.Drawing.Point(96, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(372, 114);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Добро \r\nпожаловать!";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinkCalculator
            // 
            this.lblLinkCalculator.AutoSize = true;
            this.lblLinkCalculator.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblLinkCalculator.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator.LinkColor = System.Drawing.Color.LightCoral;
            this.lblLinkCalculator.Location = new System.Drawing.Point(153, 148);
            this.lblLinkCalculator.Name = "lblLinkCalculator";
            this.lblLinkCalculator.Size = new System.Drawing.Size(255, 38);
            this.lblLinkCalculator.TabIndex = 1;
            this.lblLinkCalculator.TabStop = true;
            this.lblLinkCalculator.Text = "Калькулятор";
            this.lblLinkCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator_LinkClicked);
            // 
            // lblLinkCalculator3
            // 
            this.lblLinkCalculator3.AutoSize = true;
            this.lblLinkCalculator3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblLinkCalculator3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator3.LinkColor = System.Drawing.Color.LightCoral;
            this.lblLinkCalculator3.Location = new System.Drawing.Point(162, 336);
            this.lblLinkCalculator3.Name = "lblLinkCalculator3";
            this.lblLinkCalculator3.Size = new System.Drawing.Size(237, 114);
            this.lblLinkCalculator3.TabIndex = 2;
            this.lblLinkCalculator3.TabStop = true;
            this.lblLinkCalculator3.Text = "Решение \r\nквадратных\r\nуравнений";
            this.lblLinkCalculator3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkCalculator3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator3_LinkClicked);
            // 
            // lblLinkCalculator2
            // 
            this.lblLinkCalculator2.AutoSize = true;
            this.lblLinkCalculator2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblLinkCalculator2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator2.LinkColor = System.Drawing.Color.LightCoral;
            this.lblLinkCalculator2.Location = new System.Drawing.Point(173, 204);
            this.lblLinkCalculator2.Name = "lblLinkCalculator2";
            this.lblLinkCalculator2.Size = new System.Drawing.Size(216, 114);
            this.lblLinkCalculator2.TabIndex = 3;
            this.lblLinkCalculator2.TabStop = true;
            this.lblLinkCalculator2.Text = "Решение \r\nлинейных\r\nуравнений";
            this.lblLinkCalculator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkCalculator2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator2_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(554, 541);
            this.Controls.Add(this.lblLinkCalculator2);
            this.Controls.Add(this.lblLinkCalculator3);
            this.Controls.Add(this.lblLinkCalculator);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.LinkLabel lblLinkCalculator;
        private System.Windows.Forms.LinkLabel lblLinkCalculator3;
        private System.Windows.Forms.LinkLabel lblLinkCalculator2;
    }
}

