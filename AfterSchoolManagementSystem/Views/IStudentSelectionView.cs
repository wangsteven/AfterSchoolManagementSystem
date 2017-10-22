﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AfterSchoolEntityModel;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Views
{
    public interface IStudentSelectionView : IView<StudentSelection>
    {
        event EventHandler SelectEventHandler;
        event EventHandler AddNewEventHandler;
        event EventHandler RemoveEventHandler;


        void SetDataSource();
        DialogResult ShowDialogBox();
    }
}
