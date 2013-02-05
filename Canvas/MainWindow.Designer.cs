namespace Canvas
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.CourseSelectionPanel = new System.Windows.Forms.Panel();
            this.CoursesListBox = new System.Windows.Forms.ListBox();
            this.SelectCourseLabel = new System.Windows.Forms.Label();
            this.ModuleComboBox = new System.Windows.Forms.ComboBox();
            this.SelectModuleLabel = new System.Windows.Forms.Label();
            this.CourseInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InstructorLabel = new System.Windows.Forms.Label();
            this.ActiveCourseLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AssignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AssignmentViewTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AssignmentGradingLabel = new System.Windows.Forms.Label();
            this.AssignmentCourseLabel = new System.Windows.Forms.Label();
            this.AssignmentDueLabel = new System.Windows.Forms.Label();
            this.STATIC_AssignmentIDLabel = new System.Windows.Forms.Label();
            this.STATIC_AssignmentDueLabel = new System.Windows.Forms.Label();
            this.STATIC_AssignmentCourseLabel = new System.Windows.Forms.Label();
            this.STATIC_AssignmentGradingLabel = new System.Windows.Forms.Label();
            this.AssignmentIDLabel = new System.Windows.Forms.Label();
            this.AssignmentListBox = new System.Windows.Forms.ListBox();
            this.ModuleSelectionPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClassmatesLabel = new System.Windows.Forms.Label();
            this.ClassmatesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActiveClassmateLabel = new System.Windows.Forms.Label();
            this.ClassmatesPageComboBox = new System.Windows.Forms.ComboBox();
            this.CourseSelectionPanel.SuspendLayout();
            this.CourseInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.AssignmentGroupBox.SuspendLayout();
            this.AssignmentViewTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ModuleSelectionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseSelectionPanel
            // 
            this.CourseSelectionPanel.Controls.Add(this.CoursesListBox);
            this.CourseSelectionPanel.Controls.Add(this.SelectCourseLabel);
            this.CourseSelectionPanel.Location = new System.Drawing.Point(12, 12);
            this.CourseSelectionPanel.Name = "CourseSelectionPanel";
            this.CourseSelectionPanel.Size = new System.Drawing.Size(245, 123);
            this.CourseSelectionPanel.TabIndex = 0;
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.Location = new System.Drawing.Point(7, 20);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(232, 95);
            this.CoursesListBox.TabIndex = 1;
            this.CoursesListBox.SelectedIndexChanged += new System.EventHandler(this.CoursesListBox_SelectedIndexChanged);
            // 
            // SelectCourseLabel
            // 
            this.SelectCourseLabel.AutoSize = true;
            this.SelectCourseLabel.Location = new System.Drawing.Point(6, 4);
            this.SelectCourseLabel.Name = "SelectCourseLabel";
            this.SelectCourseLabel.Size = new System.Drawing.Size(72, 13);
            this.SelectCourseLabel.TabIndex = 0;
            this.SelectCourseLabel.Text = "Select course";
            // 
            // ModuleComboBox
            // 
            this.ModuleComboBox.FormattingEnabled = true;
            this.ModuleComboBox.Location = new System.Drawing.Point(7, 19);
            this.ModuleComboBox.Name = "ModuleComboBox";
            this.ModuleComboBox.Size = new System.Drawing.Size(132, 21);
            this.ModuleComboBox.TabIndex = 3;
            this.ModuleComboBox.Visible = false;
            // 
            // SelectModuleLabel
            // 
            this.SelectModuleLabel.AutoSize = true;
            this.SelectModuleLabel.Location = new System.Drawing.Point(6, 3);
            this.SelectModuleLabel.Name = "SelectModuleLabel";
            this.SelectModuleLabel.Size = new System.Drawing.Size(74, 13);
            this.SelectModuleLabel.TabIndex = 4;
            this.SelectModuleLabel.Text = "Select module";
            this.SelectModuleLabel.Visible = false;
            // 
            // CourseInfoGroupBox
            // 
            this.CourseInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseInfoGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.CourseInfoGroupBox.Location = new System.Drawing.Point(303, 16);
            this.CourseInfoGroupBox.Name = "CourseInfoGroupBox";
            this.CourseInfoGroupBox.Size = new System.Drawing.Size(442, 82);
            this.CourseInfoGroupBox.TabIndex = 5;
            this.CourseInfoGroupBox.TabStop = false;
            this.CourseInfoGroupBox.Text = "Course Information";
            this.CourseInfoGroupBox.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.InstructorLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ActiveCourseLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InstructorLabel
            // 
            this.InstructorLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InstructorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorLabel.Location = new System.Drawing.Point(250, 37);
            this.InstructorLabel.Name = "InstructorLabel";
            this.InstructorLabel.Size = new System.Drawing.Size(177, 20);
            this.InstructorLabel.TabIndex = 2;
            this.InstructorLabel.Text = "Instructors";
            this.InstructorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstructorLabel.Visible = false;
            // 
            // ActiveCourseLabel
            // 
            this.ActiveCourseLabel.AutoSize = true;
            this.ActiveCourseLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActiveCourseLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveCourseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveCourseLabel.Location = new System.Drawing.Point(243, 0);
            this.ActiveCourseLabel.Name = "ActiveCourseLabel";
            this.ActiveCourseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActiveCourseLabel.Size = new System.Drawing.Size(184, 37);
            this.ActiveCourseLabel.TabIndex = 1;
            this.ActiveCourseLabel.Text = "Active Course:";
            this.ActiveCourseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ActiveCourseLabel.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ActiveClassmateLabel);
            this.MainPanel.Controls.Add(this.AssignmentGroupBox);
            this.MainPanel.Controls.Add(this.CourseSelectionPanel);
            this.MainPanel.Controls.Add(this.CourseInfoGroupBox);
            this.MainPanel.Controls.Add(this.ModuleSelectionPanel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(0, -2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(757, 437);
            this.MainPanel.TabIndex = 6;
            // 
            // AssignmentGroupBox
            // 
            this.AssignmentGroupBox.Controls.Add(this.AssignmentViewTableLayout);
            this.AssignmentGroupBox.Location = new System.Drawing.Point(266, 150);
            this.AssignmentGroupBox.Name = "AssignmentGroupBox";
            this.AssignmentGroupBox.Size = new System.Drawing.Size(479, 257);
            this.AssignmentGroupBox.TabIndex = 7;
            this.AssignmentGroupBox.TabStop = false;
            this.AssignmentGroupBox.Text = "Assignments";
            this.AssignmentGroupBox.Visible = false;
            // 
            // AssignmentViewTableLayout
            // 
            this.AssignmentViewTableLayout.ColumnCount = 2;
            this.AssignmentViewTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.AssignmentViewTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.AssignmentViewTableLayout.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.AssignmentViewTableLayout.Controls.Add(this.AssignmentListBox, 1, 0);
            this.AssignmentViewTableLayout.Location = new System.Drawing.Point(6, 19);
            this.AssignmentViewTableLayout.Name = "AssignmentViewTableLayout";
            this.AssignmentViewTableLayout.RowCount = 1;
            this.AssignmentViewTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AssignmentViewTableLayout.Size = new System.Drawing.Size(467, 232);
            this.AssignmentViewTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.29851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.70149F));
            this.tableLayoutPanel2.Controls.Add(this.AssignmentGradingLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.AssignmentCourseLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.AssignmentDueLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.STATIC_AssignmentIDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.STATIC_AssignmentDueLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.STATIC_AssignmentCourseLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.STATIC_AssignmentGradingLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AssignmentIDLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 226);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AssignmentGradingLabel
            // 
            this.AssignmentGradingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AssignmentGradingLabel.AutoSize = true;
            this.AssignmentGradingLabel.Location = new System.Drawing.Point(72, 190);
            this.AssignmentGradingLabel.Name = "AssignmentGradingLabel";
            this.AssignmentGradingLabel.Size = new System.Drawing.Size(59, 13);
            this.AssignmentGradingLabel.TabIndex = 7;
            this.AssignmentGradingLabel.Text = "ASG_GRD";
            this.AssignmentGradingLabel.Visible = false;
            // 
            // AssignmentCourseLabel
            // 
            this.AssignmentCourseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AssignmentCourseLabel.AutoSize = true;
            this.AssignmentCourseLabel.Location = new System.Drawing.Point(74, 133);
            this.AssignmentCourseLabel.Name = "AssignmentCourseLabel";
            this.AssignmentCourseLabel.Size = new System.Drawing.Size(57, 13);
            this.AssignmentCourseLabel.TabIndex = 6;
            this.AssignmentCourseLabel.Text = "ASG_CRS";
            this.AssignmentCourseLabel.Visible = false;
            // 
            // AssignmentDueLabel
            // 
            this.AssignmentDueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AssignmentDueLabel.AutoSize = true;
            this.AssignmentDueLabel.Location = new System.Drawing.Point(73, 77);
            this.AssignmentDueLabel.Name = "AssignmentDueLabel";
            this.AssignmentDueLabel.Size = new System.Drawing.Size(58, 13);
            this.AssignmentDueLabel.TabIndex = 5;
            this.AssignmentDueLabel.Text = "ASG_DUE";
            this.AssignmentDueLabel.Visible = false;
            // 
            // STATIC_AssignmentIDLabel
            // 
            this.STATIC_AssignmentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STATIC_AssignmentIDLabel.AutoSize = true;
            this.STATIC_AssignmentIDLabel.Location = new System.Drawing.Point(3, 21);
            this.STATIC_AssignmentIDLabel.Name = "STATIC_AssignmentIDLabel";
            this.STATIC_AssignmentIDLabel.Size = new System.Drawing.Size(18, 13);
            this.STATIC_AssignmentIDLabel.TabIndex = 0;
            this.STATIC_AssignmentIDLabel.Text = "ID";
            this.STATIC_AssignmentIDLabel.Visible = false;
            // 
            // STATIC_AssignmentDueLabel
            // 
            this.STATIC_AssignmentDueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STATIC_AssignmentDueLabel.AutoSize = true;
            this.STATIC_AssignmentDueLabel.Location = new System.Drawing.Point(3, 77);
            this.STATIC_AssignmentDueLabel.Name = "STATIC_AssignmentDueLabel";
            this.STATIC_AssignmentDueLabel.Size = new System.Drawing.Size(27, 13);
            this.STATIC_AssignmentDueLabel.TabIndex = 1;
            this.STATIC_AssignmentDueLabel.Text = "Due";
            this.STATIC_AssignmentDueLabel.Visible = false;
            // 
            // STATIC_AssignmentCourseLabel
            // 
            this.STATIC_AssignmentCourseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STATIC_AssignmentCourseLabel.AutoSize = true;
            this.STATIC_AssignmentCourseLabel.Location = new System.Drawing.Point(3, 133);
            this.STATIC_AssignmentCourseLabel.Name = "STATIC_AssignmentCourseLabel";
            this.STATIC_AssignmentCourseLabel.Size = new System.Drawing.Size(40, 13);
            this.STATIC_AssignmentCourseLabel.TabIndex = 2;
            this.STATIC_AssignmentCourseLabel.Text = "Course";
            this.STATIC_AssignmentCourseLabel.Visible = false;
            // 
            // STATIC_AssignmentGradingLabel
            // 
            this.STATIC_AssignmentGradingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STATIC_AssignmentGradingLabel.AutoSize = true;
            this.STATIC_AssignmentGradingLabel.Location = new System.Drawing.Point(3, 184);
            this.STATIC_AssignmentGradingLabel.Name = "STATIC_AssignmentGradingLabel";
            this.STATIC_AssignmentGradingLabel.Size = new System.Drawing.Size(47, 26);
            this.STATIC_AssignmentGradingLabel.TabIndex = 3;
            this.STATIC_AssignmentGradingLabel.Text = "Grading Type";
            this.STATIC_AssignmentGradingLabel.Visible = false;
            // 
            // AssignmentIDLabel
            // 
            this.AssignmentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AssignmentIDLabel.AutoSize = true;
            this.AssignmentIDLabel.Location = new System.Drawing.Point(82, 21);
            this.AssignmentIDLabel.Name = "AssignmentIDLabel";
            this.AssignmentIDLabel.Size = new System.Drawing.Size(49, 13);
            this.AssignmentIDLabel.TabIndex = 4;
            this.AssignmentIDLabel.Text = " ASG_ID";
            this.AssignmentIDLabel.Visible = false;
            // 
            // AssignmentListBox
            // 
            this.AssignmentListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentListBox.FormattingEnabled = true;
            this.AssignmentListBox.Location = new System.Drawing.Point(143, 3);
            this.AssignmentListBox.Name = "AssignmentListBox";
            this.AssignmentListBox.Size = new System.Drawing.Size(321, 226);
            this.AssignmentListBox.TabIndex = 1;
            this.AssignmentListBox.Visible = false;
            this.AssignmentListBox.SelectedIndexChanged += new System.EventHandler(this.AssignmentListBox_SelectedIndexChanged);
            // 
            // ModuleSelectionPanel
            // 
            this.ModuleSelectionPanel.Controls.Add(this.SelectModuleLabel);
            this.ModuleSelectionPanel.Controls.Add(this.ModuleComboBox);
            this.ModuleSelectionPanel.Location = new System.Drawing.Point(12, 150);
            this.ModuleSelectionPanel.Name = "ModuleSelectionPanel";
            this.ModuleSelectionPanel.Size = new System.Drawing.Size(245, 56);
            this.ModuleSelectionPanel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClassmatesLabel
            // 
            this.ClassmatesLabel.AutoSize = true;
            this.ClassmatesLabel.Location = new System.Drawing.Point(7, 15);
            this.ClassmatesLabel.Name = "ClassmatesLabel";
            this.ClassmatesLabel.Size = new System.Drawing.Size(60, 13);
            this.ClassmatesLabel.TabIndex = 8;
            this.ClassmatesLabel.Text = "Classmates";
            this.ClassmatesLabel.Visible = false;
            // 
            // ClassmatesListBox
            // 
            this.ClassmatesListBox.FormattingEnabled = true;
            this.ClassmatesListBox.Location = new System.Drawing.Point(7, 31);
            this.ClassmatesListBox.Name = "ClassmatesListBox";
            this.ClassmatesListBox.Size = new System.Drawing.Size(229, 160);
            this.ClassmatesListBox.TabIndex = 9;
            this.ClassmatesListBox.Visible = false;
            this.ClassmatesListBox.SelectedIndexChanged += new System.EventHandler(this.ClassmatesListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClassmatesPageComboBox);
            this.panel1.Controls.Add(this.ClassmatesLabel);
            this.panel1.Controls.Add(this.ClassmatesListBox);
            this.panel1.Location = new System.Drawing.Point(12, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 195);
            this.panel1.TabIndex = 10;
            // 
            // ActiveClassmateLabel
            // 
            this.ActiveClassmateLabel.AutoSize = true;
            this.ActiveClassmateLabel.Location = new System.Drawing.Point(19, 411);
            this.ActiveClassmateLabel.Name = "ActiveClassmateLabel";
            this.ActiveClassmateLabel.Size = new System.Drawing.Size(88, 13);
            this.ActiveClassmateLabel.TabIndex = 11;
            this.ActiveClassmateLabel.Text = "Active Classmate";
            this.ActiveClassmateLabel.Visible = false;
            // 
            // ClassmatesPageComboBox
            // 
            this.ClassmatesPageComboBox.FormattingEnabled = true;
            this.ClassmatesPageComboBox.Location = new System.Drawing.Point(173, 7);
            this.ClassmatesPageComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.ClassmatesPageComboBox.Name = "ClassmatesPageComboBox";
            this.ClassmatesPageComboBox.Size = new System.Drawing.Size(63, 21);
            this.ClassmatesPageComboBox.TabIndex = 10;
            this.ClassmatesPageComboBox.Text = "Page";
            this.ClassmatesPageComboBox.Visible = false;
            this.ClassmatesPageComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassmatesPageComboBox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 447);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Desktop Canvas";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.CourseSelectionPanel.ResumeLayout(false);
            this.CourseSelectionPanel.PerformLayout();
            this.CourseInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.AssignmentGroupBox.ResumeLayout(false);
            this.AssignmentViewTableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ModuleSelectionPanel.ResumeLayout(false);
            this.ModuleSelectionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CourseSelectionPanel;
        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.Label SelectCourseLabel;
        private System.Windows.Forms.ComboBox ModuleComboBox;
        private System.Windows.Forms.Label SelectModuleLabel;
        private System.Windows.Forms.GroupBox CourseInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InstructorLabel;
        private System.Windows.Forms.Label ActiveCourseLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ModuleSelectionPanel;
        private System.Windows.Forms.GroupBox AssignmentGroupBox;
        private System.Windows.Forms.TableLayoutPanel AssignmentViewTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label STATIC_AssignmentIDLabel;
        private System.Windows.Forms.Label STATIC_AssignmentDueLabel;
        private System.Windows.Forms.Label STATIC_AssignmentCourseLabel;
        private System.Windows.Forms.Label STATIC_AssignmentGradingLabel;
        private System.Windows.Forms.ListBox AssignmentListBox;
        private System.Windows.Forms.Label AssignmentIDLabel;
        private System.Windows.Forms.Label AssignmentGradingLabel;
        private System.Windows.Forms.Label AssignmentCourseLabel;
        private System.Windows.Forms.Label AssignmentDueLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ClassmatesLabel;
        private System.Windows.Forms.ListBox ClassmatesListBox;
        private System.Windows.Forms.Label ActiveClassmateLabel;
        private System.Windows.Forms.ComboBox ClassmatesPageComboBox;
    }
}