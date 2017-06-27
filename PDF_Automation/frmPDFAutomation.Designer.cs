namespace PDF_Automation
{
    partial class FrmPDFAutomation
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
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linkCopyright = new System.Windows.Forms.LinkLabel();
            this.gbSelectRecords = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.gbSelectRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePDF.Location = new System.Drawing.Point(389, 102);
            this.btnGeneratePDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(293, 108);
            this.btnGeneratePDF.TabIndex = 0;
            this.btnGeneratePDF.Text = "Generate PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.BtnGeneratePDF_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(724, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MySQL Database to PDF Table using iText Library";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkCopyright
            // 
            this.linkCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkCopyright.LinkArea = new System.Windows.Forms.LinkArea(17, 44);
            this.linkCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCopyright.Location = new System.Drawing.Point(0, 277);
            this.linkCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkCopyright.Name = "linkCopyright";
            this.linkCopyright.Size = new System.Drawing.Size(724, 55);
            this.linkCopyright.TabIndex = 2;
            this.linkCopyright.TabStop = true;
            this.linkCopyright.Text = "Copyright 2017 @ http://howtocodefor.website";
            this.linkCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCopyright.UseCompatibleTextRendering = true;
            // 
            // gbSelectRecords
            // 
            this.gbSelectRecords.Controls.Add(this.label4);
            this.gbSelectRecords.Controls.Add(this.label3);
            this.gbSelectRecords.Controls.Add(this.txtTo);
            this.gbSelectRecords.Controls.Add(this.txtFrom);
            this.gbSelectRecords.Location = new System.Drawing.Point(34, 92);
            this.gbSelectRecords.Name = "gbSelectRecords";
            this.gbSelectRecords.Size = new System.Drawing.Size(262, 118);
            this.gbSelectRecords.TabIndex = 8;
            this.gbSelectRecords.TabStop = false;
            this.gbSelectRecords.Text = "Select Record IDs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(155, 64);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(66, 29);
            this.txtTo.TabIndex = 9;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(40, 64);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(66, 29);
            this.txtFrom.TabIndex = 8;
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNote.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(0, 234);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(724, 43);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "Note : The database used here for demonstration is MySQL\'s sakila database.";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPDFAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 332);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.gbSelectRecords);
            this.Controls.Add(this.linkCopyright);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGeneratePDF);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPDFAutomation";
            this.Text = "PDF Automation";
            this.gbSelectRecords.ResumeLayout(false);
            this.gbSelectRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linkCopyright;
        private System.Windows.Forms.GroupBox gbSelectRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblNote;
    }
}

