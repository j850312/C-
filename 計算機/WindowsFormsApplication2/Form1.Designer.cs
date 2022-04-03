namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_equal = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(39, 242);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 23);
            this.btn_equal.TabIndex = 1;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(39, 161);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 23);
            this.number4.TabIndex = 2;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(39, 121);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 23);
            this.number7.TabIndex = 3;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 26F);
            this.textBox1.Location = new System.Drawing.Point(39, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 49);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(39, 200);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 23);
            this.number1.TabIndex = 5;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(379, 121);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 6;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(155, 121);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 23);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(271, 161);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 23);
            this.number6.TabIndex = 8;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(271, 121);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 23);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(155, 161);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 23);
            this.number5.TabIndex = 10;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(379, 242);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.btn_clear.Location = new System.Drawing.Point(271, 242);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(155, 242);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 23);
            this.number0.TabIndex = 13;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(379, 200);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 14;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(379, 161);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 23);
            this.btn_mult.TabIndex = 15;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(155, 200);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 23);
            this.number2.TabIndex = 16;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(271, 200);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 23);
            this.number3.TabIndex = 17;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.btn_equal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
    }
}

