
namespace OO_programming
{
    partial class Form1
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
			label2 = new System.Windows.Forms.Label();
			txtBoxHours = new System.Windows.Forms.TextBox();
			btnCalculate = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			lstBox = new System.Windows.Forms.ListBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			btnSave = new System.Windows.Forms.Button();
			txtBoxPaySummary = new System.Windows.Forms.TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(23, 263);
			label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(110, 15);
			label2.TabIndex = 2;
			label2.Text = "Hours Worked (hrs)";
			// 
			// txtBoxHours
			// 
			txtBoxHours.Location = new System.Drawing.Point(144, 257);
			txtBoxHours.Margin = new System.Windows.Forms.Padding(2);
			txtBoxHours.Name = "txtBoxHours";
			txtBoxHours.Size = new System.Drawing.Size(81, 23);
			txtBoxHours.TabIndex = 3;
			txtBoxHours.Text = "0";
			txtBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new System.Drawing.Point(184, 328);
			btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new System.Drawing.Size(79, 31);
			btnCalculate.TabIndex = 4;
			btnCalculate.Text = "Calculate";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += btnCalculate_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lstBox);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtBoxHours);
			groupBox1.Location = new System.Drawing.Point(40, 25);
			groupBox1.Margin = new System.Windows.Forms.Padding(2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(2);
			groupBox1.Size = new System.Drawing.Size(254, 355);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Employee Details";
			// 
			// lstBox
			// 
			lstBox.FormattingEnabled = true;
			lstBox.ItemHeight = 15;
			lstBox.Location = new System.Drawing.Point(26, 45);
			lstBox.Margin = new System.Windows.Forms.Padding(2);
			lstBox.Name = "lstBox";
			lstBox.Size = new System.Drawing.Size(198, 199);
			lstBox.TabIndex = 4;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnSave);
			groupBox2.Controls.Add(txtBoxPaySummary);
			groupBox2.Location = new System.Drawing.Point(352, 25);
			groupBox2.Margin = new System.Windows.Forms.Padding(2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(2);
			groupBox2.Size = new System.Drawing.Size(246, 355);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Payment Summary";
			// 
			// btnSave
			// 
			btnSave.Location = new System.Drawing.Point(159, 301);
			btnSave.Margin = new System.Windows.Forms.Padding(2);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(65, 32);
			btnSave.TabIndex = 1;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Visible = false;
			btnSave.Click += btnSave_Click;
			// 
			// txtBoxPaySummary
			// 
			txtBoxPaySummary.Location = new System.Drawing.Point(20, 40);
			txtBoxPaySummary.Margin = new System.Windows.Forms.Padding(2);
			txtBoxPaySummary.Multiline = true;
			txtBoxPaySummary.Name = "txtBoxPaySummary";
			txtBoxPaySummary.ReadOnly = true;
			txtBoxPaySummary.Size = new System.Drawing.Size(205, 238);
			txtBoxPaySummary.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(643, 422);
			Controls.Add(groupBox2);
			Controls.Add(btnCalculate);
			Controls.Add(groupBox1);
			Margin = new System.Windows.Forms.Padding(2);
			Name = "Form1";
			Text = "Weekly Payment Calculator";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxPaySummary;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnSave;
    }
}

