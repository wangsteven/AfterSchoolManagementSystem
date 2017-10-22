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
    public partial class CareReservationView :  MvpForm<CareReservationList>, ICareReservationView
    {
        public event EventHandler UpdateEventHandler;
        public event EventHandler AddNewEventHandler;
        public event EventHandler RemoveEventHandler;

        public CareReservationView()
        {
            InitializeComponent();
        }


        public void SetDataSource()
        {
            bindingSource_careReservation.DataSource = Model.GetList();
            bindingNavigator_careReservation.BindingSource = bindingSource_careReservation;
            dataGridView_careReservation.DataSource = bindingSource_careReservation;
        }



        public void SetTitile(string title)
        {
            this.Text = title;
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
    }
}
