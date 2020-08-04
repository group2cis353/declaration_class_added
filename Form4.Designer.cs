﻿namespace Welcome_Page
{
    partial class Form4
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
            this.searchTitle = new System.Windows.Forms.Label();
            this.enterPlate = new System.Windows.Forms.Label();
            this.plateSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.backSearchBtn = new System.Windows.Forms.Button();
            this.makeSearch = new System.Windows.Forms.Label();
            this.modelSearch = new System.Windows.Forms.Label();
            this.dateSearch = new System.Windows.Forms.Label();
            this.timeSearch = new System.Windows.Forms.Label();
            this.fineSearch = new System.Windows.Forms.Label();
            this.displayMake = new System.Windows.Forms.Label();
            this.displayModel = new System.Windows.Forms.Label();
            this.displayDate = new System.Windows.Forms.Label();
            this.displayFine = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.displayTime = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(237, 30);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(341, 25);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "Welcome to the Vehicle Search";
            // 
            // enterPlate
            // 
            this.enterPlate.AutoSize = true;
            this.enterPlate.Location = new System.Drawing.Point(120, 80);
            this.enterPlate.Name = "enterPlate";
            this.enterPlate.Size = new System.Drawing.Size(294, 20);
            this.enterPlate.TabIndex = 2;
            this.enterPlate.Text = "Please enter License Plate to search for:";
            // 
            // plateSearch
            // 
            this.plateSearch.Location = new System.Drawing.Point(425, 80);
            this.plateSearch.Name = "plateSearch";
            this.plateSearch.Size = new System.Drawing.Size(150, 26);
            this.plateSearch.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(192, 380);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(135, 30);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // backSearchBtn
            // 
            this.backSearchBtn.Location = new System.Drawing.Point(457, 380);
            this.backSearchBtn.Name = "backSearchBtn";
            this.backSearchBtn.Size = new System.Drawing.Size(135, 30);
            this.backSearchBtn.TabIndex = 5;
            this.backSearchBtn.Text = "Back";
            this.backSearchBtn.UseVisualStyleBackColor = true;
            this.backSearchBtn.Click += new System.EventHandler(this.backSearchBtn_Click);
            // 
            // makeSearch
            // 
            this.makeSearch.AutoSize = true;
            this.makeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeSearch.Location = new System.Drawing.Point(14, 17);
            this.makeSearch.Name = "makeSearch";
            this.makeSearch.Size = new System.Drawing.Size(121, 20);
            this.makeSearch.TabIndex = 6;
            this.makeSearch.Text = "Vehicle Make:";
            // 
            // modelSearch
            // 
            this.modelSearch.AutoSize = true;
            this.modelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSearch.Location = new System.Drawing.Point(14, 17);
            this.modelSearch.Name = "modelSearch";
            this.modelSearch.Size = new System.Drawing.Size(126, 20);
            this.modelSearch.TabIndex = 7;
            this.modelSearch.Text = "Vehicle Model:";
            // 
            // dateSearch
            // 
            this.dateSearch.AutoSize = true;
            this.dateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch.Location = new System.Drawing.Point(14, 17);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(100, 20);
            this.dateSearch.TabIndex = 8;
            this.dateSearch.Text = "Entry Date:";
            // 
            // timeSearch
            // 
            this.timeSearch.AutoSize = true;
            this.timeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSearch.Location = new System.Drawing.Point(14, 17);
            this.timeSearch.Name = "timeSearch";
            this.timeSearch.Size = new System.Drawing.Size(99, 20);
            this.timeSearch.TabIndex = 9;
            this.timeSearch.Text = "Entry Time:";
            // 
            // fineSearch
            // 
            this.fineSearch.AutoSize = true;
            this.fineSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineSearch.Location = new System.Drawing.Point(14, 17);
            this.fineSearch.Name = "fineSearch";
            this.fineSearch.Size = new System.Drawing.Size(146, 20);
            this.fineSearch.TabIndex = 10;
            this.fineSearch.Text = "Declaration Fine:";
            // 
            // displayMake
            // 
            this.displayMake.AutoSize = true;
            this.displayMake.Location = new System.Drawing.Point(189, 17);
            this.displayMake.Name = "displayMake";
            this.displayMake.Size = new System.Drawing.Size(51, 20);
            this.displayMake.TabIndex = 11;
            this.displayMake.Text = "label6";
            // 
            // displayModel
            // 
            this.displayModel.AutoSize = true;
            this.displayModel.Location = new System.Drawing.Point(189, 17);
            this.displayModel.Name = "displayModel";
            this.displayModel.Size = new System.Drawing.Size(51, 20);
            this.displayModel.TabIndex = 12;
            this.displayModel.Text = "label7";
            // 
            // displayDate
            // 
            this.displayDate.AutoSize = true;
            this.displayDate.Location = new System.Drawing.Point(189, 17);
            this.displayDate.Name = "displayDate";
            this.displayDate.Size = new System.Drawing.Size(51, 20);
            this.displayDate.TabIndex = 13;
            this.displayDate.Text = "label8";
            // 
            // displayFine
            // 
            this.displayFine.AutoSize = true;
            this.displayFine.Location = new System.Drawing.Point(189, 17);
            this.displayFine.Name = "displayFine";
            this.displayFine.Size = new System.Drawing.Size(60, 20);
            this.displayFine.TabIndex = 15;
            this.displayFine.Text = "label10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makeSearch);
            this.groupBox1.Controls.Add(this.displayMake);
            this.groupBox1.Location = new System.Drawing.Point(192, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 48);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modelSearch);
            this.groupBox2.Controls.Add(this.displayModel);
            this.groupBox2.Location = new System.Drawing.Point(192, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 48);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateSearch);
            this.groupBox3.Controls.Add(this.displayDate);
            this.groupBox3.Location = new System.Drawing.Point(192, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 48);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.timeSearch);
            this.groupBox4.Controls.Add(this.displayTime);
            this.groupBox4.Location = new System.Drawing.Point(192, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 48);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // displayTime
            // 
            this.displayTime.AutoSize = true;
            this.displayTime.Location = new System.Drawing.Point(189, 17);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(51, 20);
            this.displayTime.TabIndex = 14;
            this.displayTime.Text = "label9";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fineSearch);
            this.groupBox5.Controls.Add(this.displayFine);
            this.groupBox5.Location = new System.Drawing.Point(192, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 48);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backSearchBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.plateSearch);
            this.Controls.Add(this.enterPlate);
            this.Controls.Add(this.searchTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Vehicle Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Label enterPlate;
        private System.Windows.Forms.TextBox plateSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button backSearchBtn;
        private System.Windows.Forms.Label makeSearch;
        private System.Windows.Forms.Label modelSearch;
        private System.Windows.Forms.Label dateSearch;
        private System.Windows.Forms.Label timeSearch;
        private System.Windows.Forms.Label fineSearch;
        private System.Windows.Forms.Label displayMake;
        private System.Windows.Forms.Label displayModel;
        private System.Windows.Forms.Label displayDate;
        private System.Windows.Forms.Label displayFine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label displayTime;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}