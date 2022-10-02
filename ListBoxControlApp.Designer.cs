namespace WinFormsApp1
{
    partial class ListBoxControlApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxControlApp));
            this.ListBoxControl_label = new System.Windows.Forms.Label();
            this.Names_listBox = new System.Windows.Forms.ListBox();
            this.NameCount_lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameInput_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.SortAssendingbutton = new System.Windows.Forms.Button();
            this.DeleteLastItemInTheList_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveName_textBox = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.ClearList_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxControl_label
            // 
            this.ListBoxControl_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListBoxControl_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxControl_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxControl_label.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListBoxControl_label.ForeColor = System.Drawing.Color.Coral;
            this.ListBoxControl_label.Location = new System.Drawing.Point(0, 0);
            this.ListBoxControl_label.Name = "ListBoxControl_label";
            this.ListBoxControl_label.Size = new System.Drawing.Size(827, 41);
            this.ListBoxControl_label.TabIndex = 0;
            this.ListBoxControl_label.Text = "Enter the name which you want to add in the list";
            this.ListBoxControl_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Names_listBox
            // 
            this.Names_listBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.Names_listBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Names_listBox.FormattingEnabled = true;
            this.Names_listBox.ItemHeight = 15;
            this.Names_listBox.Items.AddRange(new object[] {
            "Burhan",
            "abdullah",
            "Usamn",
            "Umer",
            "Ahmad",
            "Laiba",
            "Nimra",
            "Hamza",
            "Aisha",
            "Fatima",
            "Usama",
            "Noman",
            "Ahmad",
            "Rayam ",
            "Jasim",
            "Adil",
            "Umer"});
            this.Names_listBox.Location = new System.Drawing.Point(0, 41);
            this.Names_listBox.Name = "Names_listBox";
            this.Names_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Names_listBox.Size = new System.Drawing.Size(120, 420);
            this.Names_listBox.TabIndex = 2;
            // 
            // NameCount_lable
            // 
            this.NameCount_lable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameCount_lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameCount_lable.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameCount_lable.ForeColor = System.Drawing.Color.Coral;
            this.NameCount_lable.Location = new System.Drawing.Point(139, 75);
            this.NameCount_lable.Name = "NameCount_lable";
            this.NameCount_lable.Size = new System.Drawing.Size(674, 48);
            this.NameCount_lable.TabIndex = 9;
            this.NameCount_lable.Text = "Name Count will be displayed here";
            this.NameCount_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(139, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter the name which you want to add in the list";
            // 
            // NameInput_textBox
            // 
            this.NameInput_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameInput_textBox.Location = new System.Drawing.Point(493, 49);
            this.NameInput_textBox.Name = "NameInput_textBox";
            this.NameInput_textBox.Size = new System.Drawing.Size(242, 23);
            this.NameInput_textBox.TabIndex = 10;
            // 
            // Add_button
            // 
            this.Add_button.AutoSize = true;
            this.Add_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_button.ForeColor = System.Drawing.Color.Coral;
            this.Add_button.Location = new System.Drawing.Point(738, 49);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 25);
            this.Add_button.TabIndex = 11;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // SortAssendingbutton
            // 
            this.SortAssendingbutton.AutoSize = true;
            this.SortAssendingbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortAssendingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortAssendingbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortAssendingbutton.ForeColor = System.Drawing.Color.Coral;
            this.SortAssendingbutton.Location = new System.Drawing.Point(139, 126);
            this.SortAssendingbutton.Name = "SortAssendingbutton";
            this.SortAssendingbutton.Size = new System.Drawing.Size(302, 43);
            this.SortAssendingbutton.TabIndex = 13;
            this.SortAssendingbutton.Text = "Sort in Accending Order";
            this.SortAssendingbutton.UseVisualStyleBackColor = false;
            this.SortAssendingbutton.Click += new System.EventHandler(this.SortAssendingbutton_Click);
            // 
            // DeleteLastItemInTheList_button
            // 
            this.DeleteLastItemInTheList_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteLastItemInTheList_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteLastItemInTheList_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteLastItemInTheList_button.ForeColor = System.Drawing.Color.Coral;
            this.DeleteLastItemInTheList_button.Location = new System.Drawing.Point(464, 126);
            this.DeleteLastItemInTheList_button.Name = "DeleteLastItemInTheList_button";
            this.DeleteLastItemInTheList_button.Size = new System.Drawing.Size(349, 43);
            this.DeleteLastItemInTheList_button.TabIndex = 14;
            this.DeleteLastItemInTheList_button.Text = "Remove Last Item in The List";
            this.DeleteLastItemInTheList_button.UseVisualStyleBackColor = false;
            this.DeleteLastItemInTheList_button.Click += new System.EventHandler(this.DeleteLastItemInTheList_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(139, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter the name which you want to remove form the list";
            // 
            // RemoveName_textBox
            // 
            this.RemoveName_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemoveName_textBox.Location = new System.Drawing.Point(542, 175);
            this.RemoveName_textBox.Name = "RemoveName_textBox";
            this.RemoveName_textBox.Size = new System.Drawing.Size(193, 23);
            this.RemoveName_textBox.TabIndex = 15;
            // 
            // Remove_button
            // 
            this.Remove_button.AutoSize = true;
            this.Remove_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Remove_button.ForeColor = System.Drawing.Color.Coral;
            this.Remove_button.Location = new System.Drawing.Point(738, 175);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 25);
            this.Remove_button.TabIndex = 16;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = false;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // ClearList_button
            // 
            this.ClearList_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearList_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearList_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearList_button.ForeColor = System.Drawing.Color.Coral;
            this.ClearList_button.Location = new System.Drawing.Point(139, 209);
            this.ClearList_button.Name = "ClearList_button";
            this.ClearList_button.Size = new System.Drawing.Size(674, 43);
            this.ClearList_button.TabIndex = 18;
            this.ClearList_button.Text = "Clear List";
            this.ClearList_button.UseVisualStyleBackColor = false;
            this.ClearList_button.Click += new System.EventHandler(this.ClearList_button_Click);
            // 
            // ListBoxControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 461);
            this.Controls.Add(this.ClearList_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveName_textBox);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.DeleteLastItemInTheList_button);
            this.Controls.Add(this.SortAssendingbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameInput_textBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.NameCount_lable);
            this.Controls.Add(this.Names_listBox);
            this.Controls.Add(this.ListBoxControl_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListBoxControlApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBoxControl";
            this.Load += new System.EventHandler(this.ListBoxControlApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ListBoxControl_label;
        private ListBox Names_listBox;
        private Label NameCount_lable;
        private Label label2;
        private TextBox NameInput_textBox;
        private Button Add_button;
        private Button SortAssendingbutton;
        private Button DeleteLastItemInTheList_button;
        private Label label1;
        private TextBox RemoveName_textBox;
        private Button Remove_button;
        private Button ClearList_button;
    }
}