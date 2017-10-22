using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsMvp.Forms;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;

using System.IO;

namespace AfterSchoolManagementSystem.Forms
{
    public partial class StudentDetailView :    MvpForm<student>, IStudentDetailView
    {

        private bool datachanged;
        private bool bsave;

        public event EventHandler ConfirmToSave;
        public event EventHandler ConfirmToDelete;
        public event EventHandler OpenCareReservationView;

        public StudentDetailView()
        {
            InitializeComponent();
            datachanged = false;
        }


        public DialogResult ShowDialogBox()
        {
            return this.ShowDialog();
        }

        private void StudentDetailView_Load(object sender, EventArgs e)
        {
           // textBox_name.Text = Model.name;
            //textBox_schoolTeacher.Text = Model.schoolTeacher;

            bindingSource_student.DataSource = Model;
            textBox_name.DataBindings.Add("Text", bindingSource_student, "name");
            comboBox_gender.DataBindings.Add("Text", bindingSource_student, "gender");
            numericUpDown_grade.DataBindings.Add("Value", bindingSource_student, "grade");
            numericUpDown_class.DataBindings.Add("Value", bindingSource_student, "classGroup");
            textBox_school.DataBindings.Add("Text", bindingSource_student, "school");
            textBox_schoolTeacher.DataBindings.Add("Text", bindingSource_student, "schoolTeacher");
            textBox_guardian.DataBindings.Add("Text", bindingSource_student, "guardian");

            textBox_contactId.DataBindings.Add("Text", bindingSource_student, "contactId");

            textBox_allergies.DataBindings.Add("Text", bindingSource_student, "allergies");
            textBox_favorite.DataBindings.Add("Text", bindingSource_student, "favorite");
            textBox_description.DataBindings.Add("Text", bindingSource_student, "description");
            checkBox_active.DataBindings.Add("Checked", bindingSource_student, "active");
            dateTimePicker_birthday.DataBindings.Add("Value", bindingSource_student, "birthday");
            dateTimePicker_regDate.DataBindings.Add("Value", bindingSource_student, "regDate");
            pictureBox_st.DataBindings.Add("ImageLocation", bindingSource_student, "picture");
        }

        private void StudentDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing) && datachanged)
            {
                DialogResult res = MessageBox.Show("数据发生改变，是否保存？", "提醒", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        //保存，允许关闭。                       
                        bsave = true;
                        SaveData();
                        datachanged = false;
                        bsave = false;
                        break;
                    case DialogResult.No:
                        //不保存，但依然允许关闭。
                        e.Cancel = false;
                        break;
                    case DialogResult.Cancel:
                        //阻止继续关闭窗体
                        e.Cancel = true;
                        break;
                }
            }



        }

        private void SaveData()
        {
            if (bsave)
            {
                Model = (student)bindingSource_student.DataSource;

                if (ConfirmToSave != null)
                {
                    ConfirmToSave(Model, null);
                }               
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Model = (student)bindingSource_student.DataSource;

            if (ConfirmToSave != null)
            {
                ConfirmToSave(Model, null);
            }           

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            if (ConfirmToDelete != null)
            {
                ConfirmToDelete(Model, null);
            }           
        }

        private void button_picture_Click(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                if (!Directory.Exists(path + "Pictures"))
                {
                    Directory.CreateDirectory(path + "Pictures");
                }

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "图片文件|*.*|JPG文件|*.jpg|所有文件|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog.FileName, path + @"Pictures\" + openFileDialog.SafeFileName, true);

                    
                    pictureBox_st.ImageLocation = @"Pictures\" + openFileDialog.SafeFileName;
                    //due to picuture imagelocatin cannot sync when binding                    
                    bindingSource_student.EndEdit();
                    //Model.picture = pictureBox_st.ImageLocation; 

                    datachanged = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_CareReservation_Click(object sender, EventArgs e)
        {
            if (OpenCareReservationView != null)
            {
                OpenCareReservationView(Model, e);
            }   

        }
    }
}
