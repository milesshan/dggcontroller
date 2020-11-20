using System;

namespace DGG_Control
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
            this.textboxSent = new System.Windows.Forms.TextBox();
            this.textboxReceived = new System.Windows.Forms.TextBox();
            this.labelSent = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.comboboxAvailablePorts = new System.Windows.Forms.ComboBox();
            this.labelAvailablePorts = new System.Windows.Forms.Label();
            this.textboxDelay = new System.Windows.Forms.TextBox();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.labelDelay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxSent
            // 
            this.textboxSent.Enabled = false;
            this.textboxSent.Location = new System.Drawing.Point(66, 175);
            this.textboxSent.Multiline = true;
            this.textboxSent.Name = "textboxSent";
            this.textboxSent.Size = new System.Drawing.Size(97, 78);
            this.textboxSent.TabIndex = 0;
            // 
            // textboxReceived
            // 
            this.textboxReceived.Enabled = false;
            this.textboxReceived.Location = new System.Drawing.Point(218, 175);
            this.textboxReceived.Multiline = true;
            this.textboxReceived.Name = "textboxReceived";
            this.textboxReceived.Size = new System.Drawing.Size(98, 78);
            this.textboxReceived.TabIndex = 1;
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(63, 132);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(29, 13);
            this.labelSent.TabIndex = 2;
            this.labelSent.Text = "Sent";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(215, 132);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(53, 13);
            this.labelReceived.TabIndex = 3;
            this.labelReceived.Text = "Received";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(169, 79);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // comboboxAvailablePorts
            // 
            this.comboboxAvailablePorts.FormattingEnabled = true;
            this.comboboxAvailablePorts.Location = new System.Drawing.Point(66, 81);
            this.comboboxAvailablePorts.Name = "comboboxAvailablePorts";
            this.comboboxAvailablePorts.Size = new System.Drawing.Size(97, 21);
            this.comboboxAvailablePorts.TabIndex = 5;
            // 
            // labelAvailablePorts
            // 
            this.labelAvailablePorts.AutoSize = true;
            this.labelAvailablePorts.Location = new System.Drawing.Point(63, 38);
            this.labelAvailablePorts.Name = "labelAvailablePorts";
            this.labelAvailablePorts.Size = new System.Drawing.Size(76, 13);
            this.labelAvailablePorts.TabIndex = 6;
            this.labelAvailablePorts.Text = "Available ports";
            // 
            // textboxDelay
            // 
            this.textboxDelay.Location = new System.Drawing.Point(374, 81);
            this.textboxDelay.Name = "textboxDelay";
            this.textboxDelay.Size = new System.Drawing.Size(100, 20);
            this.textboxDelay.TabIndex = 7;
            this.textboxDelay.TextChanged += new System.EventHandler(this.textboxDelay_TextChanged);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(374, 107);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(100, 23);
            this.buttonCommit.TabIndex = 8;
            this.buttonCommit.Text = "Commit delay";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(354, 38);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(79, 13);
            this.labelDelay.TabIndex = 9;
            this.labelDelay.Text = "Input delay (ns)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.textboxDelay);
            this.Controls.Add(this.labelAvailablePorts);
            this.Controls.Add(this.comboboxAvailablePorts);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelSent);
            this.Controls.Add(this.textboxReceived);
            this.Controls.Add(this.textboxSent);
            this.Name = "Form1";
            this.Text = "DGG Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxSent;
        private System.Windows.Forms.TextBox textboxReceived;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ComboBox comboboxAvailablePorts;
        private System.Windows.Forms.Label labelAvailablePorts;
        private System.Windows.Forms.TextBox textboxDelay;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Label labelDelay;
    }
}

