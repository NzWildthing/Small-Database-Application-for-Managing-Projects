namespace INTRO_USERS
{
    partial class BrowsePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.buttonTaskProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(787, 292);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(194, 64);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "Log Out";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.ItemHeight = 16;
            this.listBoxDisplay.Location = new System.Drawing.Point(18, 96);
            this.listBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(743, 292);
            this.listBoxDisplay.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "User:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Projects List ";
            // 
            // textBoxUser
            // 
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUser.Location = new System.Drawing.Point(12, 47);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxUser.TabIndex = 20;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.Location = new System.Drawing.Point(787, 24);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(194, 63);
            this.buttonAddTask.TabIndex = 21;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.Location = new System.Drawing.Point(787, 111);
            this.buttonAssign.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(194, 64);
            this.buttonAssign.TabIndex = 22;
            this.buttonAssign.Text = "Assign Programmer";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // buttonTaskProgress
            // 
            this.buttonTaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaskProgress.Location = new System.Drawing.Point(787, 203);
            this.buttonTaskProgress.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTaskProgress.Name = "buttonTaskProgress";
            this.buttonTaskProgress.Size = new System.Drawing.Size(194, 64);
            this.buttonTaskProgress.TabIndex = 23;
            this.buttonTaskProgress.Text = "View Task Progress";
            this.buttonTaskProgress.UseVisualStyleBackColor = true;
            this.buttonTaskProgress.Click += new System.EventHandler(this.buttonTaskProgress_Click);
            // 
            // BrowsePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 413);
            this.Controls.Add(this.buttonTaskProgress);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowsePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowsePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button buttonTaskProgress;
    }
}