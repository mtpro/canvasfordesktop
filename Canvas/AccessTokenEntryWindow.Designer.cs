namespace Canvas
{
    partial class AccessTokenEntryWindow
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
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessToken_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccessTokenTextBox.Location = new System.Drawing.Point(12, 25);
            this.AccessTokenTextBox.MaxLength = 80;
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(822, 20);
            this.AccessTokenTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access Token";
            // 
            // AccessToken_OK
            // 
            this.AccessToken_OK.Location = new System.Drawing.Point(15, 52);
            this.AccessToken_OK.Name = "AccessToken_OK";
            this.AccessToken_OK.Size = new System.Drawing.Size(75, 23);
            this.AccessToken_OK.TabIndex = 2;
            this.AccessToken_OK.Text = "OK";
            this.AccessToken_OK.UseVisualStyleBackColor = true;
            this.AccessToken_OK.Click += new System.EventHandler(this.AccessToken_OK_Click);
            // 
            // AccessTokenEntryWindow
            // 
            this.AcceptButton = this.AccessToken_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 103);
            this.Controls.Add(this.AccessToken_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccessTokenTextBox);
            this.MaximumSize = new System.Drawing.Size(861, 141);
            this.MinimumSize = new System.Drawing.Size(861, 141);
            this.Name = "AccessTokenEntryWindow";
            this.ShowIcon = false;
            this.Text = "Desktop Canvas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AccessToken_OK;

    }
}

