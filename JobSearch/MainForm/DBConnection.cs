using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MainForm
{
    class DBConnection
    {
        public const string CONNECTIONSTRING = @"Server=PL1\MTCDB;Database=JobSearchPlus;Trusted_Connection=True;";
        private static SqlConnection sqlConn = new SqlConnection(CONNECTIONSTRING);

        public SqlConnection OpenSqlConnection
        {
            get
            {
                return sqlConn;
            }
        }

        /*
            /////////////////////////////////////////////////////////////////////////
            ---------------------BEGINNING OF OUTPUT FUNCTIONS----------------------
            ////////////////////////////////////////////////////////////////////////
        */

        public static DataTable dtJobLeadRangeStats(DateTime startDate, DateTime endDate)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand("dbo.sp_JobLeadRangeStats", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter prmStartDate = new SqlParameter("@StartDate", startDate);
                SqlParameter prmEndDate = new SqlParameter("@EndDate", endDate);

                sqlComm.Parameters.Add(prmStartDate);
                sqlComm.Parameters.Add(prmEndDate);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlComm);
                DataTable dtLeadRange = new DataTable();
                sqlData.Fill(dtLeadRange);

                return dtLeadRange;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable dtActiveQuietLeads()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("dbo.sp_ActiveQuietLeads", sqlConn);

                DataTable dtQuietLeads = new DataTable();

                sqlData.Fill(dtQuietLeads);

                return dtQuietLeads;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable dtLeadsBySource()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("dbo.sp_LeadsBySource", sqlConn);

                DataTable dtSourceLeads = new DataTable();

                sqlData.Fill(dtSourceLeads);

                return dtSourceLeads;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable dtActiveContacts()
        {
            try
            { 
            SqlDataAdapter sqlData = new SqlDataAdapter("dbo.sp_ActiveContacts", sqlConn);

            DataTable dtContacts = new DataTable();

            sqlData.Fill(dtContacts);

            return dtContacts;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable dtActiveLeadCallList()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("dbo.sp_ActiveLeadCallList", sqlConn);

                DataTable dtActiveLeadCall = new DataTable();

                sqlData.Fill(dtActiveLeadCall);

                return dtActiveLeadCall;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable dtSearchLog(DateTime startDate, DateTime endDate)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand("dbo.sp_SearchLog", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter prmStartDate = new SqlParameter("@StartDate", startDate);
                SqlParameter prmEndDate = new SqlParameter("@EndDate", endDate);

                sqlComm.Parameters.Add(prmStartDate);
                sqlComm.Parameters.Add(prmEndDate);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlComm);
                DataTable dtSearch = new DataTable();
                sqlData.Fill(dtSearch);

                return dtSearch;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable dtLeadReport()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("dbo.sp_LeadReport", sqlConn);

                DataTable dtReport = new DataTable();

                sqlData.Fill(dtReport);

                return dtReport;
            }
            catch (Exception ex)
            {
                throw ex;
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

        public bool UpdateActivities(int ActivityID, int LeadID, string ActivityDate, string ActivityType, 
                                        string ActivityDetails, bool Complete, string ReferenceLink)
        {
                bool success = false;

            try
            {
                SqlCommand callActivities = new SqlCommand("dbo.sp_UpdateActivities", sqlConn);
                callActivities.CommandType = CommandType.StoredProcedure;

                callActivities.Parameters.AddWithValue("@AID", ActivityID);
                callActivities.Parameters.AddWithValue("@LID", LeadID);
                callActivities.Parameters.AddWithValue("@ActDate", ActivityDate);
                callActivities.Parameters.AddWithValue("@ActType", ActivityType);
                callActivities.Parameters.AddWithValue("@ActDet", ActivityDetails);
                callActivities.Parameters.AddWithValue("@Com", Complete);
                callActivities.Parameters.AddWithValue("@RefLink", ReferenceLink);

                callActivities.ExecuteNonQuery();


                success = true;

                return success;
            }
            catch (Exception ex)
            {
                success = false;
                throw ex;
            }
        }


    }
}
