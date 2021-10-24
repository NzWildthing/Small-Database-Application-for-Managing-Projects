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
    public partial class AddProgress : Form
    {

        public int _taskid;

        public AddProgress(int task_id)
        {
            _taskid = task_id;
            InitializeComponent();
        }


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
            textBoxProgressDescription.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            initialiseTextBoxes();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //variables to be used
            string description, reportdate;
            int progress_id = 0;

            //Check that the text boxes has something typed in it using a method
            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                textBoxProgressDescription.Focus();
                return;
            }

            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                description = textBoxProgressDescription.Text.Trim();
                reportdate = dateTimePickerReportDate.Value.ToString("yyyy-MM-dd");
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            //counts how many current progressids there are to make the new progressid
            try
            {
                SQL.selectQuery("select count(*) from progress");
                //if SQL has rows left to read 
                if (SQL.read.HasRows)
                {
                    //reads through the first row of the count
                    while (SQL.read.Read())
                    {
                        progress_id = (int)SQL.read[0] + 1;
                    }
                }
                else
                {
                    MessageBox.Show("Placeholder error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("progress add attempt unsuccessful.");
                return;
            }


            //Inserts the progress into the database
            try
            {
                SQL.executeQuery("insert into progress values(" + progress_id + ",'" + reportdate + "', '" +
                    description + "'," + _taskid + ")");
                Console.WriteLine("insert into task values(" + progress_id + ",'" + reportdate + "', '" +
                   description + "'," + _taskid + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add attempt unsuccessful.");
                return;
            }



            //success message for the user to know it worked
            MessageBox.Show("Successfully Added Progress: " + description + ". To Task: " + _taskid.ToString());

            //Hide the add task form and return to the browse form 
            Hide();
            this.Close();
        }
    }
}
