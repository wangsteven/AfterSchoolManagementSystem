using System;
using WinFormsMvp;

namespace AfterSchoolMangementSystem.Views
{
    public interface IChildFormView : IView
    {
        void SetTitleOnView(string title);
    }
}
