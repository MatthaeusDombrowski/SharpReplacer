namespace Replacer
{
    partial class Main
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
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.filterText = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.addLineButton = new System.Windows.Forms.Button();
            this.removeLineButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.listContainer = new System.Windows.Forms.Panel();
            this.listLabelOriginal = new System.Windows.Forms.Label();
            this.listLabelReplaced = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathText
            // 
            this.pathText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathText.Location = new System.Drawing.Point(83, 20);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(153, 23);
            this.pathText.TabIndex = 0;
            this.pathText.Text = "C:\\";
            // 
            // pathButton
            // 
            this.pathButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pathButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pathButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathButton.Location = new System.Drawing.Point(242, 20);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(75, 23);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "Browse";
            this.pathButton.UseVisualStyleBackColor = false;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(12, 19);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(65, 23);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Directory:";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterText
            // 
            this.filterText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.filterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterText.Location = new System.Drawing.Point(391, 20);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(47, 23);
            this.filterText.TabIndex = 2;
            this.filterText.Text = "*.*";
            this.filterText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filterLabel
            // 
            this.filterLabel.Location = new System.Drawing.Point(349, 20);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(41, 23);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Filter:";
            this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addLineButton
            // 
            this.addLineButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addLineButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addLineButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLineButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLineButton.Location = new System.Drawing.Point(15, 364);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(26, 25);
            this.addLineButton.TabIndex = 7;
            this.addLineButton.Text = "+";
            this.addLineButton.UseCompatibleTextRendering = true;
            this.addLineButton.UseVisualStyleBackColor = false;
            this.addLineButton.Click += new System.EventHandler(this.AddLineEvent);
            // 
            // removeLineButton
            // 
            this.removeLineButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeLineButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeLineButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.removeLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLineButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLineButton.Location = new System.Drawing.Point(40, 364);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(26, 25);
            this.removeLineButton.TabIndex = 7;
            this.removeLineButton.Text = "-";
            this.removeLineButton.UseCompatibleTextRendering = true;
            this.removeLineButton.UseVisualStyleBackColor = false;
            this.removeLineButton.Click += new System.EventHandler(this.RemoveLineEvent);
            // 
            // replaceButton
            // 
            this.replaceButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.replaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.replaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceButton.Location = new System.Drawing.Point(370, 364);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(68, 25);
            this.replaceButton.TabIndex = 9;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = false;
            this.replaceButton.Click += new System.EventHandler(this.ReplaceButtonEvent);
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.replaceAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.replaceAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.replaceAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceAllButton.Location = new System.Drawing.Point(190, 364);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(174, 25);
            this.replaceAllButton.TabIndex = 8;
            this.replaceAllButton.Text = "Replace in all sub-directories";
            this.replaceAllButton.UseVisualStyleBackColor = false;
            this.replaceAllButton.Click += new System.EventHandler(this.ReplaceAllEvent);
            // 
            // listContainer
            // 
            this.listContainer.AutoScroll = true;
            this.listContainer.Location = new System.Drawing.Point(15, 85);
            this.listContainer.Name = "listContainer";
            this.listContainer.Size = new System.Drawing.Size(423, 273);
            this.listContainer.TabIndex = 3;
            // 
            // listLabelOriginal
            // 
            this.listLabelOriginal.Location = new System.Drawing.Point(21, 64);
            this.listLabelOriginal.Name = "listLabelOriginal";
            this.listLabelOriginal.Size = new System.Drawing.Size(56, 18);
            this.listLabelOriginal.TabIndex = 10;
            this.listLabelOriginal.Text = "Original";
            // 
            // listLabelReplaced
            // 
            this.listLabelReplaced.Location = new System.Drawing.Point(370, 64);
            this.listLabelReplaced.Name = "listLabelReplaced";
            this.listLabelReplaced.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listLabelReplaced.Size = new System.Drawing.Size(56, 18);
            this.listLabelReplaced.TabIndex = 11;
            this.listLabelReplaced.Text = "Replaced";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 400);
            this.Controls.Add(this.listLabelReplaced);
            this.Controls.Add(this.listLabelOriginal);
            this.Controls.Add(this.listContainer);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.addLineButton);
            this.Controls.Add(this.removeLineButton);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.pathText);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.Button removeLineButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Panel listContainer;
        private System.Windows.Forms.Label listLabelOriginal;
        private System.Windows.Forms.Label listLabelReplaced;
    }
}

