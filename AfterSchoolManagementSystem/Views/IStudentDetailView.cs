using System;
using System.Windows.Forms;
using WinFormsMvp;
using AfterSchoolEntityModel;

namespace AfterSchoolManagementSystem.Views
{
    public interface IStudentDetailView : IView<student>
    {
        DialogResult ShowDialogBox();
        event EventHandler ConfirmToSave;
        event EventHandler ConfirmToDelete;

        event EventHandler OpenCareReservationView;
    }
}
