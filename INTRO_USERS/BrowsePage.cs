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
    public partial class BrowsePage : Form
    {
        /// <summary>
        /// //This BrowsePage method executes upon loading of the form
        /// </summary>
        public BrowsePage(string username)
        {
            InitializeComponent();
            //Indicates the currently logged in user 
            textBoxUser.Text = username;
            //Then gets theyre data
            currentProjects(username);
        }

        public void currentProjects(string username)
        {
            //Initial query
            SQL.selectQuery("select  p.projectid, title, status, description from manage m, project p where p.projectid = m.projectid and m.username =  \'" + username + "\'");
            //Clear the previous data 
            listBoxDisplay.Items.Clear();
            try
            {
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //Header for the listbox
                    string header = string.Format("{0,-10} {1,-40} {2, -24} {3, -40}", "Task ID",
                            "Description", "Status",
                            "Name");
                    listBoxDisplay.Items.Add(header);

                    //reads through each row of the sql query table individually outputting each projects info
                    while (SQL.read.Read())
                    {
                        string project = string.Format("{0,-10} {1,-40} {2, -24} {3, -40}", SQL.read[0].ToString(),
                            SQL.read[1].ToString(), SQL.read[2].ToString(),
                            SQL.read[3].ToString());
                        listBoxDisplay.Items.Add(project);
                    }
                }
                else
                {
                    listBoxDisplay.Items.Add("No Current Projects for this user");
                }
            }
            catch
            {
                listBoxDisplay.Items.Add("Error in querying database, Please check database is connected");
            }

        }


        /// <summary>
        /// Takes us back to the login page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //You should have seen this from the register page, same code to switch forms.
            Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            Close();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            //Get the projectid that needs a task added 
            int project_id = 0;
            try
            {
                //gets the item in the listbox makes it a string then gets the first char as a char then 
                //uses to string on it which is parsed into an int
                project_id = int.Parse(listBoxDisplay.SelectedItem.ToString()[0].ToString());
                //Opens the add task form 
                AddTask addTask = new AddTask(project_id);
                addTask.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please select the project you want to add a task to");
            }
        }

        /// <summary>
        /// Opens the programmer assignment form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            AssignProgrammer assignProgrammer = new AssignProgrammer();
            assignProgrammer.ShowDialog();
        }

        /// <summary>
        /// Opens the task progress form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTaskProgress_Click(object sender, EventArgs e)
        {
            TaskProgress taskprogress = new TaskProgress();
            taskprogress.ShowDialog();
        }

    }
}
