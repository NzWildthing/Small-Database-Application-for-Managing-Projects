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
    public partial class AssignProgrammer : Form
    {
        public AssignProgrammer()
        {
            InitializeComponent();
            string queryProgrammers = "select username, fname, lname from programmer";
            loadInfo(queryProgrammers, listBoxDisplayProgrammers);
            string queryTasks = "select taskid, description, name from task";
            loadInfo(queryTasks, listBoxDisplayTasks);
        }

        /// <summary>
        /// Loads the programmer and task info into the textboxes 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dataset"></param>
        public void loadInfo(string query, ListBox dataset)
        {
            //Initial query
            SQL.selectQuery(query);
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        dataset.Items.Add(String.Format("{0,-10} {1,-20} {2, -10}", SQL.read[0].ToString(),
                            SQL.read[1].ToString(), SQL.read[2].ToString()));
                    }
                }
                else
                {
                    dataset.Items.Add("No Current Programmers employed");
                }
            }
            catch
            {
                dataset.Items.Add("Error in querying database, Please check database is connected");
            }

        }

        /// <summary>
        /// Assigns the selected programmer to the selected task 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            //Checks if the listboxs have been selected 
            if(listBoxDisplayProgrammers.SelectedItem == null || listBoxDisplayTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select both a task and programmer");
                return;
            }
            //Gets the taskid
            int task_id = listBoxDisplayTasks.SelectedIndex + 1;
            int counter = 0;
            string username = "";
            //Gets the programmer username
            SQL.selectQuery("select username from programmer");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        if(counter == listBoxDisplayProgrammers.SelectedIndex)
                        {
                            username = SQL.read[0].ToString();
                        }
                        counter++;
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a task and programmer");
                }
            }
            catch
            {
                MessageBox.Show("Error in querying database, Please check database is connected");
            }
            MessageBox.Show(username + " assigned to task: " + task_id.ToString() + " successfully!");

            //Now it has all the info it needs it will assign the correct programmer to the correct task in the 
            //workson table 
            try
            {
                SQL.executeQuery("insert into workson values(" + task_id + ",'" + username + "')");
                Console.WriteLine("insert into workson values(" + task_id + ",'" + username + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add attempt unsuccessful.");
                return;
            }
        }

        /// <summary>
        /// Returns to the browse page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        /// <summary>
        /// Whenever a new task is selected it shows the programmers already assigned to this task 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxDisplayTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshes the currently assigned listbox
            listBoxCurrentlyAssigned.Items.Clear();
            //Current task 
            int task_id = listBoxDisplayTasks.SelectedIndex + 1;
            //Gets the info about which programmer works on which task 
            SQL.selectQuery("select p.username, p.fname, p.lname, t.taskid from programmer p, workson w, task t where p.username = w.username and t.taskid = w.taskid " +
                "group by p.fname, p.lname, t.taskid, p.username");
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        //If the currently selected task has a programmer attached add them to the 
                        //currently assigned listbox
                        if (task_id == int.Parse(SQL.read[3].ToString()))
                        {
                            listBoxCurrentlyAssigned.Items.Add(SQL.read[0].ToString() + ' ' + SQL.read[1].ToString() + ' ' + SQL.read[2].ToString() + ' ');
                        }
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
    }
}
