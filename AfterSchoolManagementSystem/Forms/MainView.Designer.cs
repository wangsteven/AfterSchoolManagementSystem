namespace AfterSchoolManagementSystem.Forms
{
    partial class MainView
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_student = new System.Windows.Forms.Button();
            this.button_careReservation = new System.Windows.Forms.Button();
            this.button_careRecord = new System.Windows.Forms.Button();
            this.button_todayCareRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_student
            // 
            this.button_student.Location = new System.Drawing.Point(36, 27);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(94, 23);
            this.button_student.TabIndex = 0;
            this.button_student.Text = "学生管理系统";
            this.button_student.UseVisualStyleBackColor = true;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // button_careReservation
            // 
            this.button_careReservation.Location = new System.Drawing.Point(36, 104);
            this.button_careReservation.Name = "button_careReservation";
            this.button_careReservation.Size = new System.Drawing.Size(94, 23);
            this.button_careReservation.TabIndex = 0;
            this.button_careReservation.Text = "托管预约系统";
            this.button_careReservation.UseVisualStyleBackColor = true;
            this.button_careReservation.Click += new System.EventHandler(this.button_careReservation_Click);
            // 
            // button_careRecord
            // 
            this.button_careRecord.Location = new System.Drawing.Point(36, 290);
            this.button_careRecord.Name = "button_careRecord";
            this.button_careRecord.Size = new System.Drawing.Size(94, 23);
            this.button_careRecord.TabIndex = 1;
            this.button_careRecord.Text = "托管记录系统";
            this.button_careRecord.UseVisualStyleBackColor = true;
            this.button_careRecord.Click += new System.EventHandler(this.button_careRecord_Click);
            // 
            // button_todayCareRecord
            // 
            this.button_todayCareRecord.Location = new System.Drawing.Point(36, 201);
            this.button_todayCareRecord.Name = "button_todayCareRecord";
            this.button_todayCareRecord.Size = new System.Drawing.Size(94, 23);
            this.button_todayCareRecord.TabIndex = 2;
            this.button_todayCareRecord.Text = "今日托管录入";
            this.button_todayCareRecord.UseVisualStyleBackColor = true;
            this.button_todayCareRecord.Click += new System.EventHandler(this.button_todayCareRecord_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 371);
            this.Controls.Add(this.button_todayCareRecord);
            this.Controls.Add(this.button_careRecord);
            this.Controls.Add(this.button_careReservation);
            this.Controls.Add(this.button_student);
            this.Name = "MainView";
            this.Text = "AfterSchoolManagementSystem";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Button button_careReservation;
        private System.Windows.Forms.Button button_careRecord;
        private System.Windows.Forms.Button button_todayCareRecord;
    }
}