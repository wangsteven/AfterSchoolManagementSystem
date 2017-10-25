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

namespace AfterSchoolManagementSystem.Forms
{
    public partial class TeacherListView :  MvpForm<TeacherList>, ITeacherListView
    {
        public event EventHandler UpdateEventHandler;
        public event EventHandler AddNewEventHandler;
        public event EventHandler RemoveEventHandler;
        public TeacherListView()
        {
            InitializeComponent();
        }

        public void SetDataSource()
        {
            bindingSource_teacher.DataSource = Model.GetList();
            bindingNavigator_teacher.BindingSource = bindingSource_teacher;
            dataGridView_teacher.DataSource = bindingSource_teacher;
        }

        public DialogResult ShowDialogBox()
        {
            return this.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            object obj = bindingNavigator_teacher.BindingSource.Current;
            AddNewEventHandler?.Invoke(obj, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该行数据吗？", "删除确认",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                object obj = bindingNavigator_teacher.BindingSource.Current;
                RemoveEventHandler?.Invoke(obj, e);
            }

        }

        private void Save_SToolStripButton_Click(object sender, EventArgs e)
        {
            object obj = bindingNavigator_teacher.BindingSource.Current;
            UpdateEventHandler?.Invoke(obj, e);
        }

        private void dataGridView_teacher_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Save_SToolStripButton_Click(null, null);
        }
    }
}
