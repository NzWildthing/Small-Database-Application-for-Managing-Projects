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
    public partial class TaskProgress : Form
    {
        public TaskProgress()
        {
            InitializeComponent();
            loadInfo();
        }

        /// <summary>
        /// Loads the task progress info into the listboxes
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dataset"></param>
        public void loadInfo()
        {
            //Initial query
            SQL.selectQuery("select t.taskid, name, t.description, p.reportdate, p.description from task t, progress p where t.taskid = p.taskid " +
                "order by t.taskid asc");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    listBoxTask.Items.Add(String.Format("{0,-10} {1,-15} {2, -20}", "Task ID",
                            "Name", "Description"));
                    listBoxProgress.Items.Add(String.Format("{0,-30} {1, -20}", "Report Date", "Description"));
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        listBoxTask.Items.Add(String.Format("{0,-10} {1,-15} {2, -20} ", SQL.read[0].ToString(),
                            SQL.read[1].ToString(), SQL.read[2].ToString()));
                        listBoxProgress.Items.Add(String.Format("{0,-30} {1, -20}", SQL.read[3].ToString(), SQL.read[4].ToString()));
                    }
                }
                else
                {
                    listBoxTask.Items.Add("No Current Programmers employed");
                }
            }
            catch
            {
                listBoxTask.Items.Add("Error in querying database, Please check database is connected");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

    }
}
