namespace RealTimeImitator
{
    partial class MainForm
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
            this.buttonSendQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuery = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSendQuery
            // 
            this.buttonSendQuery.Location = new System.Drawing.Point(79, 76);
            this.buttonSendQuery.Name = "buttonSendQuery";
            this.buttonSendQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonSendQuery.TabIndex = 0;
            this.buttonSendQuery.Text = "Send query";
            this.buttonSendQuery.UseVisualStyleBackColor = true;
            this.buttonSendQuery.Click += new System.EventHandler(this.buttonSendQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CQG query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status: ";
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Location = new System.Drawing.Point(77, 38);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(41, 13);
            this.labelQuery.TabIndex = 5;
            this.labelQuery.Text = "Default";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(76, 128);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Default";
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Items.AddRange(new object[] {
            "Realtime1",
            "Realtime2",
            "Realtime3",
            "Realtime4",
            "Realtime5"});
            this.comboBoxNames.Location = new System.Drawing.Point(79, 6);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNames.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 173);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendQuery);
            this.Name = "MainForm";
            this.Text = "RealTime Imitator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxNames;
    }
}

