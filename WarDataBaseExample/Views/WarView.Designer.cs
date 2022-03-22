namespace WarDataBaseExample.Views
{
    partial class WarView
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
            this.dgvWarior = new System.Windows.Forms.DataGridView();
            this.wariorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblKills = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.killsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wariorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWarior
            // 
            this.dgvWarior.AutoGenerateColumns = false;
            this.dgvWarior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarior.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.killsDataGridViewTextBoxColumn,
            this.Id,
            this.healthDataGridViewTextBoxColumn});
            this.dgvWarior.DataSource = this.wariorBindingSource;
            this.dgvWarior.Location = new System.Drawing.Point(0, 0);
            this.dgvWarior.Name = "dgvWarior";
            this.dgvWarior.RowHeadersWidth = 51;
            this.dgvWarior.RowTemplate.Height = 24;
            this.dgvWarior.Size = new System.Drawing.Size(302, 222);
            this.dgvWarior.TabIndex = 0;
            // 
            // wariorBindingSource
            // 
            this.wariorBindingSource.DataSource = typeof(WarDataBaseExample.Models.Warior);
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Location = new System.Drawing.Point(411, 40);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(31, 16);
            this.lblKills.TabIndex = 1;
            this.lblKills.Text = "Kills";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(411, 78);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(46, 16);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health";
            // 
            // txtKills
            // 
            this.txtKills.Location = new System.Drawing.Point(467, 40);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(100, 22);
            this.txtKills.TabIndex = 3;
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(467, 78);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(100, 22);
            this.txtHealth.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(645, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(645, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // killsDataGridViewTextBoxColumn
            // 
            this.killsDataGridViewTextBoxColumn.DataPropertyName = "Kills";
            this.killsDataGridViewTextBoxColumn.HeaderText = "Kills";
            this.killsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.killsDataGridViewTextBoxColumn.Name = "killsDataGridViewTextBoxColumn";
            this.killsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // healthDataGridViewTextBoxColumn
            // 
            this.healthDataGridViewTextBoxColumn.DataPropertyName = "Health";
            this.healthDataGridViewTextBoxColumn.HeaderText = "Health";
            this.healthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthDataGridViewTextBoxColumn.Name = "healthDataGridViewTextBoxColumn";
            this.healthDataGridViewTextBoxColumn.Width = 125;
            // 
            // WarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarDataBaseExample.Properties.Resources.WarBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.dgvWarior);
            this.Name = "WarView";
            this.Text = "WarView";
            this.Load += new System.EventHandler(this.WarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wariorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWarior;
        private System.Windows.Forms.BindingSource wariorBindingSource;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtKills;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn killsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthDataGridViewTextBoxColumn;
    }
}