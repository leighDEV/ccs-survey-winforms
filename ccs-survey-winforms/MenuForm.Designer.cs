namespace ccs_survey_winforms
{
    partial class MenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAnswerSurvey = new System.Windows.Forms.Button();
            this.btnShowCurrentStatistics = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 71);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Survey on CCS\'s Freshman Students\' Mental Well-being";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnswerSurvey
            // 
            this.btnAnswerSurvey.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerSurvey.Location = new System.Drawing.Point(42, 109);
            this.btnAnswerSurvey.Name = "btnAnswerSurvey";
            this.btnAnswerSurvey.Size = new System.Drawing.Size(285, 40);
            this.btnAnswerSurvey.TabIndex = 1;
            this.btnAnswerSurvey.Text = "Answer Survey";
            this.btnAnswerSurvey.UseVisualStyleBackColor = true;
            this.btnAnswerSurvey.Click += new System.EventHandler(this.btnAnswerSurvey_Click);
            // 
            // btnShowCurrentStatistics
            // 
            this.btnShowCurrentStatistics.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCurrentStatistics.Location = new System.Drawing.Point(42, 155);
            this.btnShowCurrentStatistics.Name = "btnShowCurrentStatistics";
            this.btnShowCurrentStatistics.Size = new System.Drawing.Size(285, 40);
            this.btnShowCurrentStatistics.TabIndex = 1;
            this.btnShowCurrentStatistics.Text = "Show Current Statistics";
            this.btnShowCurrentStatistics.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(42, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(285, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(38, 274);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(157, 20);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Developed by leighDEV";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 303);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowCurrentStatistics);
            this.Controls.Add(this.btnAnswerSurvey);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAnswerSurvey;
        private System.Windows.Forms.Button btnShowCurrentStatistics;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeveloper;
    }
}