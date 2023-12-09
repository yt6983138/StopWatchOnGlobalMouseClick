namespace StopWatchOnGlobalMouseClick
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
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StartOrStopDetecting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TimeTextBox.Location = new System.Drawing.Point(12, 12);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(250, 44);
            this.TimeTextBox.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 62);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StartOrStopDetecting
            // 
            this.StartOrStopDetecting.Location = new System.Drawing.Point(187, 62);
            this.StartOrStopDetecting.Name = "StartOrStopDetecting";
            this.StartOrStopDetecting.Size = new System.Drawing.Size(75, 23);
            this.StartOrStopDetecting.TabIndex = 2;
            this.StartOrStopDetecting.Text = "Start Detect";
            this.StartOrStopDetecting.UseVisualStyleBackColor = true;
            this.StartOrStopDetecting.Click += new System.EventHandler(this.StartOrStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.StartOrStopDetecting);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TimeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StartOrStopDetecting;
    }
}

