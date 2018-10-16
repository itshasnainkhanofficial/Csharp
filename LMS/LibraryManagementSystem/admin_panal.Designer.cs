﻿namespace LibraryManagementSystem
{
    partial class Registered_users
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
            this.components = new System.ComponentModel.Container();
            this.Registered_user_grid_view = new System.Windows.Forms.DataGridView();
            this.library_management_dbDataSet = new LibraryManagementSystem.library_management_dbDataSet();
            this.librarymanagementdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_name_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Registered_user_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarymanagementdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Registered_user_grid_view
            // 
            this.Registered_user_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Registered_user_grid_view.Location = new System.Drawing.Point(12, 39);
            this.Registered_user_grid_view.Name = "Registered_user_grid_view";
            this.Registered_user_grid_view.Size = new System.Drawing.Size(660, 294);
            this.Registered_user_grid_view.TabIndex = 0;
            this.Registered_user_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // library_management_dbDataSet
            // 
            this.library_management_dbDataSet.DataSetName = "library_management_dbDataSet";
            this.library_management_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librarymanagementdbDataSetBindingSource
            // 
            this.librarymanagementdbDataSetBindingSource.DataSource = this.library_management_dbDataSet;
            this.librarymanagementdbDataSetBindingSource.Position = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(713, 39);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(713, 115);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(713, 186);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // admin_name_lbl
            // 
            this.admin_name_lbl.AutoSize = true;
            this.admin_name_lbl.Location = new System.Drawing.Point(90, 9);
            this.admin_name_lbl.Name = "admin_name_lbl";
            this.admin_name_lbl.Size = new System.Drawing.Size(63, 13);
            this.admin_name_lbl.TabIndex = 6;
            this.admin_name_lbl.Text = "changeable";
            // 
            // Registered_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_name_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.Registered_user_grid_view);
            this.Name = "Registered_users";
            this.Text = "registered_users";
            this.Load += new System.EventHandler(this.Registered_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registered_user_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarymanagementdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Registered_user_grid_view;
        private System.Windows.Forms.BindingSource librarymanagementdbDataSetBindingSource;
        private library_management_dbDataSet library_management_dbDataSet;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label admin_name_lbl;
    }
}