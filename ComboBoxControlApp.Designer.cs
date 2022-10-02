namespace PracticeWinFormProject
{
    partial class ComboBoxControlApp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemsToTheList_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListItemCount_label = new System.Windows.Forms.Label();
            this.RemoveItemInput_textBox = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.RemoveItemInput_label = new System.Windows.Forms.Label();
            this.clearList_label = new System.Windows.Forms.Label();
            this.ClearList_button = new System.Windows.Forms.Button();
            this.Sort_button = new System.Windows.Forms.Button();
            this.SortList_label = new System.Windows.Forms.Label();
            this.selectedItem_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Coral;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Banana",
            "Pineapple",
            "Guawa",
            "Watermalan ",
            "Honey-Due"});
            this.comboBox1.Location = new System.Drawing.Point(479, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(479, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddItemsToTheList_label
            // 
            this.AddItemsToTheList_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddItemsToTheList_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItemsToTheList_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItemsToTheList_label.ForeColor = System.Drawing.Color.Coral;
            this.AddItemsToTheList_label.Location = new System.Drawing.Point(23, 9);
            this.AddItemsToTheList_label.Name = "AddItemsToTheList_label";
            this.AddItemsToTheList_label.Size = new System.Drawing.Size(431, 23);
            this.AddItemsToTheList_label.TabIndex = 2;
            this.AddItemsToTheList_label.Text = "Add items to the list";
            this.AddItemsToTheList_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(379, 33);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(23, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // ListItemCount_label
            // 
            this.ListItemCount_label.BackColor = System.Drawing.Color.Black;
            this.ListItemCount_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListItemCount_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListItemCount_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListItemCount_label.ForeColor = System.Drawing.Color.Coral;
            this.ListItemCount_label.Location = new System.Drawing.Point(0, 408);
            this.ListItemCount_label.Name = "ListItemCount_label";
            this.ListItemCount_label.Size = new System.Drawing.Size(800, 42);
            this.ListItemCount_label.TabIndex = 5;
            this.ListItemCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveItemInput_textBox
            // 
            this.RemoveItemInput_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoveItemInput_textBox.Location = new System.Drawing.Point(23, 86);
            this.RemoveItemInput_textBox.Name = "RemoveItemInput_textBox";
            this.RemoveItemInput_textBox.Size = new System.Drawing.Size(350, 23);
            this.RemoveItemInput_textBox.TabIndex = 8;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(379, 86);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 7;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // RemoveItemInput_label
            // 
            this.RemoveItemInput_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveItemInput_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoveItemInput_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveItemInput_label.ForeColor = System.Drawing.Color.Coral;
            this.RemoveItemInput_label.Location = new System.Drawing.Point(23, 62);
            this.RemoveItemInput_label.Name = "RemoveItemInput_label";
            this.RemoveItemInput_label.Size = new System.Drawing.Size(431, 23);
            this.RemoveItemInput_label.TabIndex = 6;
            this.RemoveItemInput_label.Text = "Enter the Item which you want to remove";
            this.RemoveItemInput_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearList_label
            // 
            this.clearList_label.BackColor = System.Drawing.Color.Black;
            this.clearList_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clearList_label.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearList_label.ForeColor = System.Drawing.Color.Coral;
            this.clearList_label.Location = new System.Drawing.Point(24, 163);
            this.clearList_label.Name = "clearList_label";
            this.clearList_label.Size = new System.Drawing.Size(350, 42);
            this.clearList_label.TabIndex = 9;
            this.clearList_label.Text = "Clear list";
            this.clearList_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearList_button
            // 
            this.ClearList_button.Location = new System.Drawing.Point(379, 163);
            this.ClearList_button.Name = "ClearList_button";
            this.ClearList_button.Size = new System.Drawing.Size(75, 42);
            this.ClearList_button.TabIndex = 10;
            this.ClearList_button.Text = "Clear List";
            this.ClearList_button.UseVisualStyleBackColor = true;
            this.ClearList_button.Click += new System.EventHandler(this.ClearList_button_Click);
            // 
            // Sort_button
            // 
            this.Sort_button.Location = new System.Drawing.Point(379, 115);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(75, 42);
            this.Sort_button.TabIndex = 12;
            this.Sort_button.Text = "Sort";
            this.Sort_button.UseVisualStyleBackColor = true;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // SortList_label
            // 
            this.SortList_label.BackColor = System.Drawing.Color.Black;
            this.SortList_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SortList_label.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortList_label.ForeColor = System.Drawing.Color.Coral;
            this.SortList_label.Location = new System.Drawing.Point(24, 115);
            this.SortList_label.Name = "SortList_label";
            this.SortList_label.Size = new System.Drawing.Size(350, 42);
            this.SortList_label.TabIndex = 11;
            this.SortList_label.Text = "Sort list";
            this.SortList_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedItem_label
            // 
            this.selectedItem_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectedItem_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedItem_label.ForeColor = System.Drawing.Color.Coral;
            this.selectedItem_label.Location = new System.Drawing.Point(479, 80);
            this.selectedItem_label.Name = "selectedItem_label";
            this.selectedItem_label.Size = new System.Drawing.Size(309, 29);
            this.selectedItem_label.TabIndex = 13;
            this.selectedItem_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectedItem_label.Visible = false;
            // 
            // ComboBoxControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedItem_label);
            this.Controls.Add(this.Sort_button);
            this.Controls.Add(this.SortList_label);
            this.Controls.Add(this.ClearList_button);
            this.Controls.Add(this.clearList_label);
            this.Controls.Add(this.RemoveItemInput_textBox);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.RemoveItemInput_label);
            this.Controls.Add(this.ListItemCount_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.AddItemsToTheList_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ComboBoxControlApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label AddItemsToTheList_label;
        private Button Add_button;
        private TextBox textBox1;
        private Label ListItemCount_label;
        private TextBox RemoveItemInput_textBox;
        private Button Remove_button;
        private Label RemoveItemInput_label;
        private Label clearList_label;
        private Button ClearList_button;
        private Button Sort_button;
        private Label SortList_label;
        private Label selectedItem_label;
    }
}