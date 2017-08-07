using System.Drawing;

namespace ThreadingDemo
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
            this.StartThreadButton = new System.Windows.Forms.Button();
            this.ThreadResultLabel = new System.Windows.Forms.Label();
            this.TaskStartButton = new System.Windows.Forms.Button();
            this.TaskResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartThreadButton
            // 
            this.StartThreadButton.Location = new System.Drawing.Point(119, 122);
            this.StartThreadButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartThreadButton.Name = "StartThreadButton";
            this.StartThreadButton.Size = new System.Drawing.Size(100, 28);
            this.StartThreadButton.TabIndex = 0;
            this.StartThreadButton.Text = "Start Thread";
            this.StartThreadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartThreadButton.UseVisualStyleBackColor = true;
            this.StartThreadButton.Click += new System.EventHandler(this.Starthread_OnClick);
            // 
            // ThreadResultLabel
            // 
            this.ThreadResultLabel.AutoSize = true;
            this.ThreadResultLabel.Location = new System.Drawing.Point(145, 163);
            this.ThreadResultLabel.Name = "ThreadResultLabel";
            this.ThreadResultLabel.Size = new System.Drawing.Size(0, 17);
            this.ThreadResultLabel.TabIndex = 1;
            this.ThreadResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskStartButton
            // 
            this.TaskStartButton.Location = new System.Drawing.Point(119, 5);
            this.TaskStartButton.Name = "TaskStartButton";
            this.TaskStartButton.Size = new System.Drawing.Size(100, 28);
            this.TaskStartButton.TabIndex = 2;
            this.TaskStartButton.Text = "Start Task";
            this.TaskStartButton.UseVisualStyleBackColor = true;
            this.TaskStartButton.Click += new System.EventHandler(this.StartTask_OnClick);
            // 
            // TaskResultLabel
            // 
            this.TaskResultLabel.AutoSize = true;
            this.TaskResultLabel.Location = new System.Drawing.Point(145, 48);
            this.TaskResultLabel.Name = "TaskResultLabel";
            this.TaskResultLabel.Size = new System.Drawing.Size(31, 17);
            this.TaskResultLabel.TabIndex = 3;
            this.TaskResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.TaskResultLabel);
            this.Controls.Add(this.TaskStartButton);
            this.Controls.Add(this.ThreadResultLabel);
            this.Controls.Add(this.StartThreadButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Threading Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartThreadButton;
        private System.Windows.Forms.Label ThreadResultLabel;
        private System.Windows.Forms.Button TaskStartButton;
        private System.Windows.Forms.Label TaskResultLabel;
    }
}

