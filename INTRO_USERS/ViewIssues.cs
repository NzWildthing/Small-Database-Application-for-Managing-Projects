using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRO_USERS
{
    public partial class ViewIssues : Form
    {
        public ViewIssues()
        {
            InitializeComponent();
            loadInfo();
        }

        /// <summary>
        /// Loads the issues info into the listboxes
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dataset"></param>
        public void loadInfo()
        {
            //Initial query
            SQL.selectQuery("select projectid, title, description, status from project");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    listBoxProject.Items.Add(String.Format("{0,-15} {1,-40} {2, -70}{3, -15}", "Project ID",
                            "Title", "Description", "Status"));
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        listBoxProject.Items.Add(String.Format("{0,-15} {1,-40} {2, -70}{3, -15}", SQL.read[0].ToString(),
                            SQL.read[1].ToString(), SQL.read[2].ToString(), SQL.read[3].ToString()));
                    }
                }
                else
                {
                    listBoxProject.Items.Add("No Current Programmers employed");
                }
            }
            catch
            {
                listBoxProject.Items.Add("Error in querying database, Please check database is connected");
            }

        }

        private void listBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshes the currently assigned listbox
            listBoxIssue.Items.Clear();
            //Current task 
            int project_id = int.Parse(listBoxProject.SelectedItem.ToString()[0].ToString());
            //Gets the info about progress on a task
            SQL.selectQuery("select p.projectid, i.description, i.reportdate, i.urgency, i.status from issue i, project p where p.projectid = i.project_id and p.projectid = \'" + project_id + "\' " +
                "order by p.projectid asc");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //Header
                    listBoxIssue.Items.Add(String.Format("{0,-30} {1, -25}{2,-20}{3, -10}", "Report Date", "Description", "Urgency", "Status"));
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        //Shows the progress for the currently selected task 
                        listBoxIssue.Items.Add(String.Format("{0,-30} {1, -25}{2,-20}{3, -10}", SQL.read[2].ToString(), SQL.read[1].ToString(),
                            SQL.read[3].ToString(), SQL.read[4].ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a task");
                }
            }
            catch
            {
                MessageBox.Show("Error in querying database, Please check database is connected");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
