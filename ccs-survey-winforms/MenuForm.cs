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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the Answer Survey button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnswerSurvey_Click(object sender, EventArgs e)
        {
            AnswerSurveyForm answerSurveyForm = new AnswerSurveyForm();
            answerSurveyForm.Show();
        }

        /// <summary>
        /// Clicking the Show Current Statistics button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCurrentStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        /// <summary>
        /// Clicking the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
