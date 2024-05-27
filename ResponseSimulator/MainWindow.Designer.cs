using System;

namespace ResponseSimulator
{
    partial class MainWindow
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
            this.HaltButton = new System.Windows.Forms.Button();
            this.TimeoutSetBox = new System.Windows.Forms.NumericUpDown();
            this.TimOutDesc = new System.Windows.Forms.Label();
            this.appStatusLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutSetBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HaltButton
            // 
            this.HaltButton.Location = new System.Drawing.Point(92, 56);
            this.HaltButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaltButton.Name = "HaltButton";
            this.HaltButton.Size = new System.Drawing.Size(136, 53);
            this.HaltButton.TabIndex = 0;
            this.HaltButton.Text = "Halt App";
            this.HaltButton.UseVisualStyleBackColor = true;
            this.HaltButton.Click += new System.EventHandler(this.HaltButton_Click);
            // 
            // TimeoutSetBox
            // 
            this.TimeoutSetBox.Location = new System.Drawing.Point(168, 23);
            this.TimeoutSetBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeoutSetBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TimeoutSetBox.Name = "TimeoutSetBox";
            this.TimeoutSetBox.Size = new System.Drawing.Size(80, 20);
            this.TimeoutSetBox.TabIndex = 1;
            this.TimeoutSetBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TimOutDesc
            // 
            this.TimOutDesc.AutoSize = true;
            this.TimOutDesc.Location = new System.Drawing.Point(79, 24);
            this.TimOutDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimOutDesc.Name = "TimOutDesc";
            this.TimOutDesc.Size = new System.Drawing.Size(87, 13);
            this.TimOutDesc.TabIndex = 2;
            this.TimOutDesc.Text = "Set Timeout sec:";
            // 
            // appStatusLabel
            // 
            this.appStatusLabel.AutoSize = true;
            this.appStatusLabel.Location = new System.Drawing.Point(108, 122);
            this.appStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appStatusLabel.Name = "appStatusLabel";
            this.appStatusLabel.Size = new System.Drawing.Size(115, 13);
            this.appStatusLabel.TabIndex = 3;
            this.appStatusLabel.Text = "Status: RESPONDING";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(299, 8);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(33, 20);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 155);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.appStatusLabel);
            this.Controls.Add(this.TimOutDesc);
            this.Controls.Add(this.TimeoutSetBox);
            this.Controls.Add(this.HaltButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "ResponseSimulator";
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutSetBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HaltButton;
        private System.Windows.Forms.NumericUpDown TimeoutSetBox;
        private System.Windows.Forms.Label TimOutDesc;
        private System.Windows.Forms.Label appStatusLabel;
        private System.Windows.Forms.Button InfoButton;
    }
}

