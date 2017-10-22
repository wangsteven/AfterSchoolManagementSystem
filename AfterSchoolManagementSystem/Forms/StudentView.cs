using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using WinFormsMvp.Forms;


namespace AfterSchoolManagementSystem.Forms
{
    public partial class StudentView :   MvpForm<StudentList>, IStudentView
    {
        public event EventHandler OpenDetailView;
        public int selectedRowIndex;
        public StudentView()
        {
            InitializeComponent();
        }

        public void SetDataSource()
        {
            bindingSource_student.DataSource = Model.GetList();
            bindingNavigator_student.BindingSource = bindingSource_student;
            dataGridView_student.DataSource = bindingSource_student;
        }

        public int GetSelectedRowIndex()
        {
            return selectedRowIndex;
        }



        private void dataGridView_student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if(OpenDetailView != null)
            {                 
                OpenDetailView(sender,e);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            selectedRowIndex = Model.GetList().Count-1;
            if (OpenDetailView != null)
            {
                OpenDetailView(sender, null);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(dataGridView_student.CurrentRow.Index>0)
            {
                selectedRowIndex = dataGridView_student.CurrentRow.Index;
                if (OpenDetailView != null)
                {
                    OpenDetailView(sender, e);
                }
            }
            
        }


    }
}
