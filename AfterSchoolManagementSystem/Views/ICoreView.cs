using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace AfterSchoolManagementSystem.Views
{
    public interface ICoreView : IView
    {
        event EventHandler ViewLoding;
    }
}
