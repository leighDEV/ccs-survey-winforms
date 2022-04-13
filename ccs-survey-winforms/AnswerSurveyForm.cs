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
            if (tbName.Text == "" && cboCourse.Text == "" && cboAge.Text == "" && cboSex.Text == "")
            {

            }
            else
            {
                // show the result here
                MessageBox.Show("Successfully Submitted!");
            } 
        }
    }
}