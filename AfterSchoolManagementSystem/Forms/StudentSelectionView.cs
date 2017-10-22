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
      public partial class StudentSelectionView : MvpForm<StudentSelection>, IStudentSelectionView
    {
        public event EventHandler SelectEventHandler;
        public event EventHandler AddNewEventHandler;
        public event EventHandler RemoveEventHandler;

        private List<student> _selectedStudents;
        public StudentSelectionView()
        {
            InitializeComponent();
            _selectedStudents = new List<student>();
        }

        public void SetDataSource()
        {
            listBox_Unselected.DataSource = null;
            listBox_Selected.DataSource = null;
            listBox_Unselected.DataSource = Model.UnselectedStudents;
            listBox_Selected.DataSource = _selectedStudents;
        }

        public DialogResult ShowDialogBox()
        {
            return this.ShowDialog();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            object st = listBox_Unselected.SelectedItem;
            SelectEventHandler.Invoke(st, e);            
            _selectedStudents.Add(st as student);

            SetDataSource();

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            

            //object st = listBox_Unselected.SelectedItem;
            AddNewEventHandler.Invoke(null, e);
            //_selectedStudents.Add(st as student);
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            object st = listBox_Selected.SelectedItem;
            RemoveEventHandler.Invoke(st, e);
            _selectedStudents.Remove(st as student);
        }
    }
}
