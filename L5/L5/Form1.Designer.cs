namespace L5
{
    partial class Form1
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
            this.results = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.program = new System.Windows.Forms.ToolStripMenuItem();
            this.read = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.actions = new System.Windows.Forms.ToolStripMenuItem();
            this.largest = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.task = new System.Windows.Forms.ToolStripMenuItem();
            this.userInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(10, 33);
            this.results.Margin = new System.Windows.Forms.Padding(2);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(582, 268);
            this.results.TabIndex = 0;
            this.results.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.program,
            this.actions,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // program
            // 
            this.program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.read,
            this.close});
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(65, 20);
            this.program.Text = "Program";
            // 
            // read
            // 
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(180, 22);
            this.read.Text = "Read Input Files";
            this.read.Click += new System.EventHandler(this.addInput_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(180, 22);
            this.close.Text = "Close Program";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // actions
            // 
            this.actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largest});
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(59, 20);
            this.actions.Text = "Actions";
            // 
            // largest
            // 
            this.largest.Name = "largest";
            this.largest.Size = new System.Drawing.Size(245, 22);
            this.largest.Text = "Find Largest Equilateral Triangles";
            this.largest.Click += new System.EventHandler(this.largest_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task,
            this.userInstructions});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // task
            // 
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(162, 22);
            this.task.Text = "Task";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // userInstructions
            // 
            this.userInstructions.Name = "userInstructions";
            this.userInstructions.Size = new System.Drawing.Size(162, 22);
            this.userInstructions.Text = "User instructions";
            this.userInstructions.Click += new System.EventHandler(this.userInstructions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.Controls.Add(this.results);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "U5_5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem program;
        private System.Windows.Forms.ToolStripMenuItem read;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem actions;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem task;
        private System.Windows.Forms.ToolStripMenuItem userInstructions;
        private System.Windows.Forms.ToolStripMenuItem largest;
    }
}

