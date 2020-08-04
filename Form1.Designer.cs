namespace Welcome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conductSearchBtn = new System.Windows.Forms.Button();
            this.startAssessmentBtn = new System.Windows.Forms.Button();
            this.endProgramBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the border crossing duty assessor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Would you like to...";
            // 
            // conductSearchBtn
            // 
            this.conductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductSearchBtn.Location = new System.Drawing.Point(58, 283);
            this.conductSearchBtn.Name = "conductSearchBtn";
            this.conductSearchBtn.Size = new System.Drawing.Size(122, 63);
            this.conductSearchBtn.TabIndex = 3;
            this.conductSearchBtn.Text = "Conduct a search";
            this.conductSearchBtn.UseVisualStyleBackColor = true;
            this.conductSearchBtn.Click += new System.EventHandler(this.conductSearchBtn_Click);
            // 
            // startAssessmentBtn
            // 
            this.startAssessmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAssessmentBtn.Location = new System.Drawing.Point(303, 283);
            this.startAssessmentBtn.Name = "startAssessmentBtn";
            this.startAssessmentBtn.Size = new System.Drawing.Size(122, 63);
            this.startAssessmentBtn.TabIndex = 4;
            this.startAssessmentBtn.Text = "Enter a new assessment";
            this.startAssessmentBtn.UseVisualStyleBackColor = true;
            this.startAssessmentBtn.Click += new System.EventHandler(this.startAssessmentBtn_Click);
            // 
            // endProgramBtn
            // 
            this.endProgramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endProgramBtn.Location = new System.Drawing.Point(566, 283);
            this.endProgramBtn.Name = "endProgramBtn";
            this.endProgramBtn.Size = new System.Drawing.Size(122, 63);
            this.endProgramBtn.TabIndex = 5;
            this.endProgramBtn.Text = "Exit";
            this.endProgramBtn.UseVisualStyleBackColor = true;
            this.endProgramBtn.Click += new System.EventHandler(this.endProgramBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.endProgramBtn);
            this.Controls.Add(this.startAssessmentBtn);
            this.Controls.Add(this.conductSearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conductSearchBtn;
        private System.Windows.Forms.Button startAssessmentBtn;
        private System.Windows.Forms.Button endProgramBtn;
    }


}

