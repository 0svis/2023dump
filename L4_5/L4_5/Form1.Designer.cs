namespace L4_5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFile = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.mostEconomicalCars = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestCar = new System.Windows.Forms.ToolStripMenuItem();
            this.formANewList = new System.Windows.Forms.ToolStripMenuItem();
            this.sort = new System.Windows.Forms.ToolStripMenuItem();
            this.task = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsForUser = new System.Windows.Forms.ToolStripMenuItem();
            this.results = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFiles,
            this.outputFile,
            this.close});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostEconomicalCars,
            this.biggestCar,
            this.formANewList,
            this.sort});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task,
            this.instructionsForUser});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // inputFiles
            // 
            this.inputFiles.Name = "inputFiles";
            this.inputFiles.Size = new System.Drawing.Size(180, 22);
            this.inputFiles.Text = "Input files";
            this.inputFiles.Click += new System.EventHandler(this.inputFiles_Click);
            // 
            // outputFile
            // 
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(180, 22);
            this.outputFile.Text = "Output file";
            this.outputFile.Click += new System.EventHandler(this.outputFile_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(180, 22);
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // mostEconomicalCars
            // 
            this.mostEconomicalCars.Name = "mostEconomicalCars";
            this.mostEconomicalCars.Size = new System.Drawing.Size(390, 22);
            this.mostEconomicalCars.Text = "Most Economical Cars";
            this.mostEconomicalCars.Click += new System.EventHandler(this.mostEconomicalCars_Click);
            // 
            // biggestCar
            // 
            this.biggestCar.Name = "biggestCar";
            this.biggestCar.Size = new System.Drawing.Size(390, 22);
            this.biggestCar.Text = "Biggest cars";
            this.biggestCar.Click += new System.EventHandler(this.biggestCar_Click);
            // 
            // formANewList
            // 
            this.formANewList.Name = "formANewList";
            this.formANewList.Size = new System.Drawing.Size(390, 22);
            this.formANewList.Text = "Form a new list from cars that uses less fuel than biggest car";
            this.formANewList.Click += new System.EventHandler(this.formANewList_Click);
            // 
            // sort
            // 
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(390, 22);
            this.sort.Text = "Sort";
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // task
            // 
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(180, 22);
            this.task.Text = "Task";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // instructionsForUser
            // 
            this.instructionsForUser.Name = "instructionsForUser";
            this.instructionsForUser.Size = new System.Drawing.Size(180, 22);
            this.instructionsForUser.Text = "Instructions for user";
            this.instructionsForUser.Click += new System.EventHandler(this.instructionsForUser_Click);
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.results.Location = new System.Drawing.Point(13, 28);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(657, 349);
            this.results.TabIndex = 1;
            this.results.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a fuel consumption in l/100km";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove cars that exceed entered fuel consumption";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "U1-5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFiles;
        private System.Windows.Forms.ToolStripMenuItem outputFile;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostEconomicalCars;
        private System.Windows.Forms.ToolStripMenuItem biggestCar;
        private System.Windows.Forms.ToolStripMenuItem formANewList;
        private System.Windows.Forms.ToolStripMenuItem sort;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem task;
        private System.Windows.Forms.ToolStripMenuItem instructionsForUser;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

