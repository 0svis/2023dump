namespace L1
{
    partial class window
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
            this.start = new System.Windows.Forms.Button();
            this.enteredFuel = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(7, 12);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(596, 343);
            this.results.TabIndex = 0;
            this.results.Text = "";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.start.ForeColor = System.Drawing.Color.DarkGreen;
            this.start.Location = new System.Drawing.Point(609, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(179, 83);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // enteredFuel
            // 
            this.enteredFuel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteredFuel.Location = new System.Drawing.Point(12, 411);
            this.enteredFuel.Name = "enteredFuel";
            this.enteredFuel.Size = new System.Drawing.Size(299, 26);
            this.enteredFuel.TabIndex = 3;
            this.enteredFuel.Text = "Enter fuel consumption (l/100km)";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(8, 361);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(0, 19);
            this.textLabel.TabIndex = 5;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.DarkRed;
            this.close.Location = new System.Drawing.Point(609, 265);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(179, 83);
            this.close.TabIndex = 6;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.go.ForeColor = System.Drawing.Color.Black;
            this.go.Location = new System.Drawing.Point(609, 101);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(179, 83);
            this.go.TabIndex = 7;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.find.ForeColor = System.Drawing.Color.Black;
            this.find.Location = new System.Drawing.Point(609, 354);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(179, 83);
            this.find.TabIndex = 8;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.enter.Location = new System.Drawing.Point(353, 411);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(70, 27);
            this.enter.TabIndex = 9;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.find);
            this.Controls.Add(this.go);
            this.Controls.Add(this.close);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.enteredFuel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.results);
            this.Name = "window";
            this.Text = "Here should be a program name, but I was out of ideas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox enteredFuel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button enter;
    }
}

