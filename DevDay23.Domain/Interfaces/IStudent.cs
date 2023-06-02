using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay23.Domain.Interfaces
{
    public interface IStudent
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
        IEnumerable<Student> GetAll();
    }
}
