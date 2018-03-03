using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanQualifier
{
    public partial class LoanQualifier : Form
    {
        public LoanQualifier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Names constants
                const decimal MINIMUM_SALARY = 40000M;
                const int MINIMUM_YEARS_ON_JOB = 2;
              
                //Local Variables
                decimal salary;
                int yearsOnJob;

                //Get the salary and years on the job.
                salary = decimal.Parse(AnnualSalary.Text);
                yearsOnJob = int.Parse(textBox2.Text);

                //Determine if user qualifies.
                if (salary >= MINIMUM_SALARY || yearsOnJob >=5)
                {

                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB && salary >= MINIMUM_SALARY || yearsOnJob >= 5)
                    {
                        //User Qualifies
                        label4.Text = "You qualify for the loan";
                    }
                    else
                    {
                        //User doesn't qualify
                        label4.Text = "Minimum years at current " + "job not met.";
                    }

                }
                else
                {
                    //Use doesn't qualify.
                    label4.Text = "Minimum salary requirement " + "not met.";
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Textbox & label.
            AnnualSalary.Text = "";
            textBox2.Text = "";
            label4.Text = "";

            //Reset Focus
            AnnualSalary.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit program
            this.Close();
        }

        private void AnnualSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

