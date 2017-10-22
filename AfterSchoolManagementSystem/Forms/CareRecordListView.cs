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
    public partial class CareRecordListView :   MvpForm<CareRecordList>, ICareRecordListView
    {
        private DateTime _startD;
        private DateTime _endD;
        private bool _selectAll;
        private int _selStudentId;
        public CareRecordListView()
        {
            InitializeComponent();

            _startD = DateTime.Now.AddDays(-1);
            _endD = DateTime.Now.AddDays(1);
            _selectAll = true;
            _selStudentId = -1;
        }

        public event EventHandler QueryEventHandler;
        public event EventHandler ImportEventHandler;
        public event EventHandler SaveEventHandler;

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
            return _startD;
        }

        public DateTime GetSelEndDate()
        {
            return _endD;
        }

        public int GetSelStudentId()
        {
            return _selStudentId;
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            _startD = dateTimePicker_Start.Value;
        }

        private void dateTimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            _endD =  dateTimePicker_End.Value;
        }

        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            _selectAll = checkBox_selectAll.Checked;
            if (_selectAll)
            {
                _selStudentId = -1;
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            QueryEventHandler.Invoke(sender, e);
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            SaveEventHandler.Invoke(sender, e);
        }

        private void comboBox_Students_DropDownClosed(object sender, EventArgs e)
        {
            var st = ((student)(bindingSource_student.Current));
            _selStudentId = st.studentId;
        }

        private void checkBox_selectToday_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_selectToday.Checked)
            {
                _startD = DateTime.Now;
                _endD = DateTime.Now;

                dateTimePicker_Start.Value = _startD;
                dateTimePicker_End.Value = _endD;
            }
        }
    }
}
