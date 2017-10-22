using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AfterSchoolManagementSystem.Views;
using WinFormsMvp.Forms;

namespace AfterSchoolManagementSystem.Forms
{
    public partial class MainView :   MvpForm , IMainView
    {

        public event EventHandler ViewLoding;
        public event EventHandler LoadStudentForm;
        public event EventHandler LoadTodayCareReservationForm;
        public event EventHandler LoadCareRecordForm;
        public event EventHandler LoadTodayCareRecordListForm;
        public MainView()
        {
            InitializeComponent();
        }

        public void ConfirmLoaded()
        {
            //lblStatusMessage.Text = "Main View has loaded.";
        }

        public void LoadChildForm(Type childFormType)
        {
            var constructors = childFormType.GetConstructors();
            var destinationView = constructors[0].Invoke(new object[] { }) as Form;

            destinationView.ShowDialog();
        }

        protected virtual void OnViewLoding()
        {
            ViewLoding.Invoke(this, EventArgs.Empty);
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            LoadStudentForm.Invoke(this, EventArgs.Empty);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            OnViewLoding();

            //base.OnLoad(e);
        }

        private void button_careReservation_Click(object sender, EventArgs e)
        {
            if (LoadTodayCareReservationForm != null)
            {
                LoadTodayCareReservationForm.Invoke(this, EventArgs.Empty);
            }
        }

        private void button_careRecord_Click(object sender, EventArgs e)
        {
            LoadCareRecordForm.Invoke(sender, e);
        }

        private void button_todayCareRecord_Click(object sender, EventArgs e)
        {
            if (LoadTodayCareRecordListForm != null)
            {
                LoadTodayCareRecordListForm.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
