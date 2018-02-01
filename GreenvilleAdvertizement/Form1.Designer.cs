namespace GreenvilleAdvertizement
{
    partial class greenvilleAdvertisement
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
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.firsNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(107, 47);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 20);
            this.firstNameInput.TabIndex = 0;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(107, 73);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 143);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // firsNameLabel
            // 
            this.firsNameLabel.AutoSize = true;
            this.firsNameLabel.Location = new System.Drawing.Point(43, 50);
            this.firsNameLabel.Name = "firsNameLabel";
            this.firsNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firsNameLabel.TabIndex = 4;
            this.firsNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // greenvilleAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firsNameLabel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Name = "greenvilleAdvertisement";
            this.Text = "Greenville Advertisement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label firsNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
    }
}

