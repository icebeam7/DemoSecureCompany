namespace DemoSecureCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.SalaryText = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.Location = new System.Drawing.Point(225, 42);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(187, 38);
            this.LastNameText.TabIndex = 2;
            // 
            // SalaryText
            // 
            this.SalaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryText.Location = new System.Drawing.Point(225, 126);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(187, 38);
            this.SalaryText.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(483, 42);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 43);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(483, 128);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(134, 46);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota: El salario debe tener 6 enteros y 2 decimales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SalaryText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox SalaryText;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label3;
    }
}

