using DepartmentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentLogic
{
    public class Controller
    {
        /// <summary>
        /// entities containing all departments
        /// </summary>
        public DepartmentEntities departmentEnt = new DepartmentEntities();

        public Department GetDepartments()
        {
            var headDept = departmentEnt.Department.Where(x => x.parent_id == null).FirstOrDefault();
            headDept.subDepartments = GetSubDepartmentList(headDept.id);
            return headDept;
        }
        
        private List<Department> GetSubDepartmentList(int id)
        {
            var subDepartmentList = new List<Department>();
            foreach (var dept in departmentEnt.Department)
            {
                if (dept.parent_id == id)
                {
                    dept.subDepartments = GetSubDepartmentList(dept.id);
                    subDepartmentList.Add(dept);
                }
            }
            return subDepartmentList;
        }

        public void AddDepartment(string depName, Department parent)
        {
            departmentEnt.Department.Add(new Department() { name = depName, parent_id = parent.id });
            departmentEnt.SaveChanges();
        }

        public void DeleteDepartment(string toDeleteDeptStr)
        {
            var toDeleteDept = departmentEnt.Department.Where(x => x.name == toDeleteDeptStr).FirstOrDefault();
            foreach (var dept in departmentEnt.Department.Where(x => x.parent_id == toDeleteDept.id).ToList())
            {
                DeleteDepartment(dept.name);
            }
            departmentEnt.Department.Remove(toDeleteDept);
            departmentEnt.SaveChanges();
        }
    }
}
