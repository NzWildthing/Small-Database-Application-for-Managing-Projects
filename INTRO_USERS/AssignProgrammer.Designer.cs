
namespace INTRO_USERS
{
    partial class AssignProgrammer
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
            this.listBoxDisplayProgrammers = new System.Windows.Forms.ListBox();
            this.listBoxDisplayTasks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxCurrentlyAssigned = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDisplayProgrammers
            // 
            this.listBoxDisplayProgrammers.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplayProgrammers.FormattingEnabled = true;
            this.listBoxDisplayProgrammers.ItemHeight = 16;
            this.listBoxDisplayProgrammers.Location = new System.Drawing.Point(62, 86);
            this.listBoxDisplayProgrammers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDisplayProgrammers.Name = "listBoxDisplayProgrammers";
            this.listBoxDisplayProgrammers.Size = new System.Drawing.Size(373, 308);
            this.listBoxDisplayProgrammers.TabIndex = 19;
            // 
            // listBoxDisplayTasks
            // 
            this.listBoxDisplayTasks.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplayTasks.FormattingEnabled = true;
            this.listBoxDisplayTasks.ItemHeight = 16;
            this.listBoxDisplayTasks.Location = new System.Drawing.Point(467, 86);
            this.listBoxDisplayTasks.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDisplayTasks.Name = "listBoxDisplayTasks";
            this.listBoxDisplayTasks.Size = new System.Drawing.Size(405, 308);
            this.listBoxDisplayTasks.TabIndex = 20;
            this.listBoxDisplayTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplayTasks_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tasks:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Programmers:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.Location = new System.Drawing.Point(930, 257);
            this.buttonAssign.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(171, 66);
            this.buttonAssign.TabIndex = 34;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(930, 345);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 66);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxCurrentlyAssigned
            // 
            this.listBoxCurrentlyAssigned.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCurrentlyAssigned.FormattingEnabled = true;
            this.listBoxCurrentlyAssigned.ItemHeight = 16;
            this.listBoxCurrentlyAssigned.Location = new System.Drawing.Point(909, 86);
            this.listBoxCurrentlyAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCurrentlyAssigned.Name = "listBoxCurrentlyAssigned";
            this.listBoxCurrentlyAssigned.Size = new System.Drawing.Size(213, 132);
            this.listBoxCurrentlyAssigned.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Assigned to selected task:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AssignProgrammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCurrentlyAssigned);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxDisplayTasks);
            this.Controls.Add(this.listBoxDisplayProgrammers);
            this.Name = "AssignProgrammer";
            this.Text = "AssignProgrammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplayProgrammers;
        private System.Windows.Forms.ListBox listBoxDisplayTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxCurrentlyAssigned;
        private System.Windows.Forms.Label label2;
    }
}