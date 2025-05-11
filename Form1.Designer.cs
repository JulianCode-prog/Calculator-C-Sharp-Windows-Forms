namespace Calculadora_Compleja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtBoxNum1 = new TextBox();
            label3 = new Label();
            TxtBoxNum2 = new TextBox();
            label4 = new Label();
            BtnMin = new Button();
            BtnPlus = new Button();
            BtnMult = new Button();
            BtnDiv = new Button();
            label7 = new Label();
            TxtBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 38);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 3;
            label1.Text = "COMPLEX CALCULATOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 81);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 4;
            label2.Text = "Number 1";
            // 
            // TxtBoxNum1
            // 
            TxtBoxNum1.Location = new Point(256, 127);
            TxtBoxNum1.Name = "TxtBoxNum1";
            TxtBoxNum1.Size = new Size(266, 23);
            TxtBoxNum1.TabIndex = 5;
            TxtBoxNum1.TextChanged += TxtBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(337, 165);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 6;
            label3.Text = "Number 2";
            // 
            // TxtBoxNum2
            // 
            TxtBoxNum2.Location = new Point(256, 208);
            TxtBoxNum2.Name = "TxtBoxNum2";
            TxtBoxNum2.Size = new Size(266, 23);
            TxtBoxNum2.TabIndex = 7;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 261);
            label4.Name = "label4";
            label4.Size = new Size(137, 30);
            label4.TabIndex = 8;
            label4.Text = "OPERATIONS";
            // 
            // BtnMin
            // 
            BtnMin.Location = new Point(256, 325);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(49, 23);
            BtnMin.TabIndex = 9;
            BtnMin.Text = "-";
            BtnMin.UseVisualStyleBackColor = true;
            BtnMin.Click += BtnMin_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(326, 325);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(49, 23);
            BtnPlus.TabIndex = 10;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // BtnMult
            // 
            BtnMult.Location = new Point(399, 325);
            BtnMult.Name = "BtnMult";
            BtnMult.Size = new Size(49, 23);
            BtnMult.TabIndex = 11;
            BtnMult.Text = "*";
            BtnMult.UseVisualStyleBackColor = true;
            BtnMult.Click += BtnMult_Click;
            // 
            // BtnDiv
            // 
            BtnDiv.Location = new Point(473, 325);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(49, 23);
            BtnDiv.TabIndex = 12;
            BtnDiv.Text = "/";
            BtnDiv.UseVisualStyleBackColor = true;
            BtnDiv.Click += BtnDiv_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(347, 366);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 19;
            label7.Text = "RESULT";
            // 
            // TxtBoxResult
            // 
            TxtBoxResult.AllowDrop = true;
            TxtBoxResult.Location = new Point(326, 389);
            TxtBoxResult.Name = "TxtBoxResult";
            TxtBoxResult.ReadOnly = true;
            TxtBoxResult.Size = new Size(100, 23);
            TxtBoxResult.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(TxtBoxResult);
            Controls.Add(label7);
            Controls.Add(BtnDiv);
            Controls.Add(BtnMult);
            Controls.Add(BtnPlus);
            Controls.Add(BtnMin);
            Controls.Add(label4);
            Controls.Add(TxtBoxNum2);
            Controls.Add(label3);
            Controls.Add(TxtBoxNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Número 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox TxtBoxNum1;
        private Label label3;
        private TextBox TxtBoxNum2;
        private Label label4;
        private Button BtnMin;
        private Button BtnPlus;
        private Button BtnMult;
        private Button BtnDiv;
        private Label label7;
        private TextBox TxtBoxResult;
    }
}
