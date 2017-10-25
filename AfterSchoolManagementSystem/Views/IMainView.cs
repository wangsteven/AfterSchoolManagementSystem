using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchoolManagementSystem.Views
{
    public interface IMainView : ICoreView
    {
        event EventHandler LoadStudentForm;
        event EventHandler LoadTeacherListForm;
        event EventHandler LoadTodayCareReservationForm;
        event EventHandler LoadCareRecordForm;
        event EventHandler LoadTodayCareRecordListForm;
        void ConfirmLoaded();
        void LoadChildForm(Type childFormType);
    }
}
