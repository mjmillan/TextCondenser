﻿namespace TextCondensor
{
    partial class TextCondenserForm
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonCondenseText = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCharactersPerHour = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.performIterativeCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWhiteSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performIterativeCheckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.EnableAutoDragDrop = true;
            this.richTextBoxInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(565, 488);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // buttonCondenseText
            // 
            this.buttonCondenseText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCondenseText.Location = new System.Drawing.Point(542, 3);
            this.buttonCondenseText.Name = "buttonCondenseText";
            this.buttonCondenseText.Size = new System.Drawing.Size(60, 38);
            this.buttonCondenseText.TabIndex = 1;
            this.buttonCondenseText.Text = ">>";
            this.buttonCondenseText.UseVisualStyleBackColor = true;
            this.buttonCondenseText.Click += new System.EventHandler(this.buttonCondenseText_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.EnableAutoDragDrop = true;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(592, 488);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 488);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCharactersPerHour);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCondenseText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 48);
            this.panel1.TabIndex = 4;
            // 
            // labelCharactersPerHour
            // 
            this.labelCharactersPerHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCharactersPerHour.AutoSize = true;
            this.labelCharactersPerHour.Location = new System.Drawing.Point(629, 10);
            this.labelCharactersPerHour.Name = "labelCharactersPerHour";
            this.labelCharactersPerHour.Size = new System.Drawing.Size(185, 25);
            this.labelCharactersPerHour.TabIndex = 5;
            this.labelCharactersPerHour.Text = "Characters Per Hour:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 8);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performIterativeCheckToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // performIterativeCheckToolStripMenuItem
            // 
            this.performIterativeCheckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeWhiteSpacesToolStripMenuItem,
            this.performIterativeCheckToolStripMenuItem1});
            this.performIterativeCheckToolStripMenuItem.Name = "performIterativeCheckToolStripMenuItem";
            this.performIterativeCheckToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.performIterativeCheckToolStripMenuItem.Text = "Options";
            // 
            // removeWhiteSpacesToolStripMenuItem
            // 
            this.removeWhiteSpacesToolStripMenuItem.CheckOnClick = true;
            this.removeWhiteSpacesToolStripMenuItem.Name = "removeWhiteSpacesToolStripMenuItem";
            this.removeWhiteSpacesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeWhiteSpacesToolStripMenuItem.Text = "Remove White Spaces";
            // 
            // performIterativeCheckToolStripMenuItem1
            // 
            this.performIterativeCheckToolStripMenuItem1.Checked = true;
            this.performIterativeCheckToolStripMenuItem1.CheckOnClick = true;
            this.performIterativeCheckToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.performIterativeCheckToolStripMenuItem1.Name = "performIterativeCheckToolStripMenuItem1";
            this.performIterativeCheckToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.performIterativeCheckToolStripMenuItem1.Text = "Perform Iterative Check";
            // 
            // TextCondenserForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 569);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextCondenserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Condenser Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxInput;
        private Button buttonCondenseText;
        private RichTextBox richTextBoxOutput;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label labelCharactersPerHour;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem performIterativeCheckToolStripMenuItem;
        private ToolStripMenuItem removeWhiteSpacesToolStripMenuItem;
        private ToolStripMenuItem performIterativeCheckToolStripMenuItem1;
    }
}