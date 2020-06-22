namespace DepartmentTree
{
    partial class DepartmentTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvDepartments
            // 
            this.tvDepartments.Location = new System.Drawing.Point(29, 42);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.Size = new System.Drawing.Size(304, 365);
            this.tvDepartments.TabIndex = 0;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(361, 43);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(50, 17);
            this.lblParent.TabIndex = 1;
            this.lblParent.Text = "Parent";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(361, 84);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(460, 84);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(121, 22);
            this.tbDepartment.TabIndex = 4;
            // 
            // cbParent
            // 
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(460, 43);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(121, 24);
            this.cbParent.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(460, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DepartmentTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 439);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbParent);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.tvDepartments);
            this.Name = "DepartmentTree";
            this.Text = "DepartmentTreeDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

