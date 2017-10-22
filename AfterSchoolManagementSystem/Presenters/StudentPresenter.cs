using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Windows.Forms;

using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Presenters
{
    public class StudentPresenter : Presenter<IStudentView>
    {
        private StudentList _studentListInstance;
        public StudentPresenter(IStudentView view) 
            : base(view)
        {
            View.Load += View_Load;
            View.OpenDetailView += View_OpenDetailView;

            _studentListInstance = new StudentList();
        }

        private void View_Load(object sender, System.EventArgs e)
        {

            View.Model = _studentListInstance;
            View.SetDataSource();
        }

        private void View_OpenDetailView(object sender, System.EventArgs e)
        {
            student selstudent = null;
            if (e != null)
            {
                selstudent = View.Model.Students[View.GetSelectedRowIndex()];
            }
            else
            {
                selstudent = new student();
                selstudent.studentId = _studentListInstance.GetMaxStudentId() + 1;                
                View.Model.Insert(selstudent);
            }
            
            var type = GetViewTypeFromInterface(typeof(IStudentDetailView));

            IStudentDetailView detailview = Activator.CreateInstance(type) as IStudentDetailView;
            detailview.Model = selstudent;
            if(DialogResult.Cancel != detailview.ShowDialogBox())
            {
               //View.Model = _studentListInstance; ;
               View.SetDataSource();
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
