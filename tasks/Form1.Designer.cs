namespace tasks
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inpTodo = new System.Windows.Forms.TextBox();
            this.inpDone = new System.Windows.Forms.TextBox();
            this.inpDoing = new System.Windows.Forms.TextBox();
            this.lstTodo = new System.Windows.Forms.ListView();
            this.lstDoing = new System.Windows.Forms.ListView();
            this.lstDone = new System.Windows.Forms.ListView();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnDoing = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskToDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskDoing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTodoToDoing = new System.Windows.Forms.Button();
            this.btnTodoToDone = new System.Windows.Forms.Button();
            this.btnDoingToTodo = new System.Windows.Forms.Button();
            this.btnDoingToDone = new System.Windows.Forms.Button();
            this.btnDoneToTodo = new System.Windows.Forms.Button();
            this.btnDoneToDoing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inpTodo
            // 
            this.inpTodo.Location = new System.Drawing.Point(12, 43);
            this.inpTodo.Name = "inpTodo";
            this.inpTodo.Size = new System.Drawing.Size(206, 20);
            this.inpTodo.TabIndex = 1;
            // 
            // inpDone
            // 
            this.inpDone.Location = new System.Drawing.Point(529, 43);
            this.inpDone.Name = "inpDone";
            this.inpDone.Size = new System.Drawing.Size(206, 20);
            this.inpDone.TabIndex = 3;
            // 
            // inpDoing
            // 
            this.inpDoing.Location = new System.Drawing.Point(270, 43);
            this.inpDoing.Name = "inpDoing";
            this.inpDoing.Size = new System.Drawing.Size(206, 20);
            this.inpDoing.TabIndex = 2;
            // 
            // lstTodo
            // 
            this.lstTodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskToDo});
            this.lstTodo.GridLines = true;
            this.lstTodo.Location = new System.Drawing.Point(12, 69);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(252, 297);
            this.lstTodo.TabIndex = 4;
            this.lstTodo.UseCompatibleStateImageBehavior = false;
            this.lstTodo.View = System.Windows.Forms.View.Details;
            // 
            // lstDoing
            // 
            this.lstDoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDoing});
            this.lstDoing.GridLines = true;
            this.lstDoing.Location = new System.Drawing.Point(270, 69);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(252, 297);
            this.lstDoing.TabIndex = 5;
            this.lstDoing.UseCompatibleStateImageBehavior = false;
            this.lstDoing.View = System.Windows.Forms.View.Details;
            // 
            // lstDone
            // 
            this.lstDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDone});
            this.lstDone.GridLines = true;
            this.lstDone.Location = new System.Drawing.Point(529, 70);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(251, 296);
            this.lstDone.TabIndex = 6;
            this.lstDone.UseCompatibleStateImageBehavior = false;
            this.lstDone.View = System.Windows.Forms.View.Details;
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(224, 43);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(40, 20);
            this.btnTodo.TabIndex = 7;
            this.btnTodo.Text = "ADD";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoing
            // 
            this.btnDoing.Location = new System.Drawing.Point(483, 43);
            this.btnDoing.Name = "btnDoing";
            this.btnDoing.Size = new System.Drawing.Size(39, 20);
            this.btnDoing.TabIndex = 8;
            this.btnDoing.Text = "ADD";
            this.btnDoing.UseVisualStyleBackColor = true;
            this.btnDoing.Click += new System.EventHandler(this.btnDoing_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(742, 43);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(38, 20);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "ADD";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TO DO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DOING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DONE";
            // 
            // taskToDo
            // 
            this.taskToDo.Text = "Task";
            this.taskToDo.Width = 250;
            // 
            // taskDoing
            // 
            this.taskDoing.Text = "Task";
            this.taskDoing.Width = 250;
            // 
            // taskDone
            // 
            this.taskDone.Text = "Task";
            this.taskDone.Width = 250;
            // 
            // btnTodoToDoing
            // 
            this.btnTodoToDoing.Location = new System.Drawing.Point(12, 372);
            this.btnTodoToDoing.Name = "btnTodoToDoing";
            this.btnTodoToDoing.Size = new System.Drawing.Size(128, 46);
            this.btnTodoToDoing.TabIndex = 13;
            this.btnTodoToDoing.Text = "DOING";
            this.btnTodoToDoing.UseVisualStyleBackColor = true;
            this.btnTodoToDoing.Click += new System.EventHandler(this.btnTodoToDoing_Click);
            // 
            // btnTodoToDone
            // 
            this.btnTodoToDone.Location = new System.Drawing.Point(136, 372);
            this.btnTodoToDone.Name = "btnTodoToDone";
            this.btnTodoToDone.Size = new System.Drawing.Size(128, 45);
            this.btnTodoToDone.TabIndex = 14;
            this.btnTodoToDone.Text = "DONE";
            this.btnTodoToDone.UseVisualStyleBackColor = true;
            this.btnTodoToDone.Click += new System.EventHandler(this.btnTodoToDone_Click);
            // 
            // btnDoingToTodo
            // 
            this.btnDoingToTodo.Location = new System.Drawing.Point(270, 372);
            this.btnDoingToTodo.Name = "btnDoingToTodo";
            this.btnDoingToTodo.Size = new System.Drawing.Size(128, 45);
            this.btnDoingToTodo.TabIndex = 15;
            this.btnDoingToTodo.Text = "TO DO";
            this.btnDoingToTodo.UseVisualStyleBackColor = true;
            this.btnDoingToTodo.Click += new System.EventHandler(this.btnDoingToTodo_Click);
            // 
            // btnDoingToDone
            // 
            this.btnDoingToDone.Location = new System.Drawing.Point(394, 372);
            this.btnDoingToDone.Name = "btnDoingToDone";
            this.btnDoingToDone.Size = new System.Drawing.Size(128, 45);
            this.btnDoingToDone.TabIndex = 16;
            this.btnDoingToDone.Text = "DONE";
            this.btnDoingToDone.UseVisualStyleBackColor = true;
            this.btnDoingToDone.Click += new System.EventHandler(this.btnDoingToDone_Click);
            // 
            // btnDoneToTodo
            // 
            this.btnDoneToTodo.Location = new System.Drawing.Point(528, 372);
            this.btnDoneToTodo.Name = "btnDoneToTodo";
            this.btnDoneToTodo.Size = new System.Drawing.Size(128, 44);
            this.btnDoneToTodo.TabIndex = 17;
            this.btnDoneToTodo.Text = "TO DO";
            this.btnDoneToTodo.UseVisualStyleBackColor = true;
            this.btnDoneToTodo.Click += new System.EventHandler(this.btnDoneToTodo_Click);
            // 
            // btnDoneToDoing
            // 
            this.btnDoneToDoing.Location = new System.Drawing.Point(653, 372);
            this.btnDoneToDoing.Name = "btnDoneToDoing";
            this.btnDoneToDoing.Size = new System.Drawing.Size(127, 44);
            this.btnDoneToDoing.TabIndex = 18;
            this.btnDoneToDoing.Text = "DOING";
            this.btnDoneToDoing.UseVisualStyleBackColor = true;
            this.btnDoneToDoing.Click += new System.EventHandler(this.btnDoneToDoing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 423);
            this.Controls.Add(this.btnDoneToDoing);
            this.Controls.Add(this.btnDoneToTodo);
            this.Controls.Add(this.btnDoingToDone);
            this.Controls.Add(this.btnDoingToTodo);
            this.Controls.Add(this.btnTodoToDone);
            this.Controls.Add(this.btnTodoToDoing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDoing);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstDoing);
            this.Controls.Add(this.lstTodo);
            this.Controls.Add(this.inpDone);
            this.Controls.Add(this.inpDoing);
            this.Controls.Add(this.inpTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inpTodo;
        private System.Windows.Forms.TextBox inpDone;
        private System.Windows.Forms.TextBox inpDoing;
        private System.Windows.Forms.ListView lstTodo;
        private System.Windows.Forms.ListView lstDoing;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnDoing;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskDoing;
        private System.Windows.Forms.ColumnHeader taskDone;
        private System.Windows.Forms.Button btnTodoToDoing;
        private System.Windows.Forms.Button btnTodoToDone;
        private System.Windows.Forms.Button btnDoingToTodo;
        private System.Windows.Forms.Button btnDoingToDone;
        private System.Windows.Forms.Button btnDoneToTodo;
        private System.Windows.Forms.Button btnDoneToDoing;
    }
}

