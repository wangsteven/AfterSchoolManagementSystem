using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using WinFormsMvp.Forms;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;

namespace AfterSchoolManagementSystem.Forms
{
    public partial class TodayCareRecordListView :   MvpForm<CareRecordList>, ITodayCareRecordListView
    {

        private DateTime _selDateD;
        private bool _selectAll;
        private int _selStudentId;
        private bool _importingMode;

        public TodayCareRecordListView()
        {
            InitializeComponent();
            _selDateD = DateTime.Now;
            _selectAll = true;
            _selStudentId = -1;
            _importingMode = true;
        }

        public event EventHandler QueryEventHandler;
        public event EventHandler ImportEventHandler;
        public event EventHandler SaveEventHandler;
        public event EventHandler AddNewEventHandler;

        public void SetDataSource()
        {

            bindingSource_careRecord.DataSource = Model.GetList();
            bindingNavigator_careRecord.BindingSource = bindingSource_careRecord;
            dataGridView_careRecord.DataSource = bindingSource_careRecord;

            comboBox_Students.DataSource = bindingSource_student;

            dataGridView_careRecord.Refresh();

        }

        public void SetStudentList(IList list)
        {
            bindingSource_student.DataSource = list;
        }

        public DateTime GetSelStartDate()
        {
            return dateTimePicker_Start.Value;
        }

        public DateTime GetSelEndDate()
        {
            return dateTimePicker_Start.Value;
        }

        public int GetSelStudentId()
        {
            return _selStudentId;
        }

        private void comboBox_Students_DropDownClosed(object sender, EventArgs e)
        {
            var st = ((student)(bindingSource_student.Current));
            _selStudentId = st.studentId;

            QueryEventHandler(sender, e);
        }

        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            _selectAll = checkBox_selectAll.Checked;
            if (_selectAll)
            {
                _selStudentId = -1;
            }

        }

        private void button_import_Click(object sender, EventArgs e)
        {
            ImportEventHandler(sender, e);
            _importingMode = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveEventHandler(sender, e);
            _importingMode = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewEventHandler(sender, e);
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            QueryEventHandler(sender, e);
            _importingMode = false;
        }
    }
}
