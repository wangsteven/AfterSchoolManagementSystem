using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfterSchoolEntityModel;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Views
{
    public interface IStudentView : IView<StudentList>
    {
        void SetDataSource();
        event EventHandler OpenDetailView;
        int GetSelectedRowIndex();
    }
}
