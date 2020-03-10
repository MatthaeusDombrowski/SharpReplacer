namespace Replacer
{
    partial class ReplaceItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.original = new System.Windows.Forms.TextBox();
            this.case_sense = new System.Windows.Forms.CheckBox();
            this.arrow = new System.Windows.Forms.Label();
            this.replaced = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.original.Location = new System.Drawing.Point(13, 14);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(154, 23);
            this.original.TabIndex = 4;
            // 
            // case_sense
            // 
            this.case_sense.AutoSize = true;
            this.case_sense.Checked = true;
            this.case_sense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.case_sense.Location = new System.Drawing.Point(13, 40);
            this.case_sense.Name = "case_sense";
            this.case_sense.Size = new System.Drawing.Size(100, 19);
            this.case_sense.TabIndex = 5;
            this.case_sense.Text = "Case Sensitive";
            this.case_sense.UseVisualStyleBackColor = true;
            // 
            // arrow
            // 
            this.arrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(173, 14);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(54, 23);
            this.arrow.TabIndex = 4;
            this.arrow.Text = "->";
            this.arrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replaced
            // 
            this.replaced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.replaced.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.replaced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaced.Location = new System.Drawing.Point(233, 14);
            this.replaced.Name = "replaced";
            this.replaced.Size = new System.Drawing.Size(154, 23);
            this.replaced.TabIndex = 6;
            // 
            // ReplaceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.replaced);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.case_sense);
            this.Controls.Add(this.original);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReplaceItem";
            this.Size = new System.Drawing.Size(400, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.CheckBox case_sense;
        private System.Windows.Forms.Label arrow;
        private System.Windows.Forms.TextBox replaced;
    }
}
