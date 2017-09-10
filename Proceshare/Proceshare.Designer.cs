namespace Proceshare
{
    partial class ProceshareForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.EndCalculate = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.LabelReward = new System.Windows.Forms.Label();
            this.LabelRewardCount = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.LabelRewardCount);
            this.mainPanel.Controls.Add(this.LabelReward);
            this.mainPanel.Controls.Add(this.EndCalculate);
            this.mainPanel.Controls.Add(this.calculate);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(460, 374);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // EndCalculate
            // 
            this.EndCalculate.Location = new System.Drawing.Point(248, 265);
            this.EndCalculate.Name = "EndCalculate";
            this.EndCalculate.Size = new System.Drawing.Size(163, 63);
            this.EndCalculate.TabIndex = 2;
            this.EndCalculate.Text = "Stop calculating";
            this.EndCalculate.UseVisualStyleBackColor = true;
            this.EndCalculate.Click += new System.EventHandler(this.EndCalculate_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(33, 265);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(183, 63);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Start calculating";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // LabelReward
            // 
            this.LabelReward.AutoSize = true;
            this.LabelReward.Location = new System.Drawing.Point(311, 68);
            this.LabelReward.Name = "LabelReward";
            this.LabelReward.Size = new System.Drawing.Size(47, 13);
            this.LabelReward.TabIndex = 3;
            this.LabelReward.Text = "Reward:";
            // 
            // LabelRewardCount
            // 
            this.LabelRewardCount.AutoSize = true;
            this.LabelRewardCount.Location = new System.Drawing.Point(376, 68);
            this.LabelRewardCount.Name = "LabelRewardCount";
            this.LabelRewardCount.Size = new System.Drawing.Size(13, 13);
            this.LabelRewardCount.TabIndex = 4;
            this.LabelRewardCount.Text = "0";
            // 
            // ProceshareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 370);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProceshareForm";
            this.Text = "Proceshare";
            this.Load += new System.EventHandler(this.ProceshareForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button EndCalculate;
        private System.Windows.Forms.Label LabelReward;
        private System.Windows.Forms.Label LabelRewardCount;
    }
}

