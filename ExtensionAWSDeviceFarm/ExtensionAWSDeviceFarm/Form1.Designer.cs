namespace ExtensionAWSDeviceFarm
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
            this.drpproject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgRuns = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuns)).BeginInit();
            this.SuspendLayout();
            // 
            // drpproject
            // 
            this.drpproject.FormattingEnabled = true;
            this.drpproject.Location = new System.Drawing.Point(157, 23);
            this.drpproject.Name = "drpproject";
            this.drpproject.Size = new System.Drawing.Size(121, 21);
            this.drpproject.TabIndex = 1;
            this.drpproject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Project";
            // 
            // dgRuns
            // 
            this.dgRuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRuns.Location = new System.Drawing.Point(49, 87);
            this.dgRuns.Name = "dgRuns";
            this.dgRuns.Size = new System.Drawing.Size(1165, 516);
            this.dgRuns.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Runs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgRuns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpproject);
            this.Name = "Form1";
            this.Text = "View Runs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRuns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox drpproject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRuns;
        private System.Windows.Forms.Button button1;
    }
}

