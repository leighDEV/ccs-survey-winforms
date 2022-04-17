using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccs_survey_winforms
{
    public partial class AnswerSurveyForm : Form
    {
        int index;
        List<Panel> panelListStatements = new List<Panel>();
        
        public AnswerSurveyForm()
        {
            InitializeComponent();
        }

        private void AnswerSurveyForm_Load(object sender, EventArgs e)
        {
            panelListStatements.Add(pnlS1);
            panelListStatements.Add(pnlS2);
            panelListStatements.Add(pnlS3);
            panelListStatements.Add(pnlS4);
            panelListStatements.Add(pnlS5);
            panelListStatements.Add(pnlS6);
            panelListStatements.Add(pnlS7);
            panelListStatements.Add(pnlS8);
            panelListStatements.Add(pnlS9);
            panelListStatements.Add(pnlS10);
            panelListStatements[index].BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
                panelListStatements[--index].BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < panelListStatements.Count - 1)
                panelListStatements[++index].BringToFront();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || cboCourse.Text == "" || cboAge.Text == "" || cboSex.Text == ""
                || cboS1.Text == "" || cboS2.Text == "" || cboS3.Text == "" || cboS4.Text == "" ||
                cboS5.Text == "" || cboS6.Text == "" || cboS7.Text == "" || cboS8.Text == "" ||
                cboS9.Text == "" || cboS10.Text == "")
            {
                MessageBox.Show("Please fill out information!");
            }
            else
            {
                TextFile textFile = new TextFile();
                string name = tbName.Text.ToString();
                string age = cboAge.SelectedItem.ToString(); // i made it string instead of int
                string sex = cboSex.SelectedItem.ToString();
                string coursefull = cboCourse.SelectedItem.ToString();
                int[] answers = new int[10];

                string course;
                if (coursefull.Equals("Computer Science"))
                    course = "BSCS";
                else if (coursefull.Equals("Information Science"))
                    course = "BSIS";
                else
                    course = "BSIT";

                textFile.WritingStudentInfo(age, sex, course);

                int.TryParse(cboS1.Text, out answers[0]);
                int.TryParse(cboS2.Text, out answers[1]);
                int.TryParse(cboS3.Text, out answers[2]);
                int.TryParse(cboS4.Text, out answers[3]);
                int.TryParse(cboS5.Text, out answers[4]);
                int.TryParse(cboS6.Text, out answers[5]);
                int.TryParse(cboS7.Text, out answers[6]);
                int.TryParse(cboS8.Text, out answers[7]);
                int.TryParse(cboS9.Text, out answers[8]);
                int.TryParse(cboS10.Text, out answers[9]);

                textFile.WritingAllInfo(name, age, sex, course, answers);
                lblResult.Text = $"Result: "; // still now working

                MessageBox.Show("Successfully Submitted!");
                tbName.ResetText();
                cboAge.Items.Clear();
                cboCourse.Items.Clear();
                cboSex.Items.Clear();
            }
        }
    }
}