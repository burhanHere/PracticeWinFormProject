namespace PracticeWinFormProject
{
    partial class MainFormToOpenPracticeForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormToOpenPracticeForms));
            this.FirstAppWhichDisplayNamesInLabels_button = new System.Windows.Forms.Button();
            this.SimpleCalculator_button = new System.Windows.Forms.Button();
            this.ListBoxControl_button = new System.Windows.Forms.Button();
            this.ComboBox_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstAppWhichDisplayNamesInLabels_button
            // 
            this.FirstAppWhichDisplayNamesInLabels_button.AutoSize = true;
            this.FirstAppWhichDisplayNamesInLabels_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstAppWhichDisplayNamesInLabels_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstAppWhichDisplayNamesInLabels_button.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstAppWhichDisplayNamesInLabels_button.Location = new System.Drawing.Point(0, 0);
            this.FirstAppWhichDisplayNamesInLabels_button.Name = "FirstAppWhichDisplayNamesInLabels_button";
            this.FirstAppWhichDisplayNamesInLabels_button.Size = new System.Drawing.Size(929, 51);
            this.FirstAppWhichDisplayNamesInLabels_button.TabIndex = 0;
            this.FirstAppWhichDisplayNamesInLabels_button.Text = "First App Which Display Names In Labels";
            this.FirstAppWhichDisplayNamesInLabels_button.UseVisualStyleBackColor = false;
            this.FirstAppWhichDisplayNamesInLabels_button.Click += new System.EventHandler(this.FirstAppWhichDisplayNamesInLabels_button_Click);
            // 
            // SimpleCalculator_button
            // 
            this.SimpleCalculator_button.AutoSize = true;
            this.SimpleCalculator_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SimpleCalculator_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SimpleCalculator_button.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SimpleCalculator_button.Location = new System.Drawing.Point(0, 51);
            this.SimpleCalculator_button.Name = "SimpleCalculator_button";
            this.SimpleCalculator_button.Size = new System.Drawing.Size(929, 51);
            this.SimpleCalculator_button.TabIndex = 1;
            this.SimpleCalculator_button.Text = "Simple Calculator";
            this.SimpleCalculator_button.UseVisualStyleBackColor = false;
            this.SimpleCalculator_button.Click += new System.EventHandler(this.SimpleCalculator_button_Click);
            // 
            // ListBoxControl_button
            // 
            this.ListBoxControl_button.AutoSize = true;
            this.ListBoxControl_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListBoxControl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxControl_button.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListBoxControl_button.Location = new System.Drawing.Point(0, 102);
            this.ListBoxControl_button.Name = "ListBoxControl_button";
            this.ListBoxControl_button.Size = new System.Drawing.Size(929, 51);
            this.ListBoxControl_button.TabIndex = 2;
            this.ListBoxControl_button.Text = "ListBox Control";
            this.ListBoxControl_button.UseVisualStyleBackColor = false;
            this.ListBoxControl_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBox_button
            // 
            this.ComboBox_button.AutoSize = true;
            this.ComboBox_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBox_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_button.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBox_button.Location = new System.Drawing.Point(0, 153);
            this.ComboBox_button.Name = "ComboBox_button";
            this.ComboBox_button.Size = new System.Drawing.Size(929, 51);
            this.ComboBox_button.TabIndex = 3;
            this.ComboBox_button.Text = "ComboBox Control";
            this.ComboBox_button.UseVisualStyleBackColor = false;
            this.ComboBox_button.Click += new System.EventHandler(this.ComboBox_button_Click);
            // 
            // MainFormToOpenPracticeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 487);
            this.Controls.Add(this.ComboBox_button);
            this.Controls.Add(this.ListBoxControl_button);
            this.Controls.Add(this.SimpleCalculator_button);
            this.Controls.Add(this.FirstAppWhichDisplayNamesInLabels_button);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormToOpenPracticeForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form To Open Practice Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FirstAppWhichDisplayNamesInLabels_button;
        private Button SimpleCalculator_button;
        private Button ListBoxControl_button;
        private Button ComboBox_button;
    }
}