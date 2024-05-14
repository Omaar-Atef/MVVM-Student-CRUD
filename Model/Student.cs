using MVVM_D2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_D2.Model
{
    public class Student : ViewModelBase
    {
        int id;
        string name;
        string address;
        int age;
        int grade;

        public int Id 
        {
            get { return id; } 
            set { id = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged(); }
        }

        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(); }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; OnPropertyChanged(); }
        }
    }
}
