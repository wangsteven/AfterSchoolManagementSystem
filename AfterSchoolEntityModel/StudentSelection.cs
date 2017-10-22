using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.ComponentModel;

namespace AfterSchoolEntityModel
{
    public class StudentSelection
    {
        private static StudentSelection instance;
        
        public static StudentSelection Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                    instance = new StudentSelection();

                return instance;
            }
        }

        private List<student> _newstudents;
        private List<student> _removedstudents;
        private List<student> _selectedStudents;
        private List<student> _unselectedStudents;

        public StudentSelection()
        {
            _newstudents = new List<student>();
            _removedstudents = new List<student>();

            _selectedStudents = new List<student>();
            _unselectedStudents = new List<student>();
        }




        public IBindingList GetList()
        {
            return UnselectedStudents;
        }
        public  List<student> AllStudents
        {
            get
            {
                return DBModel.Instance.students;
            }
        }

        public BindingList<student> SelectedStudents
        {
            get
            {
                return new BindingList<student>(_selectedStudents);
            }
            set
            {
                _selectedStudents = value.ToList();
            }
        }

        public BindingList<student> UnselectedStudents
        {
            get
            {
                return new BindingList<student>(_unselectedStudents);
            }
            set
            {
                _unselectedStudents = value.ToList();
            }
        }

        public void Select(student stu)
        {
            SelectedStudents.Add(stu);
            UnselectedStudents.Remove(stu);

            if (!_newstudents.Contains(stu))
            {
                _newstudents.Add(stu);
            }

            if (_removedstudents.Contains(stu))
            {
                _removedstudents.Remove(stu);
            }
        }

        public void Add(student stu)
        {
            SelectedStudents.Add(stu);
            DBModel.Instance.Insert(stu);


            if (!_newstudents.Contains(stu))
            {
                _newstudents.Add(stu);
            }

            if (_removedstudents.Contains(stu))
            {
                _removedstudents.Remove(stu);
            }
        }

        public void Unselect(student stu)
        {
            UnselectedStudents.Add(stu);
            SelectedStudents.Remove(stu);

            if (_newstudents.Contains(stu))
            {
                _newstudents.Remove(stu);
            }

            if (!_removedstudents.Contains(stu))
            {
                _removedstudents.Add(stu);
            }

        }

        public List<student> GetNewSelectedStudents()
        {
            return _newstudents;
        }

        

        
    }
}
