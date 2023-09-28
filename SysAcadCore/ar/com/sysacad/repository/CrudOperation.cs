using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository
{
    public interface CrudOperation<T>
    {
        public bool Save(T entity);
        public List<T> GetAll();
        public T GetById(int id);
        public T DeleteById(int id);
    }
}
