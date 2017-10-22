namespace AfterSchoolManagementSystem.Forms
{
    partial class StudentSelectionView
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
            this.listBox_Unselected = new System.Windows.Forms.ListBox();
            this.listBox_Selected = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Unselected
            // 
            this.listBox_Unselected.FormattingEnabled = true;
            this.listBox_Unselected.HorizontalScrollbar = true;
            this.listBox_Unselected.ItemHeight = 12;
            this.listBox_Unselected.Location = new System.Drawing.Point(45, 42);
            this.listBox_Unselected.Name = "listBox_Unselected";
            this.listBox_Unselected.Size = new System.Drawing.Size(246, 460);
            this.listBox_Unselected.TabIndex = 0;
            // 
            // listBox_Selected
            // 
            this.listBox_Selected.FormattingEnabled = true;
            this.listBox_Selected.HorizontalScrollbar = true;
            this.listBox_Selected.ItemHeight = 12;
            this.listBox_Selected.Location = new System.Drawing.Point(395, 42);
            this.listBox_Selected.Name = "listBox_Selected";
            this.listBox_Selected.Size = new System.Drawing.Size(246, 460);
            this.listBox_Selected.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(302, 136);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "==>";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(302, 349);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "<==";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(302, 230);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 4;
            this.button_New.Text = "+ =>";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(211, 527);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(407, 527);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // StudentSelectionView
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(665, 586);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listBox_Selected);
            this.Controls.Add(this.listBox_Unselected);
            this.Name = "StudentSelectionView";
            this.Text = "StudentSelectionView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Unselected;
        private System.Windows.Forms.ListBox listBox_Selected;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}