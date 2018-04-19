using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class frmJobSearch : Form
    {
        public frmJobSearch()
        {
            InitializeComponent();
        }

        /*
            /////////////////////////////////////////////////////////////////////////
            ---------------------BEGINNING OF OUTPUT FUNCTIONS----------------------
            ////////////////////////////////////////////////////////////////////////
        */
        private void btnLeadsPerDay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParse(txtStartDate.Text, out DateTime b) || !DateTime.TryParse(txtEndDate.Text, out DateTime a))
                {
                    throw new Exception("Please insert a valid date into both the Start Date text box, and the End Date text box, so a time range can be set for what records will be returned.");

                }
                else {
                    dgMain.DataSource = DBConnection.dtJobLeadRangeStats(DateTime.Parse(txtStartDate.Text), DateTime.Parse(txtEndDate.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuietLeads_Click(object sender, EventArgs e)
        {
            try
            {
                dgMain.DataSource = DBConnection.dtActiveQuietLeads();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeadsBySource_Click(object sender, EventArgs e)
        {
            try
            {
                dgMain.DataSource = DBConnection.dtLeadsBySource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActiveContacts_Click(object sender, EventArgs e)
        {
            try
            {
                dgMain.DataSource = DBConnection.dtActiveContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeadCallList_Click(object sender, EventArgs e)
        {
            try
            {
                dgMain.DataSource = DBConnection.dtActiveLeadCallList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParse(txtStartDate.Text, out DateTime b) || !DateTime.TryParse(txtEndDate.Text, out DateTime a))
                {
                    throw new Exception("Please insert a valid date into both the Start Date text box, and the End Date text box, so a time range can be set for what records will be returned.");

                }
                else
                {
                    dgMain.DataSource = DBConnection.dtSearchLog(DateTime.Parse(txtStartDate.Text), DateTime.Parse(txtEndDate.Text));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeadReport_Click(object sender, EventArgs e)
        {
            try
            {
                dgMain.DataSource = DBConnection.dtLeadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*
            /////////////////////////////////////////////////////////////////////////
            ------------------------END OF OUTPUT FUNCTIONS-------------------------
            ////////////////////////////////////////////////////////////////////////
        */





        /*
            /////////////////////////////////////////////////////////////////////////
            ---------------------BEGINNING OF INPUT FUNCTIONS-----------------------
            ////////////////////////////////////////////////////////////////////////
        */


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtActID.Text != "")
            {
                bool completeState;
                if (cbComplete.CheckState = )
                DBConnection.UpdateActivities(txtActID.Text, txtLeadID.Text, txtActDate.Text, cbActType.SelectedItem.ToString(), txtActDetails.Text, completeState);
            }
            //dgActivities.DataSource = 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtActID.Text = "";
                txtLeadID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
