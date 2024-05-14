using MVVM_D2.Commands;
using MVVM_D2.DataService;
using MVVM_D2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MVVM_D2.ViewModel
{
    public class StudentViewModel
    {
        IDataService<Student> DataService;

        public Student SelectedStudent { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand EditCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        public ObservableCollection<Student> StudentList { get; set; }

        public StudentViewModel(IDataService<Student> StudentService)
        {
            DataService = StudentService;
            DeleteCommand = new(DeleteStudent,CanExecute);
            EditCommand = new(EditStudent,CanExecute);
            SaveCommand = new(SaveStudent,CanExecute);
            CancelCommand = new(CancelData,CanExecute);
            StudentList = new();
            SelectedStudent = new();
            Load();
        }

        private void ResetData()
        {
            SelectedStudent.Id = 0;
            SelectedStudent.Age = 0;
            SelectedStudent.Name = string.Empty;
            SelectedStudent.Address = string.Empty;
            SelectedStudent.Grade = 0;
        }

        private void CancelData(object obj)
        {
            ResetData();
        }

        private void SaveStudent(object obj=null)
        {
            if(SelectedStudent.Id<=0)
            {
                DataService.Add(SelectedStudent);
                System.Windows.MessageBox.Show("Saved Successfully");
            }
            else 
            {
                DataService.Update(SelectedStudent);
                System.Windows.MessageBox.Show("Edited Successfully");
            }
            Load();
            ResetData();
        }

        private void EditStudent(object obj)
        {
            var Std = obj as Student;
            if (Std != null) 
            {
                SelectedStudent.Id = Std.Id;
                SelectedStudent.Name = Std.Name;
                SelectedStudent.Age = Std.Age;
                SelectedStudent.Address = Std.Address;
                SelectedStudent.Grade = Std.Grade;
            }
        }

        private void DeleteStudent(object obj)
        {
            if(System.Windows.MessageBox.Show("Are You Sure","Delete Record", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                DataService.Delete((int)obj);
                System.Windows.MessageBox.Show("Employee Is Deleted");
                Load();
            }
           
        }

        public void Load()
        {
           var Students = DataService.GetAll();
            StudentList.Clear();
            foreach (Student Student in Students)
            {
                StudentList.Add(Student);
            }
        }

        private bool CanExecute(object obj)
        {
            return true;
        }
    }
}
