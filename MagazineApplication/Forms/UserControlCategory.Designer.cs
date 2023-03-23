namespace MagazineApplication.Forms
{
    partial class UserControlCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Management";
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Active,
            this.CreatedBy,
            this.CreatedOn,
            this.UpdatedBy,
            this.UpdatedOn});
            this.productDataGridView.Location = new System.Drawing.Point(6, 47);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(1084, 612);
            this.productDataGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.Width = 125;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.MinimumWidth = 6;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 125;
            // 
            // CreatedOn
            // 
            this.CreatedOn.HeaderText = "CreatedOn";
            this.CreatedOn.MinimumWidth = 6;
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.Width = 125;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.HeaderText = "UpdatedBy";
            this.UpdatedBy.MinimumWidth = 6;
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.Width = 125;
            // 
            // UpdatedOn
            // 
            this.UpdatedOn.HeaderText = "UpdatedOn";
            this.UpdatedOn.MinimumWidth = 6;
            this.UpdatedOn.Name = "UpdatedOn";
            this.UpdatedOn.Width = 125;
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.label1);
            //this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(1093, 792);
            this.Load += new System.EventHandler(this.UserControlCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedOn;
    }
}
