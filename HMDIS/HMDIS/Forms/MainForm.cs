using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMDIS.Data_Control;

namespace HMDIS
{
    public partial class MainForm : Form
    {
        DatabaseAccess databaseAccess;

        public MainForm()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            databaseAccess.VisaDatabaseSubjects(listViewSubjectsDataTab);
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            databaseAccess.AddSubject(textBoxSubject, textBoxCurrency, comboBoxCategory);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.databaseDataSet.Subject);
            databaseAccess.VisaDatabaseSubjects(listViewSubjectsDataTab);
        }
    }
}
