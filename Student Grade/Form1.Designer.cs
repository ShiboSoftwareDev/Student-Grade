namespace Student_Grade
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtMark = new TextBox();
            btnAdd = new Button();
            grpMarks = new GroupBox();
            lstMarks = new ListBox();
            grpGrade = new GroupBox();
            lblGradeResult = new Label();
            lblMaxResult = new Label();
            lblMinResult = new Label();
            lblGrade = new Label();
            lblMin = new Label();
            lblMax = new Label();
            btnGrade = new Button();
            btnNew = new Button();
            btnExit = new Button();
            lblError = new Label();
            grpMarks.SuspendLayout();
            grpGrade.SuspendLayout();
            SuspendLayout();
            // 
            // txtMark
            // 
            txtMark.Location = new Point(58, 30);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(148, 23);
            txtMark.TabIndex = 0;
            txtMark.TextChanged += txtMark_TextChanged;
            txtMark.KeyDown += txtMark_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(212, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpMarks
            // 
            grpMarks.Controls.Add(lstMarks);
            grpMarks.Location = new Point(58, 86);
            grpMarks.Name = "grpMarks";
            grpMarks.Size = new Size(291, 230);
            grpMarks.TabIndex = 2;
            grpMarks.TabStop = false;
            grpMarks.Text = "Marks";
            // 
            // lstMarks
            // 
            lstMarks.FormattingEnabled = true;
            lstMarks.ItemHeight = 15;
            lstMarks.Location = new Point(16, 32);
            lstMarks.Name = "lstMarks";
            lstMarks.Size = new Size(259, 184);
            lstMarks.TabIndex = 0;
            lstMarks.TabStop = false;
            // 
            // grpGrade
            // 
            grpGrade.Controls.Add(lblGradeResult);
            grpGrade.Controls.Add(lblMaxResult);
            grpGrade.Controls.Add(lblMinResult);
            grpGrade.Controls.Add(lblGrade);
            grpGrade.Controls.Add(lblMin);
            grpGrade.Controls.Add(lblMax);
            grpGrade.Location = new Point(58, 333);
            grpGrade.Name = "grpGrade";
            grpGrade.Size = new Size(291, 134);
            grpGrade.TabIndex = 3;
            grpGrade.TabStop = false;
            grpGrade.Text = "Grade";
            // 
            // lblGradeResult
            // 
            lblGradeResult.BorderStyle = BorderStyle.FixedSingle;
            lblGradeResult.ImageAlign = ContentAlignment.BottomLeft;
            lblGradeResult.Location = new Point(175, 90);
            lblGradeResult.Name = "lblGradeResult";
            lblGradeResult.Size = new Size(100, 23);
            lblGradeResult.TabIndex = 5;
            lblGradeResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaxResult
            // 
            lblMaxResult.BorderStyle = BorderStyle.FixedSingle;
            lblMaxResult.ImageAlign = ContentAlignment.BottomLeft;
            lblMaxResult.Location = new Point(175, 26);
            lblMaxResult.Name = "lblMaxResult";
            lblMaxResult.Size = new Size(100, 23);
            lblMaxResult.TabIndex = 3;
            lblMaxResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMinResult
            // 
            lblMinResult.BorderStyle = BorderStyle.FixedSingle;
            lblMinResult.ImageAlign = ContentAlignment.BottomLeft;
            lblMinResult.Location = new Point(175, 59);
            lblMinResult.Name = "lblMinResult";
            lblMinResult.Size = new Size(100, 23);
            lblMinResult.TabIndex = 4;
            lblMinResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(110, 91);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(38, 15);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "Grade";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(74, 60);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(74, 15);
            lblMin.TabIndex = 1;
            lblMin.Text = "Lowest Mark";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(70, 27);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(78, 15);
            lblMax.TabIndex = 0;
            lblMax.Text = "Highest Mark";
            // 
            // btnGrade
            // 
            btnGrade.Location = new Point(58, 482);
            btnGrade.Name = "btnGrade";
            btnGrade.Size = new Size(132, 23);
            btnGrade.TabIndex = 4;
            btnGrade.Text = "Grade";
            btnGrade.UseVisualStyleBackColor = true;
            btnGrade.Click += btnGrade_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(196, 482);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(277, 482);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(58, 56);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(406, 546);
            Controls.Add(lblError);
            Controls.Add(btnExit);
            Controls.Add(btnNew);
            Controls.Add(btnGrade);
            Controls.Add(grpGrade);
            Controls.Add(grpMarks);
            Controls.Add(btnAdd);
            Controls.Add(txtMark);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Student Grade";
            grpMarks.ResumeLayout(false);
            grpGrade.ResumeLayout(false);
            grpGrade.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMark;
        private Button btnAdd;
        private GroupBox grpMarks;
        private ListBox lstMarks;
        private GroupBox grpGrade;
        private Label lblGrade;
        private Label lblMin;
        private Label lblMax;
        private Button btnGrade;
        private Button btnNew;
        private Button btnExit;
        private Label lblGradeResult;
        private Label lblMinResult;
        private Label lblMaxResult;
        private Label lblError;
    }
}
