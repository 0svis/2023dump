namespace L3
{
    partial class Lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAuthorWithMostQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructions = new System.Windows.Forms.ToolStripMenuItem();
            this.task = new System.Windows.Forms.ToolStripMenuItem();
            this.results = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.letterBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.digitBox = new System.Windows.Forms.TextBox();
            this.formButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.diffBox = new System.Windows.Forms.TextBox();
            this.diffButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1457, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.printToolStripMenuItem,
            this.endToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAuthorWithMostQuestionsToolStripMenuItem,
            this.sortButton});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // findAuthorWithMostQuestionsToolStripMenuItem
            // 
            this.findAuthorWithMostQuestionsToolStripMenuItem.Name = "findAuthorWithMostQuestionsToolStripMenuItem";
            this.findAuthorWithMostQuestionsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.findAuthorWithMostQuestionsToolStripMenuItem.Text = "Find author with most questions";
            this.findAuthorWithMostQuestionsToolStripMenuItem.Click += new System.EventHandler(this.findAuthorWithMostQuestionsToolStripMenuItem_Click);
            // 
            // sortButton
            // 
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(245, 22);
            this.sortButton.Text = "Sort by themes and grades";
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructions,
            this.task});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructions
            // 
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(179, 22);
            this.instructions.Text = "Instructions for user";
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // task
            // 
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(179, 22);
            this.task.Text = "Task";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(16, 33);
            this.results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(1381, 400);
            this.results.TabIndex = 1;
            this.results.Text = "";
            this.results.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 443);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desired theme";
            // 
            // letterBox
            // 
            this.letterBox.Location = new System.Drawing.Point(23, 473);
            this.letterBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.letterBox.Name = "letterBox";
            this.letterBox.Size = new System.Drawing.Size(203, 22);
            this.letterBox.TabIndex = 3;
            this.letterBox.Tag = "";
            this.letterBox.Text = "Enter desired theme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(255, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desired amount of answer options";
            // 
            // digitBox
            // 
            this.digitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.digitBox.Location = new System.Drawing.Point(260, 471);
            this.digitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.digitBox.Name = "digitBox";
            this.digitBox.Size = new System.Drawing.Size(331, 22);
            this.digitBox.TabIndex = 6;
            this.digitBox.Tag = "";
            this.digitBox.Text = "Enter a digit for desired amount of answer options";
            // 
            // formButton
            // 
            this.formButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.formButton.Location = new System.Drawing.Point(484, 516);
            this.formButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(148, 95);
            this.formButton.TabIndex = 7;
            this.formButton.Text = "Form each asosiation list";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desired question difficulty";
            // 
            // diffBox
            // 
            this.diffBox.Location = new System.Drawing.Point(756, 473);
            this.diffBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diffBox.Name = "diffBox";
            this.diffBox.Size = new System.Drawing.Size(257, 22);
            this.diffBox.TabIndex = 9;
            this.diffBox.Text = "Enter a desired question difficulty";
            // 
            // diffButton
            // 
            this.diffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.diffButton.Location = new System.Drawing.Point(1236, 516);
            this.diffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(152, 95);
            this.diffButton.TabIndex = 10;
            this.diffButton.Text = "Do";
            this.diffButton.UseVisualStyleBackColor = true;
            this.diffButton.Click += new System.EventHandler(this.diffButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1096, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Desired answer number";
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(1101, 473);
            this.answerBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(272, 22);
            this.answerBox1.TabIndex = 12;
            this.answerBox1.Text = "Enter a desired question answer number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(820, 537);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Form a list with desired question\r\n difficulty and answer index:\r\n";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 625);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.diffBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.digitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lab3";
            this.Text = "Lab3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAuthorWithMostQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortButton;
        private System.Windows.Forms.ToolStripMenuItem instructions;
        private System.Windows.Forms.ToolStripMenuItem task;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox letterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox digitBox;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diffBox;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.Label label6;
    }
}

