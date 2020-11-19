
namespace distraction_blocking_hosts_file
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
            this.lstBlockedSites = new System.Windows.Forms.ListBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBlockedSites
            // 
            this.lstBlockedSites.FormattingEnabled = true;
            this.lstBlockedSites.Location = new System.Drawing.Point(12, 39);
            this.lstBlockedSites.Name = "lstBlockedSites";
            this.lstBlockedSites.Size = new System.Drawing.Size(359, 277);
            this.lstBlockedSites.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(278, 20);
            this.txtURL.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(113, 334);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(142, 32);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open in Text Editor";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 390);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lstBlockedSites);
            this.Name = "Form1";
            this.Text = "Block Distracting Sites";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBlockedSites;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpen;
    }
}

