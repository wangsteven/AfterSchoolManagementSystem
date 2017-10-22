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
    public partial class TodayCareReservationView :  MvpForm<CurrentCareReservationList>, ITodayCareReservationView
    {
        public event EventHandler UpdateEventHandler;
        public event EventHandler AddNewEventHandler;
        public event EventHandler RemoveEventHandler;

        public event EventHandler WeekdaySelectedEventHandler;
        public event EventHandler ReCreateEventHandler;
        public event EventHandler ExportEventHandler;

        private int _selectedweekday;

        public TodayCareReservationView()
        {
            InitializeComponent();
            _selectedweekday = (int)(DateTime.Now.DayOfWeek);
        }


        public void SetDataSource()
        {
            bindingSource_careReservation.DataSource = Model.GetList();
            bindingNavigator_careReservation.BindingSource = bindingSource_careReservation;
            dataGridView_careReservation.DataSource = bindingSource_careReservation;
            this.Refresh();
        }

        public int GetSelectedWeekday()
        {
            return _selectedweekday;
        }


        public DialogResult ShowDialogBox()
        {
            return this.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           if (AddNewEventHandler != null)
            {
                object obj = bindingNavigator_careReservation.BindingSource.Current;
                AddNewEventHandler(obj, e);

                SetDataSource();
                dataGridView_careReservation.Refresh();
            }     
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int cRow = dataGridView_careReservation.CurrentCell.RowIndex;

            // 删除前的用户确认 
            if (MessageBox.Show("确认要删除该行数据吗？", "删除确认",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                object obj = bindingNavigator_careReservation.BindingSource.Current;
                if (RemoveEventHandler != null)
                {
                    RemoveEventHandler(obj, e);
                }
                bindingNavigator_careReservation.BindingSource.RemoveCurrent();
            }       
 
        }


        private void dataGridView_careReservation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (UpdateEventHandler != null)
            {
                object obj = bindingNavigator_careReservation.BindingSource.Current;
                UpdateEventHandler(obj, e);
            }     

        }

        private void toolStripComboBox_Weekday_DropDownClosed(object sender, EventArgs e)
        {
           _selectedweekday =  toolStripComboBox_Weekday.SelectedIndex > 0 ? toolStripComboBox_Weekday.SelectedIndex : 1;
           if (WeekdaySelectedEventHandler != null)
           {
               WeekdaySelectedEventHandler(sender, e);
           }
        }

        private void toolStripButton_Create_Click(object sender, EventArgs e)
        {
            if (ReCreateEventHandler != null)
            {
                ReCreateEventHandler(sender, e);
            }           

        }

        private void toolStripButton_Export_Click(object sender, EventArgs e)
        {
            if (ExportEventHandler != null)
            {
                ExportEventHandler(sender, e);
            }   

        }


    }
}
