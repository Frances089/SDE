using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign_Application
{
    public partial class payrolFrm : Form
    {
        decimal basic_income_per_cutoff, hono_income_per_cutoff, other_income_per_cutoff, gross_income;
        public payrolFrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void basic_income_no_hrs_cutoffTxtbox_Leave(object sender, EventArgs e)
        {
          
        }

        private void payrolFrm_Load(object sender, EventArgs e)
        {
            departmentTxtbox.Enabled = false;
            employee_statusTxtbox.Enabled = false;
            designationTxtbox.Enabled = false;
            firstnameTxtbox.Enabled = false;
            middlenameTxtbox.Enabled = false;
            lastnameTxtbox.Enabled = false;
            civil_statusTxtbox.Enabled = false;
            basic_income_cutoffTxtbox.Enabled = false;
            honorarium_income_cutoffTxtbox.Enabled = false;
            other_income_cutoffTxtbox.Enabled =false;
            gross_incomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            total_deductionTxtbox.Enabled = false;
            philhealth_contributionTxtbox.Enabled = false;
            sss_contributionTxtbox.Enabled = false;
            pagibig_contributionTxtbox.Enabled = false;
            income_tax_contributionTxtbox.Enabled = false;
        }

        private void other_income_no_hrs_cutoffTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void honorarium_income_no_hrs_cutoffTxtbox_Leave(object sender, EventArgs e)
        {
            //declation of variables
            decimal hono_rate_per_hour, hono_num_hrs_per_cutoff;
            //converting input text data into numeric value
            hono_num_hrs_per_cutoff = Convert.ToDecimal(honorarium_income_no_hrs_cutoffTxtbox.Text);
            hono_rate_per_hour = Convert.ToDecimal(honorarium_income_rate_hrsTxtbox.Text);
            //formulating formula to compute the honorarium income
            hono_income_per_cutoff = hono_num_hrs_per_cutoff * hono_rate_per_hour;
            //converting numeric value into string and display it into a textbox
            honorarium_income_cutoffTxtbox.Text = hono_income_per_cutoff.ToString("C");
        }

        private void net_incomeBtn_Click(object sender, EventArgs e)
        {
            double sss_contri, philhealth_contri, pagibig_contri, income_tax_contri, regular_contribution, other_deductions, total_deduction;
            double sss_loan, pagibig_loan, salary_loan, employee_savings_deposit, employee_savings_loan, other_loan, gross_income1, net_income;
            sss_contri = 520;
            philhealth_contri = 210;
            pagibig_contri = 100;
            income_tax_contri = 500.50;

            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            salary_loan = Convert.ToDouble(salary_loanTxtbox.Text);
            employee_savings_deposit = Convert.ToDouble(employee_savingsTxtbox.Text);
            employee_savings_loan = Convert.ToDouble(employee_loanTxtbox.Text);
            other_loan = Convert.ToDouble(employee_other_loanTxtbox.Text);

            gross_income1 = Convert.ToDouble(gross_incomeTxtbox.Text);

            other_deductions = sss_loan + pagibig_loan + salary_loan + employee_savings_loan + employee_savings_deposit + other_loan;
            regular_contribution = sss_contri + philhealth_contri + pagibig_contri + income_tax_contri;
            total_deduction = other_deductions + regular_contribution;
            net_income = gross_income1 - total_deduction;

            net_incomeTxtbox.Text = net_income.ToString("C");
            total_deductionTxtbox.Text = total_deduction.ToString("C");
            sss_contributionTxtbox.Text = sss_contri.ToString("C");
            philhealth_contributionTxtbox.Text = philhealth_contri.ToString("C");
            pagibig_contributionTxtbox.Text = pagibig_contri.ToString("C");
            income_tax_contributionTxtbox.Text = income_tax_contri.ToString("C");
            gross_incomeTxtbox.Text = gross_income1.ToString("C");
           
        }

        private void cancel_newBtn_Click(object sender, EventArgs e)
        {
            basic_income_cutoffTxtbox.Clear();
            basic_income_no_hrs_cutoffTxtbox.Clear();
            basic_income_rate_hrsTxtbox.Clear();
            honorarium_income_cutoffTxtbox.Clear();
            honorarium_income_no_hrs_cutoffTxtbox.Clear();
            honorarium_income_rate_hrsTxtbox.Clear();
            other_income_cutoffTxtbox.Clear();
            other_income_no_hrs_cutoffTxtbox.Clear();
            other_income_rate_hrsTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            net_incomeTxtbox.Clear();
            sss_loanTxtbox.Clear();
            sss_contributionTxtbox.Clear();
            pagibig_contributionTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
            philhealth_contributionTxtbox.Clear();
            income_tax_contributionTxtbox.Clear();
            salary_loanTxtbox.Clear();
            employee_loanTxtbox.Clear();
            employee_other_loanTxtbox.Clear();
            total_deductionTxtbox.Clear();
            employee_savingsTxtbox.Clear();

        }

        private void other_income_no_hrs_cutoffTxtbox_Leave(object sender, EventArgs e)
        {
            //declation of variables
            decimal other_income_rate_per_hour, other_income_num_hrs_per_cutoff;
            //converting input text into numerical value
            other_income_num_hrs_per_cutoff = Convert.ToDecimal(other_income_no_hrs_cutoffTxtbox.Text);
            other_income_rate_per_hour = Convert.ToDecimal(other_income_rate_hrsTxtbox.Text);
            // formulating formula to compute the other income
            other_income_per_cutoff = other_income_rate_per_hour * other_income_num_hrs_per_cutoff;
            //converting numeric value into string and display it in a textbox
            other_income_cutoffTxtbox.Text = other_income_per_cutoff.ToString("C");
        }

        private void gross_incomeBtn_Click(object sender, EventArgs e)
        {
            gross_income = basic_income_per_cutoff + hono_income_per_cutoff + other_income_per_cutoff;
            gross_incomeTxtbox.Text = gross_income.ToString();
            sss_contributionTxtbox.Text = "520.00";
            philhealth_contributionTxtbox.Text = "210.00";
            pagibig_contributionTxtbox.Text = "100.00";
            income_tax_contributionTxtbox.Text = "500.00";
        }

        private void basic_income_no_hrs_cutoffTxtbox_Leave_1(object sender, EventArgs e)
        {
            //declaration of variables for basic income computation
            decimal basic_income_rate_per_hour, basic_income_num_hrs_per_cutoff;
            //input data will be converted form text value into numeric value
            basic_income_rate_per_hour = Convert.ToDecimal(basic_income_rate_hrsTxtbox.Text);
            basic_income_num_hrs_per_cutoff = Convert.ToDecimal(basic_income_no_hrs_cutoffTxtbox.Text);
            //formulate the formula for the computation of basic income per cutoff
            basic_income_per_cutoff = basic_income_rate_per_hour * basic_income_num_hrs_per_cutoff;
            //convert data from numeric value into text and display it in a textbox
            basic_income_cutoffTxtbox.Text = basic_income_per_cutoff.ToString("C");
        }
    }
}
