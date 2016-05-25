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
            databaseAccess.VisaDatabaseKunder(listViewSubjectsDataTab);
        }
    }
}
