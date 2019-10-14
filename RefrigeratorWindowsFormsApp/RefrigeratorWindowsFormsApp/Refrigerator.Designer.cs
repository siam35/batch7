namespace RefrigeratorWindowsFormsApp
{
    partial class Refrigerator
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
            this.label5 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.maxweightTextBox = new System.Windows.Forms.TextBox();
            this.noofitemTextBox = new System.Windows.Forms.TextBox();
            this.currentweightTextBox = new System.Windows.Forms.TextBox();
            this.remainingweightTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum weight it can take";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "current (weight)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "weight(kg/unit)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "remaining (weight)";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(445, 93);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 1;
            // 
            // maxweightTextBox
            // 
            this.maxweightTextBox.Location = new System.Drawing.Point(197, 47);
            this.maxweightTextBox.Name = "maxweightTextBox";
            this.maxweightTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxweightTextBox.TabIndex = 1;
            // 
            // noofitemTextBox
            // 
            this.noofitemTextBox.Location = new System.Drawing.Point(197, 93);
            this.noofitemTextBox.Name = "noofitemTextBox";
            this.noofitemTextBox.Size = new System.Drawing.Size(100, 20);
            this.noofitemTextBox.TabIndex = 1;
            // 
            // currentweightTextBox
            // 
            this.currentweightTextBox.Location = new System.Drawing.Point(197, 184);
            this.currentweightTextBox.Name = "currentweightTextBox";
            this.currentweightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentweightTextBox.TabIndex = 1;
            // 
            // remainingweightTextBox
            // 
            this.remainingweightTextBox.Location = new System.Drawing.Point(445, 184);
            this.remainingweightTextBox.Name = "remainingweightTextBox";
            this.remainingweightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingweightTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(608, 93);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(338, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Refrigerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.maxweightTextBox);
            this.Controls.Add(this.remainingweightTextBox);
            this.Controls.Add(this.currentweightTextBox);
            this.Controls.Add(this.noofitemTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Refrigerator";
            this.Text = "Refrigerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox maxweightTextBox;
        private System.Windows.Forms.TextBox noofitemTextBox;
        private System.Windows.Forms.TextBox currentweightTextBox;
        private System.Windows.Forms.TextBox remainingweightTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
    }
}

