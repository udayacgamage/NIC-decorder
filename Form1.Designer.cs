﻿namespace IdentityDataRetrievalSystem
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
            txtNIC = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblGender = new Label();
            lblYear = new Label();
            lblMonth = new Label();
            lblDate = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 23);
            label1.TabIndex = 0;
            label1.Text = "Identity Data Retrieval System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 154);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 1;
            label2.Text = "Insert your NIC number";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(41, 211);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(198, 27);
            txtNIC.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(423, 131);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(423, 183);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 4;
            label4.Text = "Year :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(423, 233);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 5;
            label5.Text = "Month :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(423, 287);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 6;
            label6.Text = "Date :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(524, 136);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 20);
            lblGender.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(524, 188);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(0, 20);
            lblYear.TabIndex = 8;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(524, 238);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(0, 20);
            lblMonth.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(524, 292);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 20);
            lblDate.TabIndex = 10;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Violet;
            btnGenerate.Location = new Point(86, 283);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(767, 450);
            Controls.Add(btnGenerate);
            Controls.Add(lblDate);
            Controls.Add(lblMonth);
            Controls.Add(lblYear);
            Controls.Add(lblGender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNIC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNIC;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblGender;
        private Label lblYear;
        private Label lblMonth;
        private Label lblDate;
        private Button btnGenerate;
    }
}
