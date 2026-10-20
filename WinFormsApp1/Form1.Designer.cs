namespace WinFormsApp1
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            btnmax = new Button();
            btnpower = new Button();
            btnISprime = new Button();
            btnfactorial = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(362, 80);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(362, 167);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 86);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "First number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 173);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 3;
            label2.Text = "Second number";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(362, 248);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // btnmax
            // 
            btnmax.Location = new Point(50, 48);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(112, 34);
            btnmax.TabIndex = 5;
            btnmax.Text = "max";
            btnmax.UseVisualStyleBackColor = true;
            btnmax.Click += btnmax_Click;
            // 
            // btnpower
            // 
            btnpower.Location = new Point(50, 167);
            btnpower.Name = "btnpower";
            btnpower.Size = new Size(112, 34);
            btnpower.TabIndex = 6;
            btnpower.Text = "power";
            btnpower.UseVisualStyleBackColor = true;
            // 
            // btnISprime
            // 
            btnISprime.Location = new Point(50, 110);
            btnISprime.Name = "btnISprime";
            btnISprime.Size = new Size(112, 34);
            btnISprime.TabIndex = 7;
            btnISprime.Text = "ISprime";
            btnISprime.UseVisualStyleBackColor = true;
            // 
            // btnfactorial
            // 
            btnfactorial.Location = new Point(50, 239);
            btnfactorial.Name = "btnfactorial";
            btnfactorial.Size = new Size(112, 34);
            btnfactorial.TabIndex = 8;
            btnfactorial.Text = "factorial";
            btnfactorial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 450);
            Controls.Add(btnfactorial);
            Controls.Add(btnISprime);
            Controls.Add(btnpower);
            Controls.Add(btnmax);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Button btnmax;
        private Button btnpower;
        private Button btnISprime;
        private Button btnfactorial;
    }
}
