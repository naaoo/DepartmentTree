using DepartmentData;
using DepartmentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DepartmentTree
{
    public partial class DepartmentTree : Form
    {
        Controller controller = new Controller();

        public DepartmentTree()
        {
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            FillTreeView();
            FillParents();
        }

        private void FillTreeView()
        {
            tvDepartments.Nodes.Clear();
            var headDepartment = controller.GetDepartments();
            tvDepartments.Nodes.Add(AddNodes(headDepartment));
            tvDepartments.ExpandAll();
        }

        private void FillParents()
        {
            var headDepartment = controller.GetDepartments();
            var arrangedDepartments = ArrangeDepartments(headDepartment);
            cbParent.DataSource = arrangedDepartments;
        }

        private List<Department> ArrangeDepartments(Department parent)
        {
            var list = new List<Department>();
            list.Add(parent);
            foreach (var dept in parent.subDepartments)
            {
                var subList = ArrangeDepartments(dept);
                list.AddRange(subList);
            }
            return list;
        }

        private static TreeNode AddNodes(Department parentDept)
        {
            TreeNode node = new TreeNode();
            node.Nodes.Add(parentDept.name);
            foreach (var item in parentDept.subDepartments)
            {
                node.Nodes.Add(AddNodes(item));
            }
            return node;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var parent = cbParent.SelectedItem as Department;
            var name = tbDepartment.Text;
            controller.AddDepartment(name, parent);
            UpdateBoxes();
            cbParent.SelectedItem = null;
            tbDepartment.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var toDeleteDeptStr = tvDepartments.SelectedNode.Text;
            controller.DeleteDepartment(toDeleteDeptStr);
            UpdateBoxes();
        }
    }
}
