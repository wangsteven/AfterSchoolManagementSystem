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
    public interface ITeacherListView : IView<TeacherList>
    {
        void SetDataSource();

        DialogResult ShowDialogBox();        

        event EventHandler UpdateEventHandler;
        event EventHandler AddNewEventHandler;
        event EventHandler RemoveEventHandler;
    }
}
