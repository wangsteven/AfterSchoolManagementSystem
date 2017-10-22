namespace AfterSchoolManagementSystem.Forms
{
    partial class TodayCareReservationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayCareReservationView));
            this.bindingNavigator_careReservation = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Weekday = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel_Create = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_Create = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Export = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_careReservation = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingSource_careReservation = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_careReservation)).BeginInit();
            this.bindingNavigator_careReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_careReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_careReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator_careReservation
            // 
            this.bindingNavigator_careReservation.AddNewItem = null;// this.bindingNavigatorAddNewItem;
            this.bindingNavigator_careReservation.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_careReservation.DeleteItem = null;
            this.bindingNavigator_careReservation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel1,
            this.toolStripComboBox_Weekday,
            this.toolStripLabel_Create,
            this.toolStripButton_Create,
            this.toolStripButton_Export,
            this.toolStripButton1});
            this.bindingNavigator_careReservation.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_careReservation.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_careReservation.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_careReservation.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_careReservation.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_careReservation.Name = "bindingNavigator_careReservation";
            this.bindingNavigator_careReservation.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_careReservation.Size = new System.Drawing.Size(1008, 25);
            this.bindingNavigator_careReservation.TabIndex = 0;
            this.bindingNavigator_careReservation.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "按照周";
            // 
            // toolStripComboBox_Weekday
            // 
            this.toolStripComboBox_Weekday.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.toolStripComboBox_Weekday.Name = "toolStripComboBox_Weekday";
            this.toolStripComboBox_Weekday.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox_Weekday.Text = "1";
            this.toolStripComboBox_Weekday.DropDownClosed += new System.EventHandler(this.toolStripComboBox_Weekday_DropDownClosed);
            // 
            // toolStripLabel_Create
            // 
            this.toolStripLabel_Create.Name = "toolStripLabel_Create";
            this.toolStripLabel_Create.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel_Create.Text = "生成今日托管预约单";
            this.toolStripLabel_Create.Click += new System.EventHandler(this.toolStripButton_Create_Click);
            // 
            // toolStripButton_Create
            // 
            this.toolStripButton_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Create.Image = global::AfterSchoolManagementSystem.Properties.Resources.CreateNew_icon;
            this.toolStripButton_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Create.Name = "toolStripButton_Create";
            this.toolStripButton_Create.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Create.Text = "toolStripButton1";
            this.toolStripButton_Create.Click += new System.EventHandler(this.toolStripButton_Create_Click);
            // 
            // toolStripButton_Export
            // 
            this.toolStripButton_Export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Export.Image = global::AfterSchoolManagementSystem.Properties.Resources.Microsoft_Excel;
            this.toolStripButton_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Export.Name = "toolStripButton_Export";
            this.toolStripButton_Export.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Export.Text = "toolStripButton2";
            this.toolStripButton_Export.Click += new System.EventHandler(this.toolStripButton_Export_Click);
            // 
            // dataGridView_careReservation
            // 
            this.dataGridView_careReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_careReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_careReservation.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_careReservation.Name = "dataGridView_careReservation";
            this.dataGridView_careReservation.RowTemplate.Height = 23;
            this.dataGridView_careReservation.Size = new System.Drawing.Size(1008, 705);
            this.dataGridView_careReservation.TabIndex = 1;
            this.dataGridView_careReservation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_careReservation_CellValueChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AfterSchoolManagementSystem.Properties.Resources.Refresh_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // TodayCareReservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.dataGridView_careReservation);
            this.Controls.Add(this.bindingNavigator_careReservation);
            this.Name = "TodayCareReservationView";
            this.Tag = "4";
            this.Text = "今日托管预约明细";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_careReservation)).EndInit();
            this.bindingNavigator_careReservation.ResumeLayout(false);
            this.bindingNavigator_careReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_careReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_careReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator_careReservation;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource_careReservation;
        private System.Windows.Forms.DataGridView dataGridView_careReservation;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_Create;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Weekday;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Create;
        private System.Windows.Forms.ToolStripButton toolStripButton_Export;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}