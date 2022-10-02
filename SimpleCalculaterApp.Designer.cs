namespace WinFormsApp1
{
    partial class SimpleCalculaterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCalculaterApp));
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.InputButtonContainer_panel = new System.Windows.Forms.Panel();
            this.Equals_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Subtract_button = new System.Windows.Forms.Button();
            this.Devide_button = new System.Windows.Forms.Button();
            this.Multiply_button = new System.Windows.Forms.Button();
            this.C_button = new System.Windows.Forms.Button();
            this.decimalPoint_button = new System.Windows.Forms.Button();
            this.Num9_button = new System.Windows.Forms.Button();
            this.Num8_button = new System.Windows.Forms.Button();
            this.Num7_button = new System.Windows.Forms.Button();
            this.Num6_button = new System.Windows.Forms.Button();
            this.Num5_button = new System.Windows.Forms.Button();
            this.Num4_button = new System.Windows.Forms.Button();
            this.Num3_button = new System.Windows.Forms.Button();
            this.Num2_button = new System.Windows.Forms.Button();
            this.Num1_button = new System.Windows.Forms.Button();
            this.Num0_button = new System.Windows.Forms.Button();
            this.InputButtonContainer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_textBox
            // 
            this.Input_textBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.Input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input_textBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Input_textBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Input_textBox.Location = new System.Drawing.Point(3, 3);
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.Size = new System.Drawing.Size(340, 43);
            this.Input_textBox.TabIndex = 0;
            this.Input_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputButtonContainer_panel
            // 
            this.InputButtonContainer_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InputButtonContainer_panel.Controls.Add(this.Equals_button);
            this.InputButtonContainer_panel.Controls.Add(this.Add_button);
            this.InputButtonContainer_panel.Controls.Add(this.Subtract_button);
            this.InputButtonContainer_panel.Controls.Add(this.Devide_button);
            this.InputButtonContainer_panel.Controls.Add(this.Multiply_button);
            this.InputButtonContainer_panel.Controls.Add(this.C_button);
            this.InputButtonContainer_panel.Controls.Add(this.decimalPoint_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num9_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num8_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num7_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num6_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num5_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num4_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num3_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num2_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num1_button);
            this.InputButtonContainer_panel.Controls.Add(this.Num0_button);
            this.InputButtonContainer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputButtonContainer_panel.Location = new System.Drawing.Point(3, 46);
            this.InputButtonContainer_panel.Name = "InputButtonContainer_panel";
            this.InputButtonContainer_panel.Size = new System.Drawing.Size(340, 277);
            this.InputButtonContainer_panel.TabIndex = 1;
            // 
            // Equals_button
            // 
            this.Equals_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Equals_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Equals_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equals_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Equals_button.Location = new System.Drawing.Point(272, 9);
            this.Equals_button.Name = "Equals_button";
            this.Equals_button.Size = new System.Drawing.Size(60, 258);
            this.Equals_button.TabIndex = 16;
            this.Equals_button.Text = "=";
            this.Equals_button.UseVisualStyleBackColor = false;
            this.Equals_button.Click += new System.EventHandler(this.Equals_button_Click);
            this.Equals_button.Enter += new System.EventHandler(this.Equals_button_Enter);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add_button.Location = new System.Drawing.Point(206, 207);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(60, 60);
            this.Add_button.TabIndex = 15;
            this.Add_button.Text = "+";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Subtract_button
            // 
            this.Subtract_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subtract_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Subtract_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtract_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Subtract_button.Location = new System.Drawing.Point(206, 141);
            this.Subtract_button.Name = "Subtract_button";
            this.Subtract_button.Size = new System.Drawing.Size(60, 60);
            this.Subtract_button.TabIndex = 14;
            this.Subtract_button.Text = "-";
            this.Subtract_button.UseVisualStyleBackColor = false;
            this.Subtract_button.Click += new System.EventHandler(this.Subtract_button_Click);
            // 
            // Devide_button
            // 
            this.Devide_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Devide_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Devide_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Devide_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Devide_button.Location = new System.Drawing.Point(206, 75);
            this.Devide_button.Name = "Devide_button";
            this.Devide_button.Size = new System.Drawing.Size(60, 60);
            this.Devide_button.TabIndex = 13;
            this.Devide_button.Text = "/";
            this.Devide_button.UseVisualStyleBackColor = false;
            this.Devide_button.Click += new System.EventHandler(this.Devide_button_Click);
            // 
            // Multiply_button
            // 
            this.Multiply_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Multiply_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Multiply_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Multiply_button.Location = new System.Drawing.Point(206, 9);
            this.Multiply_button.Name = "Multiply_button";
            this.Multiply_button.Size = new System.Drawing.Size(60, 60);
            this.Multiply_button.TabIndex = 12;
            this.Multiply_button.Text = "X";
            this.Multiply_button.UseVisualStyleBackColor = false;
            this.Multiply_button.Click += new System.EventHandler(this.Multiply_button_Click);
            // 
            // C_button
            // 
            this.C_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.C_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.C_button.Location = new System.Drawing.Point(140, 207);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(60, 60);
            this.C_button.TabIndex = 11;
            this.C_button.Text = "C";
            this.C_button.UseVisualStyleBackColor = false;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // decimalPoint_button
            // 
            this.decimalPoint_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decimalPoint_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.decimalPoint_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalPoint_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.decimalPoint_button.Location = new System.Drawing.Point(74, 207);
            this.decimalPoint_button.Name = "decimalPoint_button";
            this.decimalPoint_button.Size = new System.Drawing.Size(60, 60);
            this.decimalPoint_button.TabIndex = 10;
            this.decimalPoint_button.Text = ".";
            this.decimalPoint_button.UseVisualStyleBackColor = false;
            this.decimalPoint_button.Click += new System.EventHandler(this.decimalPoint_button_Click);
            // 
            // Num9_button
            // 
            this.Num9_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num9_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num9_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num9_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num9_button.Location = new System.Drawing.Point(140, 141);
            this.Num9_button.Name = "Num9_button";
            this.Num9_button.Size = new System.Drawing.Size(60, 60);
            this.Num9_button.TabIndex = 9;
            this.Num9_button.Text = "9";
            this.Num9_button.UseVisualStyleBackColor = false;
            this.Num9_button.Click += new System.EventHandler(this.Num9_button_Click);
            // 
            // Num8_button
            // 
            this.Num8_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num8_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num8_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num8_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num8_button.Location = new System.Drawing.Point(74, 141);
            this.Num8_button.Name = "Num8_button";
            this.Num8_button.Size = new System.Drawing.Size(60, 60);
            this.Num8_button.TabIndex = 8;
            this.Num8_button.Text = "8";
            this.Num8_button.UseVisualStyleBackColor = false;
            this.Num8_button.Click += new System.EventHandler(this.Num8_button_Click);
            // 
            // Num7_button
            // 
            this.Num7_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num7_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num7_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num7_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num7_button.Location = new System.Drawing.Point(8, 141);
            this.Num7_button.Name = "Num7_button";
            this.Num7_button.Size = new System.Drawing.Size(60, 60);
            this.Num7_button.TabIndex = 7;
            this.Num7_button.Text = "7";
            this.Num7_button.UseVisualStyleBackColor = false;
            this.Num7_button.Click += new System.EventHandler(this.Num7_button_Click);
            // 
            // Num6_button
            // 
            this.Num6_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num6_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num6_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num6_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num6_button.Location = new System.Drawing.Point(140, 75);
            this.Num6_button.Name = "Num6_button";
            this.Num6_button.Size = new System.Drawing.Size(60, 60);
            this.Num6_button.TabIndex = 6;
            this.Num6_button.Text = "6";
            this.Num6_button.UseVisualStyleBackColor = false;
            this.Num6_button.Click += new System.EventHandler(this.Num6_button_Click);
            // 
            // Num5_button
            // 
            this.Num5_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num5_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num5_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num5_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num5_button.Location = new System.Drawing.Point(74, 75);
            this.Num5_button.Name = "Num5_button";
            this.Num5_button.Size = new System.Drawing.Size(60, 60);
            this.Num5_button.TabIndex = 5;
            this.Num5_button.Text = "5";
            this.Num5_button.UseVisualStyleBackColor = false;
            this.Num5_button.Click += new System.EventHandler(this.Num5_button_Click);
            // 
            // Num4_button
            // 
            this.Num4_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num4_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num4_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num4_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num4_button.Location = new System.Drawing.Point(8, 75);
            this.Num4_button.Name = "Num4_button";
            this.Num4_button.Size = new System.Drawing.Size(60, 60);
            this.Num4_button.TabIndex = 4;
            this.Num4_button.Text = "4";
            this.Num4_button.UseVisualStyleBackColor = false;
            this.Num4_button.Click += new System.EventHandler(this.Num4_button_Click);
            // 
            // Num3_button
            // 
            this.Num3_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num3_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num3_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num3_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num3_button.Location = new System.Drawing.Point(140, 9);
            this.Num3_button.Name = "Num3_button";
            this.Num3_button.Size = new System.Drawing.Size(60, 60);
            this.Num3_button.TabIndex = 3;
            this.Num3_button.Text = "3";
            this.Num3_button.UseVisualStyleBackColor = false;
            this.Num3_button.Click += new System.EventHandler(this.Num3_button_Click);
            // 
            // Num2_button
            // 
            this.Num2_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num2_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num2_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num2_button.Location = new System.Drawing.Point(74, 9);
            this.Num2_button.Name = "Num2_button";
            this.Num2_button.Size = new System.Drawing.Size(60, 60);
            this.Num2_button.TabIndex = 2;
            this.Num2_button.Text = "2";
            this.Num2_button.UseVisualStyleBackColor = false;
            this.Num2_button.Click += new System.EventHandler(this.Num2_button_Click);
            // 
            // Num1_button
            // 
            this.Num1_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num1_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num1_button.Location = new System.Drawing.Point(8, 9);
            this.Num1_button.Name = "Num1_button";
            this.Num1_button.Size = new System.Drawing.Size(60, 60);
            this.Num1_button.TabIndex = 1;
            this.Num1_button.Text = "1";
            this.Num1_button.UseVisualStyleBackColor = false;
            this.Num1_button.Click += new System.EventHandler(this.Num1_button_Click);
            // 
            // Num0_button
            // 
            this.Num0_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num0_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Num0_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num0_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Num0_button.Location = new System.Drawing.Point(8, 207);
            this.Num0_button.Name = "Num0_button";
            this.Num0_button.Size = new System.Drawing.Size(60, 60);
            this.Num0_button.TabIndex = 0;
            this.Num0_button.Text = "0";
            this.Num0_button.UseVisualStyleBackColor = false;
            this.Num0_button.Click += new System.EventHandler(this.Num0_button_Click);
            // 
            // SimpleCalculaterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(346, 326);
            this.Controls.Add(this.InputButtonContainer_panel);
            this.Controls.Add(this.Input_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleCalculaterApp";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculater App";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.InputButtonContainer_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input_textBox;
        private Panel InputButtonContainer_panel;
        private Button Add_button;
        private Button Subtract_button;
        private Button Devide_button;
        private Button Multiply_button;
        private Button C_button;
        private Button decimalPoint_button;
        private Button Num9_button;
        private Button Num8_button;
        private Button Num7_button;
        private Button Num6_button;
        private Button Num5_button;
        private Button Num4_button;
        private Button Num3_button;
        private Button Num2_button;
        private Button Num1_button;
        private Button Num0_button;
        private Button Equals_button;
    }
}