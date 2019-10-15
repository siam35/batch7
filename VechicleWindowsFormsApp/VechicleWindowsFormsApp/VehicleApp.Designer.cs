namespace VechicleWindowsFormsApp
{
    partial class VehicleApp
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regnoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minspeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.averagespeedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maxspeedTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(225, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "speed";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(352, 159);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reg no";
            // 
            // regnoTextBox
            // 
            this.regnoTextBox.Location = new System.Drawing.Point(225, 77);
            this.regnoTextBox.Name = "regnoTextBox";
            this.regnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regnoTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min speed";
            // 
            // minspeedTextBox
            // 
            this.minspeedTextBox.Location = new System.Drawing.Point(262, 225);
            this.minspeedTextBox.Name = "minspeedTextBox";
            this.minspeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.minspeedTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Average Speed";
            // 
            // averagespeedTextBox
            // 
            this.averagespeedTextBox.Location = new System.Drawing.Point(262, 304);
            this.averagespeedTextBox.Name = "averagespeedTextBox";
            this.averagespeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.averagespeedTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max Speed";
            // 
            // maxspeedTextBox
            // 
            this.maxspeedTextBox.Location = new System.Drawing.Point(262, 264);
            this.maxspeedTextBox.Name = "maxspeedTextBox";
            this.maxspeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxspeedTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(377, 77);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Save";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(504, 159);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Enter";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(495, 264);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(75, 23);
            this.sButton.TabIndex = 3;
            this.sButton.Text = "Show";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // VehicleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.regnoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxspeedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.averagespeedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minspeedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "VehicleApp";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regnoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minspeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox averagespeedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxspeedTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button sButton;
    }
}

