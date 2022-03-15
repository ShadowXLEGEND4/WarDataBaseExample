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
            this.killsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // killsDataGridViewTextBoxColumn
            // 
            this.killsDataGridViewTextBoxColumn.DataPropertyName = "Kills";
            this.killsDataGridViewTextBoxColumn.HeaderText = "Kills";
            this.killsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.killsDataGridViewTextBoxColumn.Name = "killsDataGridViewTextBoxColumn";
            this.killsDataGridViewTextBoxColumn.Width = 125;
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
            this.Controls.Add(this.dgvWarior);
            this.Name = "WarView";
            this.Text = "WarView";
            this.Load += new System.EventHandler(this.WarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wariorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWarior;
        private System.Windows.Forms.DataGridViewTextBoxColumn killsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wariorBindingSource;
    }
}