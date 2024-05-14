using MVVM_D2.DataAccess;
using MVVM_D2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_D2.DataService
{
    public class StudentDataService : IDataService<Student>
    {
        public void Add(Student S)
        {
            if (S != null)
            {
                using (Context context = new())
                {
                    context.Students.Add(S);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (Context context = new())
            {
                var DeletedStudent = context.Students.Find(id);
                if (DeletedStudent != null)
                    context.Students.Remove(DeletedStudent);
                context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using(Context context = new()) 
            {
                context.Database.EnsureCreated();
                return context.Students.ToList();
            }
        }

        public void Update(Student S)
        {
            if(S != null)
            {
                using (Context context = new())
                {
                    context.Students.Update(S);
                    context.SaveChanges();
                }
            }
                
        }
    }
}
