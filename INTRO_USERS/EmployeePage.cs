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
    public partial class EmployeePage : Form
    {
        public EmployeePage(string username)
        {
            InitializeComponent();
            //Indicates the currently logged in user 
            textBoxEmployee.Text = username;
            currentTasks(username);
        }

        public void currentTasks(string username)
        {
            //Initial query
            SQL.selectQuery("select t.taskid, t.name, t.description from programmer p, workson w, task t where p.username = w.username" +
                " and t.taskid = w.taskid and p.username = \'" + username + "\' order by t.taskid asc");
            //Clear the previous data 
            listBoxCurrentTasks.Items.Clear();
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //Header for the listbox
                    listBoxCurrentTasks.Items.Add(String.Format("{0,-10} {1,-20} {2, -40}", "Task ID",
                            "Name", "Description"));

                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        listBoxCurrentTasks.Items.Add(String.Format("{0,-10} {1,-20} {2, -40}", SQL.read[0].ToString(),
                            SQL.read[1].ToString(), SQL.read[2].ToString()));
                    }
                }
                else
                {
                    listBoxCurrentTasks.Items.Add("No Current Projects for this user");
                }
            }
            catch
            {
                listBoxCurrentTasks.Items.Add("Error in querying database, Please check database is connected");
            }
        }

        /// <summary>
        /// Takes us back to the login page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            Close();
        }

        private void listBoxCurrentTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshes the currently assigned listbox
            listBoxTaskProgress.Items.Clear();
            //Current task 
            int task_id = int.Parse(listBoxCurrentTasks.SelectedItem.ToString()[0].ToString());
            //Gets the info about progress on a task
            SQL.selectQuery("select p.reportdate, p.description from progress p, task t where p.taskid = t.taskid " +
                "and t.taskid = \'" + task_id + "\'");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //Header
                    listBoxTaskProgress.Items.Add(String.Format("{0,-30} {1, -20}", "Report Date", "Description"));
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        //Shows the progress for the currently selected task 
                        listBoxTaskProgress.Items.Add(String.Format("{0,-30} {1, -20}", SQL.read[0].ToString(), SQL.read[1].ToString()));
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

        /// <summary>
        /// Opens the add progress form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTaskProgress_Click(object sender, EventArgs e)
        {
            //Get the taskid that needs progress added 
            int task_id = 0;
            try
            {
                //gets the item in the listbox makes it a string then gets the first char as a char then 
                //uses to string on it which is parsed into an int
                task_id = int.Parse(listBoxCurrentTasks.SelectedItem.ToString()[0].ToString());
                //Opens the add task form 
                AddProgress addprogress = new AddProgress(task_id);
                addprogress.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please select the task you want to add progress to");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewIssues viewIssues = new ViewIssues();
            viewIssues.ShowDialog();
        }
    }
}
