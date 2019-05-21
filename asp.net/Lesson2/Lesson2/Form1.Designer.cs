namespace Lesson2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuClass = new System.Windows.Forms.TextBox();
            this.cmdString = new System.Windows.Forms.ComboBox();
            this.b1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.students = new Lesson2.Students();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Lesson2.StudentsTableAdapters.StudentTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(32, 30);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(29, 12);
            this.l1.TabIndex = 0;
            this.l1.Text = "学号";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(187, 30);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(29, 12);
            this.l2.TabIndex = 0;
            this.l2.Text = "姓名";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(345, 30);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(29, 12);
            this.l3.TabIndex = 0;
            this.l3.Text = "班级";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(512, 30);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(41, 12);
            this.l4.TabIndex = 0;
            this.l4.Text = "label1";
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(79, 27);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(100, 21);
            this.txtStuNum.TabIndex = 1;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(234, 27);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 1;
            // 
            // txtStuClass
            // 
            this.txtStuClass.Location = new System.Drawing.Point(392, 27);
            this.txtStuClass.Name = "txtStuClass";
            this.txtStuClass.Size = new System.Drawing.Size(100, 21);
            this.txtStuClass.TabIndex = 1;
            // 
            // cmdString
            // 
            this.cmdString.FormattingEnabled = true;
            this.cmdString.Location = new System.Drawing.Point(560, 27);
            this.cmdString.Name = "cmdString";
            this.cmdString.Size = new System.Drawing.Size(121, 20);
            this.cmdString.TabIndex = 2;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(696, 24);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 3;
            this.b1.Text = "查询";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stuNumDataGridViewTextBoxColumn,
            this.stuNameDataGridViewTextBoxColumn,
            this.stuClassDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.stuAgeDataGridViewTextBoxColumn,
            this.stuPhoneDataGridViewTextBoxColumn,
            this.stuGenderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(686, 276);
            this.dataGridView1.TabIndex = 4;
            // 
            // students
            // 
            this.students.DataSetName = "Students";
            this.students.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.students;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // stuNumDataGridViewTextBoxColumn
            // 
            this.stuNumDataGridViewTextBoxColumn.DataPropertyName = "StuNum";
            this.stuNumDataGridViewTextBoxColumn.HeaderText = "学号";
            this.stuNumDataGridViewTextBoxColumn.Name = "stuNumDataGridViewTextBoxColumn";
            this.stuNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.DataPropertyName = "StuName";
            this.stuNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            this.stuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuClassDataGridViewTextBoxColumn
            // 
            this.stuClassDataGridViewTextBoxColumn.DataPropertyName = "StuClass";
            this.stuClassDataGridViewTextBoxColumn.HeaderText = "班级";
            this.stuClassDataGridViewTextBoxColumn.Name = "stuClassDataGridViewTextBoxColumn";
            this.stuClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "学科";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuAgeDataGridViewTextBoxColumn
            // 
            this.stuAgeDataGridViewTextBoxColumn.DataPropertyName = "StuAge";
            this.stuAgeDataGridViewTextBoxColumn.HeaderText = "年龄";
            this.stuAgeDataGridViewTextBoxColumn.Name = "stuAgeDataGridViewTextBoxColumn";
            this.stuAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuPhoneDataGridViewTextBoxColumn
            // 
            this.stuPhoneDataGridViewTextBoxColumn.DataPropertyName = "StuPhone";
            this.stuPhoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.stuPhoneDataGridViewTextBoxColumn.Name = "stuPhoneDataGridViewTextBoxColumn";
            this.stuPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuGenderDataGridViewTextBoxColumn
            // 
            this.stuGenderDataGridViewTextBoxColumn.DataPropertyName = "StuGender";
            this.stuGenderDataGridViewTextBoxColumn.HeaderText = "性别";
            this.stuGenderDataGridViewTextBoxColumn.Name = "stuGenderDataGridViewTextBoxColumn";
            this.stuGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.cmdString);
            this.Controls.Add(this.txtStuClass);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuNum);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuClass;
        private System.Windows.Forms.ComboBox cmdString;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Students students;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentsTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

