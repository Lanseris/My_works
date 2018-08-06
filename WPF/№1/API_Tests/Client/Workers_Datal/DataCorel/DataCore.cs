using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCorel
{
    public class DataCore
    {
        public EmploeersStore EmploeersStore_ { get; set; }
        public DepartmentStore DepartmentStore_ { get; set; }

        public DataCore()
        {
            EmploeersStore_=new EmploeersStore();
            DepartmentStore_ = new DepartmentStore(EmploeersStore_);
        }

        public void SaveAllData()
        {
            EmploeersStore_.SaveEmployeersData();
            DepartmentStore_.SaveDepartmentsData();
        }
    }
}
