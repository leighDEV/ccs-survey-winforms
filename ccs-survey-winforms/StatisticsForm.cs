using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccs_survey_winforms
{
    public partial class StatisticsForm : Form
    {
        int eighteen, nineteen, twenty, female, male, bscs, bsis, bsit;
        int stronglyAgree, agree, neutral, disagree, stronglyDisagree;

        string[] arrayAge = File.ReadAllLines(@"D:\survey - age.txt");

        public StatisticsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the Statistics Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            ReadingStudentInfo();
            ReadingResults();
            WritingStats();
        }

        /// <summary>
        /// Reading age, sex, course from each of its own text file
        /// </summary>
        private void ReadingStudentInfo()
        {
            // method for reading the age in the text file to show the statistics
            using (StreamReader readAge = new StreamReader(@"D:\survey - age.txt"))
            {
                lblTotalSurveyee.Text = $"Total number of surveyee: {arrayAge.Length}";
                string contentsAge = readAge.ReadToEnd();

                MatchCollection _eighteen = Regex.Matches(contentsAge, @"(?i)\b18\b");
                eighteen = (int)Math.Round((double)(100 * _eighteen.Count) / arrayAge.Length);
                lbl18.Text = $"18: {eighteen}%";

                MatchCollection _nineteen = Regex.Matches(contentsAge, @"(?i)\b19\b");
                nineteen = (int)Math.Round((double)(100 * _nineteen.Count) / arrayAge.Length);
                lbl19.Text = $"19: {nineteen}%";

                MatchCollection _twenty = Regex.Matches(contentsAge, @"(?i)\b20\b");
                twenty = (int)Math.Round((double)(100 * _twenty.Count) / arrayAge.Length);
                lbl20.Text = $"20: {twenty}%";
                readAge.Close();
            }

            // method for reading the sex in the text file to show the statistics
            using (StreamReader readSex = File.OpenText(@"D:\survey - sex.txt"))
            {
                string contentsSex = readSex.ReadToEnd();
                string[] arraySex = File.ReadAllLines(@"D:\survey - sex.txt");

                MatchCollection _female = Regex.Matches(contentsSex, @"(?i)\bFEMALE\b");
                female = (int)Math.Round((double)(100 * _female.Count) / arraySex.Length);
                lblFemale.Text = $"Female: {female}%";

                MatchCollection _male = Regex.Matches(contentsSex, @"(?i)\bMALE\b");
                male = (int)Math.Round((double)(100 * _male.Count) / arraySex.Length);
                lblMale.Text = $"Male  : {male}%";
                readSex.Close();
            }

            // method for reading the course in the text file to show the statistics
            using (StreamReader readCourse = File.OpenText(@"D:\survey - course.txt"))
            {
                string contentsCourse = readCourse.ReadToEnd();
                string[] arrayCourse = File.ReadAllLines(@"D:\survey - course.txt");

                MatchCollection _bscs = Regex.Matches(contentsCourse, @"(?i)\bBSCS\b");
                bscs = (int)Math.Round((double)(100 * _bscs.Count) / arrayCourse.Length);
                lblComputerScience.Text = $"Computer Science: {bscs}%";

                MatchCollection _bsis = Regex.Matches(contentsCourse, @"(?i)\bBSIS\b");
                bsis = (int)Math.Round((double)(100 * _bsis.Count) / arrayCourse.Length);
                lblInformationScience.Text = $"Information Science: {bsis}%";

                MatchCollection _bsit = Regex.Matches(contentsCourse, @"(?i)\bBSIT\b");
                bsit = (int)Math.Round((double)(100 * _bsit.Count) / arrayCourse.Length);
                lblInformatinTechnology.Text = $"Information Technology: {bsit}%";
                readCourse.Close();
            }
        }

        /// <summary>
        /// Reading the results of the surveyees inside its text file
        /// </summary>
        private void ReadingResults()
        {
            using (StreamReader readResults = File.OpenText(@"D:\survey - results.txt"))
            {
                string contentResults = readResults.ReadToEnd();
                string[] arrayResults = File.ReadAllLines(@"D:\survey - results.txt");

                MatchCollection _stronglyAgree = Regex.Matches(contentResults, @"(?i)\b5\b");
                stronglyAgree = (int)Math.Round((double)(100 * _stronglyAgree.Count) / arrayResults.Length);
                lblStronlyAgree.Text = $"Strongly Agree   : {stronglyAgree}%";

                MatchCollection _agree = Regex.Matches(contentResults, @"(?i)\b4\b");
                agree = (int)Math.Round((double)(100 * _agree.Count) / arrayResults.Length);
                lblAgree.Text = $"Agree            : {agree}%";

                MatchCollection _neutral = Regex.Matches(contentResults, @"(?i)\b3\b");
                neutral = (int)Math.Round((double)(100 * _neutral.Count) / arrayResults.Length);
                lblNeutral.Text = $"Neutral          : {neutral}%";

                MatchCollection _disagree = Regex.Matches(contentResults, @"(?i)\b2\b");
                disagree = (int)Math.Round((double)(100 * _disagree.Count) / arrayResults.Length);
                lblDisagree.Text = $"Disagree         : { disagree}%";

                MatchCollection _stronglyDisagree = Regex.Matches(contentResults, @"(?i)\b1\b");
                stronglyDisagree = (int)Math.Round((double)(100 * _stronglyDisagree.Count) / arrayResults.Length);
                lblStronlyDisagree.Text = $"Strongly Disagree: {stronglyDisagree}%";
                readResults.Close();
            }
        }

        /// <summary>
        /// Writing the statistics in a separate text file
        /// </summary>
        private void WritingStats()
        {
            using (StreamWriter ss = new StreamWriter(@"D:\survey - statistics.txt"))
            {
                ss.WriteLine("Survey's Statistics");
                ss.WriteLine($"\nTotal number of surveyee: {arrayAge.Length}");
                ss.WriteLine("\nAge");
                ss.WriteLine($"18: {eighteen}%");
                ss.WriteLine($"19: {nineteen}%");
                ss.WriteLine($"20: {twenty}%");

                ss.WriteLine("\nSex");
                ss.WriteLine($"Female: {female}%");
                ss.WriteLine($"Male  : {male}%");

                ss.WriteLine("\nCourse");
                ss.WriteLine($"BSCS: {bscs}%");
                ss.WriteLine($"BSIS: {bsis}%");
                ss.WriteLine($"BSIT: {bsit}%");

                ss.WriteLine("\nResults");
                ss.WriteLine($"Strongly Agree   : {stronglyAgree}%");
                ss.WriteLine($"Agree            : {agree}%");
                ss.WriteLine($"Neutral          : {neutral}%");
                ss.WriteLine($"Disagree         : { disagree}%");
                ss.WriteLine($"Strongly Disagree: {stronglyDisagree}%");
                ss.Close();
            }
        }
    }
}