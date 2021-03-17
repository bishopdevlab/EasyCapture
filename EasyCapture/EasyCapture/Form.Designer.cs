
namespace EasyCapture
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Capture = new System.Windows.Forms.Button();
            this.numericFileName = new System.Windows.Forms.NumericUpDown();
            this.ScreenAll = new System.Windows.Forms.RadioButton();
            this.ScreenPrimary = new System.Windows.Forms.RadioButton();
            this.ScreenSecondary = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericFileName)).BeginInit();
            this.SuspendLayout();
            // 
            // Capture
            // 
            this.Capture.Location = new System.Drawing.Point(242, 9);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(70, 23);
            this.Capture.TabIndex = 0;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // numericFileName
            // 
            this.numericFileName.Location = new System.Drawing.Point(146, 9);
            this.numericFileName.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericFileName.Name = "numericFileName";
            this.numericFileName.Size = new System.Drawing.Size(90, 21);
            this.numericFileName.TabIndex = 1;
            // 
            // ScreenAll
            // 
            this.ScreenAll.AutoSize = true;
            this.ScreenAll.Enabled = false;
            this.ScreenAll.Location = new System.Drawing.Point(11, 12);
            this.ScreenAll.Name = "ScreenAll";
            this.ScreenAll.Size = new System.Drawing.Size(37, 16);
            this.ScreenAll.TabIndex = 2;
            this.ScreenAll.Text = "All";
            this.ScreenAll.UseVisualStyleBackColor = true;
            this.ScreenAll.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // ScreenPrimary
            // 
            this.ScreenPrimary.AutoSize = true;
            this.ScreenPrimary.Checked = true;
            this.ScreenPrimary.Location = new System.Drawing.Point(54, 12);
            this.ScreenPrimary.Name = "ScreenPrimary";
            this.ScreenPrimary.Size = new System.Drawing.Size(31, 16);
            this.ScreenPrimary.TabIndex = 3;
            this.ScreenPrimary.TabStop = true;
            this.ScreenPrimary.Text = "P";
            this.ScreenPrimary.UseVisualStyleBackColor = true;
            this.ScreenPrimary.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // ScreenSecondary
            // 
            this.ScreenSecondary.AutoSize = true;
            this.ScreenSecondary.Location = new System.Drawing.Point(91, 12);
            this.ScreenSecondary.Name = "ScreenSecondary";
            this.ScreenSecondary.Size = new System.Drawing.Size(31, 16);
            this.ScreenSecondary.TabIndex = 4;
            this.ScreenSecondary.Text = "S";
            this.ScreenSecondary.UseVisualStyleBackColor = true;
            this.ScreenSecondary.CheckedChanged += new System.EventHandler(this.Screen_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 41);
            this.Controls.Add(this.ScreenSecondary);
            this.Controls.Add(this.ScreenPrimary);
            this.Controls.Add(this.ScreenAll);
            this.Controls.Add(this.numericFileName);
            this.Controls.Add(this.Capture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "EasyCapture - Copyright by Bishop";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericFileName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Capture;
        private System.Windows.Forms.NumericUpDown numericFileName;
        private System.Windows.Forms.RadioButton ScreenAll;
        private System.Windows.Forms.RadioButton ScreenPrimary;
        private System.Windows.Forms.RadioButton ScreenSecondary;
    }
}

