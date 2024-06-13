namespace L2
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.csv = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.sort = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFuelConsumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultPrint = new System.Windows.Forms.RichTextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.enteredFuel = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.additionalData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.input,
            this.print,
            this.csv});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // input
            // 
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(102, 22);
            this.input.Text = "Input";
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(102, 22);
            this.print.Text = "Print";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // csv
            // 
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(102, 22);
            this.csv.Text = "CSV";
            this.csv.Click += new System.EventHandler(this.csv_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find,
            this.sort,
            this.filterFuelConsumptionToolStripMenuItem,
            this.close,
            this.clearTextToolStripMenuItem,
            this.additionalData});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(197, 22);
            this.find.Text = "Find";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // sort
            // 
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(197, 22);
            this.sort.Text = "Sort";
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // filterFuelConsumptionToolStripMenuItem
            // 
            this.filterFuelConsumptionToolStripMenuItem.Name = "filterFuelConsumptionToolStripMenuItem";
            this.filterFuelConsumptionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.filterFuelConsumptionToolStripMenuItem.Text = "Filter fuel consumption";
            this.filterFuelConsumptionToolStripMenuItem.Click += new System.EventHandler(this.filterFuelConsumptionToolStripMenuItem_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(197, 22);
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clearTextToolStripMenuItem.Text = "Clear Text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // resultPrint
            // 
            this.resultPrint.Location = new System.Drawing.Point(12, 27);
            this.resultPrint.Name = "resultPrint";
            this.resultPrint.Size = new System.Drawing.Size(776, 343);
            this.resultPrint.TabIndex = 2;
            this.resultPrint.Text = "";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.text1.Location = new System.Drawing.Point(7, 402);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(457, 27);
            this.text1.TabIndex = 3;
            this.text1.Text = "Write desired fuel consumption (l/100km) here:";
            // 
            // enteredFuel
            // 
            this.enteredFuel.Location = new System.Drawing.Point(475, 409);
            this.enteredFuel.Name = "enteredFuel";
            this.enteredFuel.Size = new System.Drawing.Size(134, 20);
            this.enteredFuel.TabIndex = 4;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(637, 393);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(151, 47);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // additionalData
            // 
            this.additionalData.Name = "additionalData";
            this.additionalData.Size = new System.Drawing.Size(197, 22);
            this.additionalData.Text = "Additional Data";
            this.additionalData.Click += new System.EventHandler(this.additionalData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.enteredFuel);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.resultPrint);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem input;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripMenuItem csv;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sort;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem filterFuelConsumptionToolStripMenuItem;
        private System.Windows.Forms.RichTextBox resultPrint;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox enteredFuel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalData;
    }
}

