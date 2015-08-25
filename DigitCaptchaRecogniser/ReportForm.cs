using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigitCaptchaRecogniser
{
    public partial class ReportForm : Form
    {
        private readonly List<string> _errorsList;

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(List<string> errors, int researchCount)
        {
            _errorsList = errors;
            InitializeComponent();
            reportListBox.Items.Add(string.Format("Total errors = {0} on {1} items", errors.Count, researchCount));
            reportListBox.Items.Add("");
            reportListBox.Items.Add("Error list:");
            foreach (var error in errors)
            {
                reportListBox.Items.Add(error);    
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(Environment.NewLine, _errorsList.Cast<object>().Select(o => o.ToString()).ToArray()));  
        }
    }
}
