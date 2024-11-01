namespace WinFormJson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Name = new TextBox();
            Surname = new TextBox();
            Submit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(14, 16);
            Name.Margin = new Padding(3, 4, 3, 4);
            Name.Name = "Name";
            Name.Size = new Size(166, 27);
            Name.TabIndex = 0;
            // 
            // Surname
            // 
            Surname.Location = new Point(187, 16);
            Surname.Margin = new Padding(3, 4, 3, 4);
            Surname.Name = "Surname";
            Surname.Size = new Size(166, 27);
            Surname.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.Location = new Point(359, 16);
            Submit.Margin = new Padding(3, 4, 3, 4);
            Submit.Name = "Submit";
            Submit.Size = new Size(101, 27);
            Submit.TabIndex = 2;
            Submit.Text = "Add";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(341, 229);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 504);
            Controls.Add(dataGridView1);
            Controls.Add(Submit);
            Controls.Add(Surname);
            Controls.Add(Name);
            Margin = new Padding(3, 4, 3, 4);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private TextBox Surname;
        private Button Submit;
        private DataGridView dataGridView1;
    }
}
