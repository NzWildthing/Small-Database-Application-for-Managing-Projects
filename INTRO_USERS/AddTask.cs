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
    public partial class AddTask : Form
    {
        public int _projectid;

        public AddTask(int project_id)
        {
            //Sets the project id to be connected to 
            _projectid = project_id;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //variables to be used
            string description, priority, name, startdate, completeddate;
            int task_id = 0;

            //Check that the text boxes has something typed in it using a method
            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                textBoxDescription.Focus();
                return;
            }

            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                description = textBoxDescription.Text.Trim();
                priority = textBoxPriority.Text.Trim();
                name = textBoxTaskName.Text.Trim();
                startdate = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
                completeddate = dateTimePickerCompleted.Value.ToString("yyyy-MM-dd");
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            //counts how many current tasks there are to make the new taskid
            try
            {
                SQL.selectQuery("select count(*) from task");
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //reads through the first row of the count
                    while (SQL.read.Read())
                    {
                        task_id = (int)SQL.read[0] + 1;
                    }
                }
                else
                {
                    MessageBox.Show("Placeholder error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Task add attempt unsuccessful.");
                return;
            }


            //(2) Execute the INSERT statement, making sure all quotes and commas are in the correct places.
            //      Practice first on SQL Server Management Studio to make sure it is entering the correct data and in the correct format,
            //      then copy across the statement and where there are string replace the actual text for the variables stored above.
            //Example query: " INSERT INTO Users VALUES ('jkc1', 'John', 'Middle', 'Carter', 'pass1') "
            try
            {
                SQL.executeQuery("insert into task values(" + task_id + ",'" + description + "', '" +
                    priority + "','" + startdate + "', '" + completeddate + "', '" + name + "', " + _projectid + ")") ;
                Console.WriteLine("insert into task values(" + task_id + ",'" + description + "', '" +
                   priority + "','" + startdate + "', '" + completeddate + "', '" + name + "', " + _projectid + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add attempt unsuccessful.");
                return;
            }



            //success message for the user to know it worked
            MessageBox.Show("Successfully Added Task: " + description + " " + priority + ". Called: " + name);

            //Hide the add task form and return to the browse form 
            Hide();                                 
            this.Close();
        }

        /* Methods go below here */

        /// <summary>
        /// Checks if they textboxes have data in them
        /// </summary>
        /// <returns>TRUE if all hold text, but FALSE if at least one does not hold data</returns>
        private bool checkTextBoxes()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox)
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            initialiseTextBoxes();
        }

        /// <summary>
        /// Initialises all textboxes to blank text
        /// Does nothing in terms of re-focusing
        /// </summary>
        private void initialiseTextBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                //if the it is a textbox
                if (c is TextBox)
                {
                    //clear the text box
                    (c as TextBox).Clear();
                }
            }
            //focus on first text box
            textBoxDescription.Focus();
        }

        /// <summary>
        /// Takes us back to the browse screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
