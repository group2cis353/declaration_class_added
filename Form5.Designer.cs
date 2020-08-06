namespace Welcome_Page
{
    partial class Form5
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
            this.declareTitle = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.RadioButton();
            this.noBtn = new System.Windows.Forms.RadioButton();
            this.declareInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.caseInvalid = new System.Windows.Forms.Label();
            this.caseTotal = new System.Windows.Forms.TextBox();
            this.caseLabel = new System.Windows.Forms.Label();
            this.declareSubmit = new System.Windows.Forms.Button();
            this.totLabel = new System.Windows.Forms.Label();
            this.displayFine = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // declareTitle
            // 
            this.declareTitle.AutoSize = true;
            this.declareTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declareTitle.Location = new System.Drawing.Point(240, 40);
            this.declareTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.declareTitle.Name = "declareTitle";
            this.declareTitle.Size = new System.Drawing.Size(336, 25);
            this.declareTitle.TabIndex = 0;
            this.declareTitle.Text = "Any Cases of Beer to Declare?";
            // 
            // yesBtn
            // 
            this.yesBtn.AutoSize = true;
            this.yesBtn.Location = new System.Drawing.Point(301, 105);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(55, 24);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.TabStop = true;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.CheckedChanged += new System.EventHandler(this.yesBtn_CheckedChanged);
            // 
            // noBtn
            // 
            this.noBtn.AutoSize = true;
            this.noBtn.Location = new System.Drawing.Point(457, 105);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(47, 24);
            this.noBtn.TabIndex = 2;
            this.noBtn.TabStop = true;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.CheckedChanged += new System.EventHandler(this.noBtn_CheckedChanged);
            // 
            // declareInfo
            // 
            this.declareInfo.AutoSize = true;
            this.declareInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declareInfo.Location = new System.Drawing.Point(284, 132);
            this.declareInfo.Name = "declareInfo";
            this.declareInfo.Size = new System.Drawing.Size(230, 16);
            this.declareInfo.TabIndex = 3;
            this.declareInfo.Text = "(A fee may incur on any declarations.)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.caseInvalid);
            this.panel1.Controls.Add(this.caseTotal);
            this.panel1.Controls.Add(this.caseLabel);
            this.panel1.Location = new System.Drawing.Point(37, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 75);
            this.panel1.TabIndex = 4;
            // 
            // caseInvalid
            // 
            this.caseInvalid.AutoSize = true;
            this.caseInvalid.Location = new System.Drawing.Point(550, 28);
            this.caseInvalid.Name = "caseInvalid";
            this.caseInvalid.Size = new System.Drawing.Size(51, 20);
            this.caseInvalid.TabIndex = 2;
            this.caseInvalid.Text = "label4";
            // 
            // caseTotal
            // 
            this.caseTotal.Location = new System.Drawing.Point(375, 22);
            this.caseTotal.Name = "caseTotal";
            this.caseTotal.Size = new System.Drawing.Size(130, 26);
            this.caseTotal.TabIndex = 1;
            this.caseTotal.TextChanged += new System.EventHandler(this.caseTotal_TextChanged);
            this.caseTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            // 
            // caseLabel
            // 
            this.caseLabel.AutoSize = true;
            this.caseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseLabel.Location = new System.Drawing.Point(80, 28);
            this.caseLabel.Name = "caseLabel";
            this.caseLabel.Size = new System.Drawing.Size(290, 20);
            this.caseLabel.TabIndex = 0;
            this.caseLabel.Text = "Enter total number of case of beer:";
            // 
            // declareSubmit
            // 
            this.declareSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declareSubmit.Location = new System.Drawing.Point(133, 334);
            this.declareSubmit.Name = "declareSubmit";
            this.declareSubmit.Size = new System.Drawing.Size(100, 45);
            this.declareSubmit.TabIndex = 5;
            this.declareSubmit.Text = "Submit";
            this.declareSubmit.UseVisualStyleBackColor = true;
            this.declareSubmit.Click += new System.EventHandler(this.declareSubmit_Click);
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.Location = new System.Drawing.Point(241, 262);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(210, 20);
            this.totLabel.TabIndex = 6;
            this.totLabel.Text = "Total Duty Fee Required:";
            // 
            // displayFine
            // 
            this.displayFine.AutoSize = true;
            this.displayFine.Location = new System.Drawing.Point(483, 262);
            this.displayFine.Name = "displayFine";
            this.displayFine.Size = new System.Drawing.Size(51, 20);
            this.displayFine.TabIndex = 7;
            this.displayFine.Text = "label1";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(500, 334);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 45);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.displayFine);
            this.Controls.Add(this.totLabel);
            this.Controls.Add(this.declareSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.declareInfo);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.declareTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Declaration Details";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label declareTitle;
        private System.Windows.Forms.RadioButton yesBtn;
        private System.Windows.Forms.RadioButton noBtn;
        private System.Windows.Forms.Label declareInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox caseTotal;
        private System.Windows.Forms.Label caseLabel;
        private System.Windows.Forms.Label caseInvalid;
        private System.Windows.Forms.Button declareSubmit;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label displayFine;
        private System.Windows.Forms.Button cancelBtn;
    }
}