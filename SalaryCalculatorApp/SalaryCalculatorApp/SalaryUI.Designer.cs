namespace SalaryCalculatorApp
{
    partial class SalaryUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.totalSalaryShowButton = new System.Windows.Forms.Button();
            this.houseRantTextBox = new System.Windows.Forms.TextBox();
            this.medicalRantTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Rant";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(144, 110);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(265, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // totalSalaryShowButton
            // 
            this.totalSalaryShowButton.Location = new System.Drawing.Point(224, 240);
            this.totalSalaryShowButton.Name = "totalSalaryShowButton";
            this.totalSalaryShowButton.Size = new System.Drawing.Size(185, 31);
            this.totalSalaryShowButton.TabIndex = 6;
            this.totalSalaryShowButton.Text = "Show Me Salary";
            this.totalSalaryShowButton.UseVisualStyleBackColor = true;
            this.totalSalaryShowButton.Click += new System.EventHandler(this.totalSalaryShowButton_Click);
            // 
            // houseRantTextBox
            // 
            this.houseRantTextBox.Location = new System.Drawing.Point(144, 158);
            this.houseRantTextBox.Name = "houseRantTextBox";
            this.houseRantTextBox.Size = new System.Drawing.Size(265, 20);
            this.houseRantTextBox.TabIndex = 7;
            // 
            // medicalRantTextBox
            // 
            this.medicalRantTextBox.Location = new System.Drawing.Point(144, 200);
            this.medicalRantTextBox.Name = "medicalRantTextBox";
            this.medicalRantTextBox.Size = new System.Drawing.Size(265, 20);
            this.medicalRantTextBox.TabIndex = 8;
            // 
            // SalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 391);
            this.Controls.Add(this.medicalRantTextBox);
            this.Controls.Add(this.houseRantTextBox);
            this.Controls.Add(this.totalSalaryShowButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryUI";
            this.Text = "SalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button totalSalaryShowButton;
        private System.Windows.Forms.TextBox houseRantTextBox;
        private System.Windows.Forms.TextBox medicalRantTextBox;
    }
}

