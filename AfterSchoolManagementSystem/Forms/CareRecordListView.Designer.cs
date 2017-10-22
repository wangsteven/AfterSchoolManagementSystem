namespace AfterSchoolManagementSystem.Forms
{
    partial class CareRecordListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CareRecordListView));
            this.bindingNavigator_careRecord = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource_careRecord = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_selectToday = new System.Windows.Forms.CheckBox();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.button_query = new System.Windows.Forms.Button();
            this.comboBox_Students = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_careRecord = new System.Windows.Forms.DataGridView();
            this.bindingSource_student = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_careRecord)).BeginInit();
            this.bindingNavigator_careRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_careRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_careRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_student)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator_careRecord
            // 
            this.bindingNavigator_careRecord.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator_careRecord.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_careRecord.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator_careRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator_careRecord.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_careRecord.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_careRecord.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_careRecord.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_careRecord.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_careRecord.Name = "bindingNavigator_careRecord";
            this.bindingNavigator_careRecord.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_careRecord.Size = new System.Drawing.Size(1156, 25);
            this.bindingNavigator_careRecord.TabIndex = 0;
            this.bindingNavigator_careRecord.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_save);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_selectToday);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_selectAll);
            this.splitContainer1.Panel1.Controls.Add(this.button_query);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Students);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker_End);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker_Start);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_careRecord);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 705);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(956, 11);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(128, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // checkBox_selectToday
            // 
            this.checkBox_selectToday.AutoSize = true;
            this.checkBox_selectToday.Location = new System.Drawing.Point(793, 15);
            this.checkBox_selectToday.Name = "checkBox_selectToday";
            this.checkBox_selectToday.Size = new System.Drawing.Size(72, 16);
            this.checkBox_selectToday.TabIndex = 5;
            this.checkBox_selectToday.Text = "只选今日";
            this.checkBox_selectToday.UseVisualStyleBackColor = true;
            this.checkBox_selectToday.CheckedChanged += new System.EventHandler(this.checkBox_selectToday_CheckedChanged);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Checked = true;
            this.checkBox_selectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_selectAll.Location = new System.Drawing.Point(336, 15);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(48, 16);
            this.checkBox_selectAll.TabIndex = 5;
            this.checkBox_selectAll.Text = "全选";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(875, 12);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(75, 23);
            this.button_query.TabIndex = 4;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // comboBox_Students
            // 
            this.comboBox_Students.FormattingEnabled = true;
            this.comboBox_Students.Location = new System.Drawing.Point(68, 13);
            this.comboBox_Students.Name = "comboBox_Students";
            this.comboBox_Students.Size = new System.Drawing.Size(248, 20);
            this.comboBox_Students.TabIndex = 3;
            this.comboBox_Students.DropDownClosed += new System.EventHandler(this.comboBox_Students_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "截止日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "选定学生";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始日期";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(660, 11);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(117, 21);
            this.dateTimePicker_End.TabIndex = 0;
            this.dateTimePicker_End.ValueChanged += new System.EventHandler(this.dateTimePicker_End_ValueChanged);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(463, 13);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(117, 21);
            this.dateTimePicker_Start.TabIndex = 0;
            this.dateTimePicker_Start.ValueChanged += new System.EventHandler(this.dateTimePicker_Start_ValueChanged);
            // 
            // dataGridView_careRecord
            // 
            this.dataGridView_careRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_careRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_careRecord.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_careRecord.Name = "dataGridView_careRecord";
            this.dataGridView_careRecord.RowTemplate.Height = 23;
            this.dataGridView_careRecord.Size = new System.Drawing.Size(1156, 634);
            this.dataGridView_careRecord.TabIndex = 0;
            // 
            // CareRecordListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator_careRecord);
            this.Name = "CareRecordListView";
            this.Text = "CareRecordListView";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_careRecord)).EndInit();
            this.bindingNavigator_careRecord.ResumeLayout(false);
            this.bindingNavigator_careRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_careRecord)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_careRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator_careRecord;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource_careRecord;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Students;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DataGridView dataGridView_careRecord;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
        private System.Windows.Forms.BindingSource bindingSource_student;
        private System.Windows.Forms.CheckBox checkBox_selectToday;
        private System.Windows.Forms.Button button_save;
    }
}