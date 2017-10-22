using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AfterSchoolEntityModel;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Views
{
    public interface ICareReservationView : IView<CareReservationList>
    {
        void SetDataSource();
        void SetTitile(string title);
        DialogResult ShowDialogBox();
        

        event EventHandler UpdateEventHandler;
        event EventHandler AddNewEventHandler;
        event EventHandler RemoveEventHandler;
    }
}
