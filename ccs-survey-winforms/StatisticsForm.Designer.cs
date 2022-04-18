namespace ccs_survey_winforms
{
    partial class StatisticsForm
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
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblTotalSurveyee = new System.Windows.Forms.Label();
            this.lbl18 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblComputerScience = new System.Windows.Forms.Label();
            this.lblInformationScience = new System.Windows.Forms.Label();
            this.lblInformatinTechnology = new System.Windows.Forms.Label();
            this.lblStronlyAgree = new System.Windows.Forms.Label();
            this.lblAgree = new System.Windows.Forms.Label();
            this.lblNeutral = new System.Windows.Forms.Label();
            this.lblDisagree = new System.Windows.Forms.Label();
            this.lblStronlyDisagree = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStudentInfo.Location = new System.Drawing.Point(43, 38);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(187, 32);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Survey\'s Statistics";
            // 
            // lblTotalSurveyee
            // 
            this.lblTotalSurveyee.AutoSize = true;
            this.lblTotalSurveyee.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSurveyee.Location = new System.Drawing.Point(70, 84);
            this.lblTotalSurveyee.Name = "lblTotalSurveyee";
            this.lblTotalSurveyee.Size = new System.Drawing.Size(238, 25);
            this.lblTotalSurveyee.TabIndex = 2;
            this.lblTotalSurveyee.Text = "Total number of surveyee: 0";
            // 
            // lbl18
            // 
            this.lbl18.AutoSize = true;
            this.lbl18.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl18.Location = new System.Drawing.Point(44, 191);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(33, 25);
            this.lbl18.TabIndex = 2;
            this.lbl18.Text = "18:";
            // 
            // lbl19
            // 
            this.lbl19.AutoSize = true;
            this.lbl19.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl19.Location = new System.Drawing.Point(44, 216);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(33, 25);
            this.lbl19.TabIndex = 2;
            this.lbl19.Text = "19:";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(44, 241);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(36, 25);
            this.lbl20.TabIndex = 2;
            this.lbl20.Text = "20:";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.Location = new System.Drawing.Point(441, 191);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(75, 25);
            this.lblFemale.TabIndex = 2;
            this.lblFemale.Text = "Female:";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(441, 216);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(56, 25);
            this.lblMale.TabIndex = 2;
            this.lblMale.Text = "Male:";
            // 
            // lblComputerScience
            // 
            this.lblComputerScience.AutoSize = true;
            this.lblComputerScience.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScience.Location = new System.Drawing.Point(44, 319);
            this.lblComputerScience.Name = "lblComputerScience";
            this.lblComputerScience.Size = new System.Drawing.Size(165, 25);
            this.lblComputerScience.TabIndex = 2;
            this.lblComputerScience.Text = "Computer Science:";
            // 
            // lblInformationScience
            // 
            this.lblInformationScience.AutoSize = true;
            this.lblInformationScience.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformationScience.Location = new System.Drawing.Point(44, 344);
            this.lblInformationScience.Name = "lblInformationScience";
            this.lblInformationScience.Size = new System.Drawing.Size(174, 25);
            this.lblInformationScience.TabIndex = 2;
            this.lblInformationScience.Text = "Information Science";
            // 
            // lblInformatinTechnology
            // 
            this.lblInformatinTechnology.AutoSize = true;
            this.lblInformatinTechnology.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformatinTechnology.Location = new System.Drawing.Point(44, 369);
            this.lblInformatinTechnology.Name = "lblInformatinTechnology";
            this.lblInformatinTechnology.Size = new System.Drawing.Size(209, 25);
            this.lblInformatinTechnology.TabIndex = 2;
            this.lblInformatinTechnology.Text = "Information Technology:";
            // 
            // lblStronlyAgree
            // 
            this.lblStronlyAgree.AutoSize = true;
            this.lblStronlyAgree.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStronlyAgree.Location = new System.Drawing.Point(441, 305);
            this.lblStronlyAgree.Name = "lblStronlyAgree";
            this.lblStronlyAgree.Size = new System.Drawing.Size(141, 25);
            this.lblStronlyAgree.TabIndex = 2;
            this.lblStronlyAgree.Text = "Strongly Agree: ";
            // 
            // lblAgree
            // 
            this.lblAgree.AutoSize = true;
            this.lblAgree.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgree.Location = new System.Drawing.Point(441, 330);
            this.lblAgree.Name = "lblAgree";
            this.lblAgree.Size = new System.Drawing.Size(70, 25);
            this.lblAgree.TabIndex = 2;
            this.lblAgree.Text = "Agree: ";
            // 
            // lblNeutral
            // 
            this.lblNeutral.AutoSize = true;
            this.lblNeutral.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeutral.Location = new System.Drawing.Point(441, 355);
            this.lblNeutral.Name = "lblNeutral";
            this.lblNeutral.Size = new System.Drawing.Size(76, 25);
            this.lblNeutral.TabIndex = 2;
            this.lblNeutral.Text = "Neutral:";
            // 
            // lblDisagree
            // 
            this.lblDisagree.AutoSize = true;
            this.lblDisagree.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisagree.Location = new System.Drawing.Point(441, 381);
            this.lblDisagree.Name = "lblDisagree";
            this.lblDisagree.Size = new System.Drawing.Size(88, 25);
            this.lblDisagree.TabIndex = 2;
            this.lblDisagree.Text = "Disagree:";
            // 
            // lblStronlyDisagree
            // 
            this.lblStronlyDisagree.AutoSize = true;
            this.lblStronlyDisagree.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStronlyDisagree.Location = new System.Drawing.Point(441, 406);
            this.lblStronlyDisagree.Name = "lblStronlyDisagree";
            this.lblStronlyDisagree.Size = new System.Drawing.Size(164, 25);
            this.lblStronlyDisagree.TabIndex = 2;
            this.lblStronlyDisagree.Text = "Strongly Disagree: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAge.Location = new System.Drawing.Point(43, 159);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 32);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSex.Location = new System.Drawing.Point(440, 159);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(48, 32);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Sex";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCourse.Location = new System.Drawing.Point(43, 287);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(89, 32);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Course:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblResult.Location = new System.Drawing.Point(440, 273);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 32);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 582);
            this.Controls.Add(this.lblMale);
            this.Controls.Add(this.lblFemale);
            this.Controls.Add(this.lblStronlyDisagree);
            this.Controls.Add(this.lblNeutral);
            this.Controls.Add(this.lblInformatinTechnology);
            this.Controls.Add(this.lblDisagree);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lblAgree);
            this.Controls.Add(this.lblInformationScience);
            this.Controls.Add(this.lblStronlyAgree);
            this.Controls.Add(this.lbl19);
            this.Controls.Add(this.lblComputerScience);
            this.Controls.Add(this.lbl18);
            this.Controls.Add(this.lblTotalSurveyee);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblStudentInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblTotalSurveyee;
        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.Label lbl19;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblComputerScience;
        private System.Windows.Forms.Label lblInformationScience;
        private System.Windows.Forms.Label lblInformatinTechnology;
        private System.Windows.Forms.Label lblStronlyAgree;
        private System.Windows.Forms.Label lblAgree;
        private System.Windows.Forms.Label lblNeutral;
        private System.Windows.Forms.Label lblDisagree;
        private System.Windows.Forms.Label lblStronlyDisagree;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblResult;
    }
}