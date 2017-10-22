using System;
using AfterSchoolMangementSystem.Views;
using WinFormsMvp;

namespace AfterSchoolMangementSystem.Presenters
{
    public class ChildFormPresenter : Presenter<IChildFormView>
    {
        public ChildFormPresenter(IChildFormView view) 
            : base(view)
        {
            View.Load += View_Load;
        }

        private void View_Load(object sender, System.EventArgs e)
        {
            View.SetTitleOnView("This ChildForm has loaded!");
        }
    }
}
