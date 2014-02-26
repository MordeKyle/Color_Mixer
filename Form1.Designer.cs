namespace Color_Mixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstColorGroupBox = new System.Windows.Forms.GroupBox();
            this.secondColorGroupBox = new System.Windows.Forms.GroupBox();
            this.firstRadRed = new System.Windows.Forms.RadioButton();
            this.firstRadBlue = new System.Windows.Forms.RadioButton();
            this.firstRadYellow = new System.Windows.Forms.RadioButton();
            this.secondRadRed = new System.Windows.Forms.RadioButton();
            this.secondRadBlue = new System.Windows.Forms.RadioButton();
            this.secondRadYellow = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColorGroupBox.SuspendLayout();
            this.secondColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorGroupBox
            // 
            this.firstColorGroupBox.Controls.Add(this.firstRadYellow);
            this.firstColorGroupBox.Controls.Add(this.firstRadBlue);
            this.firstColorGroupBox.Controls.Add(this.firstRadRed);
            this.firstColorGroupBox.Location = new System.Drawing.Point(22, 12);
            this.firstColorGroupBox.Name = "firstColorGroupBox";
            this.firstColorGroupBox.Size = new System.Drawing.Size(125, 100);
            this.firstColorGroupBox.TabIndex = 0;
            this.firstColorGroupBox.TabStop = false;
            this.firstColorGroupBox.Text = "First Color";
            // 
            // secondColorGroupBox
            // 
            this.secondColorGroupBox.Controls.Add(this.secondRadRed);
            this.secondColorGroupBox.Controls.Add(this.secondRadBlue);
            this.secondColorGroupBox.Controls.Add(this.secondRadYellow);
            this.secondColorGroupBox.Location = new System.Drawing.Point(187, 12);
            this.secondColorGroupBox.Name = "secondColorGroupBox";
            this.secondColorGroupBox.Size = new System.Drawing.Size(125, 100);
            this.secondColorGroupBox.TabIndex = 0;
            this.secondColorGroupBox.TabStop = false;
            this.secondColorGroupBox.Text = "Second Color";
            // 
            // firstRadRed
            // 
            this.firstRadRed.AutoSize = true;
            this.firstRadRed.Location = new System.Drawing.Point(6, 19);
            this.firstRadRed.Name = "firstRadRed";
            this.firstRadRed.Size = new System.Drawing.Size(45, 17);
            this.firstRadRed.TabIndex = 0;
            this.firstRadRed.Text = "Red";
            this.firstRadRed.UseVisualStyleBackColor = true;
            this.firstRadRed.CheckedChanged += new System.EventHandler(this.firstRadRed_CheckedChanged);
            // 
            // firstRadBlue
            // 
            this.firstRadBlue.AutoSize = true;
            this.firstRadBlue.Location = new System.Drawing.Point(6, 42);
            this.firstRadBlue.Name = "firstRadBlue";
            this.firstRadBlue.Size = new System.Drawing.Size(46, 17);
            this.firstRadBlue.TabIndex = 1;
            this.firstRadBlue.Text = "Blue";
            this.firstRadBlue.UseVisualStyleBackColor = true;
            this.firstRadBlue.CheckedChanged += new System.EventHandler(this.firstRadBlue_CheckedChanged);
            // 
            // firstRadYellow
            // 
            this.firstRadYellow.AutoSize = true;
            this.firstRadYellow.Location = new System.Drawing.Point(6, 65);
            this.firstRadYellow.Name = "firstRadYellow";
            this.firstRadYellow.Size = new System.Drawing.Size(56, 17);
            this.firstRadYellow.TabIndex = 2;
            this.firstRadYellow.Text = "Yellow";
            this.firstRadYellow.UseVisualStyleBackColor = true;
            this.firstRadYellow.CheckedChanged += new System.EventHandler(this.firstRadYellow_CheckedChanged);
            // 
            // secondRadRed
            // 
            this.secondRadRed.AutoSize = true;
            this.secondRadRed.Location = new System.Drawing.Point(6, 19);
            this.secondRadRed.Name = "secondRadRed";
            this.secondRadRed.Size = new System.Drawing.Size(45, 17);
            this.secondRadRed.TabIndex = 3;
            this.secondRadRed.Text = "Red";
            this.secondRadRed.UseVisualStyleBackColor = true;
            this.secondRadRed.CheckedChanged += new System.EventHandler(this.secondRadRed_CheckedChanged);
            // 
            // secondRadBlue
            // 
            this.secondRadBlue.AutoSize = true;
            this.secondRadBlue.Location = new System.Drawing.Point(6, 42);
            this.secondRadBlue.Name = "secondRadBlue";
            this.secondRadBlue.Size = new System.Drawing.Size(46, 17);
            this.secondRadBlue.TabIndex = 4;
            this.secondRadBlue.Text = "Blue";
            this.secondRadBlue.UseVisualStyleBackColor = true;
            this.secondRadBlue.CheckedChanged += new System.EventHandler(this.secondRadBlue_CheckedChanged);
            // 
            // secondRadYellow
            // 
            this.secondRadYellow.AutoSize = true;
            this.secondRadYellow.Location = new System.Drawing.Point(6, 65);
            this.secondRadYellow.Name = "secondRadYellow";
            this.secondRadYellow.Size = new System.Drawing.Size(56, 17);
            this.secondRadYellow.TabIndex = 5;
            this.secondRadYellow.Text = "Yellow";
            this.secondRadYellow.UseVisualStyleBackColor = true;
            this.secondRadYellow.CheckedChanged += new System.EventHandler(this.secondRadYellow_CheckedChanged);
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(72, 157);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 6;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.secondColorGroupBox);
            this.Controls.Add(this.firstColorGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.firstColorGroupBox.ResumeLayout(false);
            this.firstColorGroupBox.PerformLayout();
            this.secondColorGroupBox.ResumeLayout(false);
            this.secondColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorGroupBox;
        private System.Windows.Forms.GroupBox secondColorGroupBox;
        private System.Windows.Forms.RadioButton firstRadYellow;
        private System.Windows.Forms.RadioButton firstRadBlue;
        private System.Windows.Forms.RadioButton firstRadRed;
        private System.Windows.Forms.RadioButton secondRadRed;
        private System.Windows.Forms.RadioButton secondRadBlue;
        private System.Windows.Forms.RadioButton secondRadYellow;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

