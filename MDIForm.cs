using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIFomr_Load(object sender, EventArgs e)
        {

        }

        private void Category_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void carManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bookingManagemetToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bookingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 }

        private void carReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword newMDIChild = new ChangePassword();
            newMDIChild.MdiParent = this;
            newMDIChild.Show(); 
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee newMDIChild = new Employee();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void manageSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary newMDIChild = new Salary();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void manageAttandanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attandance newMDIChild = new Attandance();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReport newMDIChild = new EmployeeReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void manageBenefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benefits newMDIChild = new Benefits();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Emonth newMDIChild = new Emonth();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AttandanceReport newMDIChild = new AttandanceReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BenefitsReport newMDIChild = new BenefitsReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmonthReport newMDIChild = new EmonthReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeReport newMDIChild = new EmployeeReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryReport newMDIChild = new SalaryReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SalaryReport newMDIChild = new SalaryReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void attandanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttandanceReport newMDIChild = new AttandanceReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void benefitsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BenefitsReport newMDIChild = new BenefitsReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            EmonthReport newMDIChild = new EmonthReport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
