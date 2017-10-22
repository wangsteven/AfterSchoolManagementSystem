using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using System.Reflection;
using System.Windows.Forms;

namespace AfterSchoolManagementSystem.Presenters
{
    public class StudentSelectionPresenter : Presenter<IStudentSelectionView>
    {
        private StudentList _studentListInstance;
        public StudentSelectionPresenter(IStudentSelectionView view) 
            : base(view)
        {
            View.Load += View_Load;
            View.SelectEventHandler += View_Update;
            View.AddNewEventHandler += View_AddNew;
            View.RemoveEventHandler += View_Remove;

            _studentListInstance = new StudentList();
        }

        private void View_Load(object sender, System.EventArgs e)
        {

            //View.Model = StudentSelection.Instance;
            View.SetDataSource();
        }       

        private void View_Update(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Select(sender as student);
            }

        }

        private void View_AddNew(object sender, System.EventArgs e)
        {
            if (sender == null)
            {
                student selstudent = new student();
                selstudent.studentId = _studentListInstance.GetMaxStudentId() + 1;

                var type = GetViewTypeFromInterface(typeof(IStudentDetailView));

                IStudentDetailView detailview = Activator.CreateInstance(type) as IStudentDetailView;
                detailview.Model = selstudent;
                if (DialogResult.Cancel != detailview.ShowDialogBox())
                {
                    _studentListInstance.Insert(selstudent);
                    View.Model.Add(sender as student);
                }
            }

        }

        private void View_Remove(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Unselect(sender as student);
            }

        }

        private Type GetViewTypeFromInterface(Type type)
        {
            Type viewType = null;

            var assembly = Assembly.GetExecutingAssembly();

            foreach (var exportedType in assembly.GetExportedTypes().Where(t => t.IsSubclassOf(typeof(Control))))
            {
                if (type.IsAssignableFrom(exportedType))
                {
                    viewType = exportedType;
                    break;
                }
            }

            return viewType;
        }
    }
}
