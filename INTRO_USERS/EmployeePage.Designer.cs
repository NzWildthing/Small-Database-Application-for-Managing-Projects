
namespace INTRO_USERS
{
    partial class EmployeePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCurrentTasks = new System.Windows.Forms.ListBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTaskProgress = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.listBoxTaskProgress = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Tasks List ";
            // 
            // listBoxCurrentTasks
            // 
            this.listBoxCurrentTasks.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCurrentTasks.FormattingEnabled = true;
            this.listBoxCurrentTasks.HorizontalScrollbar = true;
            this.listBoxCurrentTasks.ItemHeight = 16;
            this.listBoxCurrentTasks.Location = new System.Drawing.Point(22, 138);
            this.listBoxCurrentTasks.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCurrentTasks.Name = "listBoxCurrentTasks";
            this.listBoxCurrentTasks.Size = new System.Drawing.Size(437, 292);
            this.listBoxCurrentTasks.TabIndex = 19;
            this.listBoxCurrentTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrentTasks_SelectedIndexChanged);
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEmployee.Location = new System.Drawing.Point(33, 56);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.ReadOnly = true;
            this.textBoxEmployee.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployee.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "User:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonTaskProgress
            // 
            this.buttonTaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaskProgress.Location = new System.Drawing.Point(981, 67);
            this.buttonTaskProgress.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTaskProgress.Name = "buttonTaskProgress";
            this.buttonTaskProgress.Size = new System.Drawing.Size(164, 86);
            this.buttonTaskProgress.TabIndex = 23;
            this.buttonTaskProgress.Text = "Record Task Progress";
            this.buttonTaskProgress.UseVisualStyleBackColor = true;
            this.buttonTaskProgress.Click += new System.EventHandler(this.buttonTaskProgress_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(981, 358);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(164, 84);
            this.buttonLogOut.TabIndex = 24;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // listBoxTaskProgress
            // 
            this.listBoxTaskProgress.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTaskProgress.FormattingEnabled = true;
            this.listBoxTaskProgress.HorizontalScrollbar = true;
            this.listBoxTaskProgress.ItemHeight = 16;
            this.listBoxTaskProgress.Location = new System.Drawing.Point(493, 138);
            this.listBoxTaskProgress.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTaskProgress.Name = "listBoxTaskProgress";
            this.listBoxTaskProgress.Size = new System.Drawing.Size(437, 292);
            this.listBoxTaskProgress.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Progress:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tasks:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(981, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 86);
            this.button1.TabIndex = 28;
            this.button1.Text = "View and Report Issues";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTaskProgress);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonTaskProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.listBoxCurrentTasks);
            this.Controls.Add(this.label1);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCurrentTasks;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTaskProgress;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ListBox listBoxTaskProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}