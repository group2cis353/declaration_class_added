namespace Welcome_Page
{
    partial class Form2
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
            this.MakePanel = new System.Windows.Forms.Panel();
            this.MakeInput = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModeLInput = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plateInput = new System.Windows.Forms.TextBox();
            this.plateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.MakePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakePanel
            // 
            this.MakePanel.Controls.Add(this.MakeInput);
            this.MakePanel.Controls.Add(this.makeLabel);
            this.MakePanel.Location = new System.Drawing.Point(75, 100);
            this.MakePanel.Name = "MakePanel";
            this.MakePanel.Size = new System.Drawing.Size(800, 60);
            this.MakePanel.TabIndex = 0;
            // 
            // MakeInput
            // 
            this.MakeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeInput.Location = new System.Drawing.Point(250, 20);
            this.MakeInput.Name = "MakeInput";
            this.MakeInput.Size = new System.Drawing.Size(300, 26);
            this.MakeInput.TabIndex = 1;
            this.MakeInput.TextChanged += new System.EventHandler(this.MakeInput_TextChanged);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(90, 20);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(121, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Vehicle Make:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ModeLInput);
            this.panel2.Controls.Add(this.modelLabel);
            this.panel2.Location = new System.Drawing.Point(75, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 1;
            // 
            // ModeLInput
            // 
            this.ModeLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLInput.Location = new System.Drawing.Point(250, 20);
            this.ModeLInput.Name = "ModeLInput";
            this.ModeLInput.Size = new System.Drawing.Size(300, 26);
            this.ModeLInput.TabIndex = 1;
            this.ModeLInput.TextChanged += new System.EventHandler(this.ModeLInput_TextChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(90, 20);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(126, 20);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Vehicle Model:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plateInput);
            this.panel3.Controls.Add(this.plateLabel);
            this.panel3.Location = new System.Drawing.Point(75, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 2;
            // 
            // plateInput
            // 
            this.plateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateInput.Location = new System.Drawing.Point(250, 20);
            this.plateInput.Name = "plateInput";
            this.plateInput.Size = new System.Drawing.Size(300, 26);
            this.plateInput.TabIndex = 1;
            this.plateInput.TextChanged += new System.EventHandler(this.plateInput_TextChanged);
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateLabel.Location = new System.Drawing.Point(90, 20);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Size = new System.Drawing.Size(122, 20);
            this.plateLabel.TabIndex = 0;
            this.plateLabel.Text = "License Plate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter vehicle details:";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(250, 20);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(130, 35);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Next";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(420, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 35);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.submitBtn);
            this.btnPanel.Controls.Add(this.backBtn);
            this.btnPanel.Location = new System.Drawing.Point(75, 325);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(800, 60);
            this.btnPanel.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 451);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MakePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Vehicle Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MakePanel.ResumeLayout(false);
            this.MakePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MakePanel;
        private System.Windows.Forms.TextBox MakeInput;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ModeLInput;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox plateInput;
        private System.Windows.Forms.Label plateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel btnPanel;
    }
}