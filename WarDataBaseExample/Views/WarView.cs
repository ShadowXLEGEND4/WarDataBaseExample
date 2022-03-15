using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarDataBaseExample.Controllers;
using WarDataBaseExample.Models;

namespace WarDataBaseExample.Views
{
    public partial class WarView : Form
    {
        ShowWariorController showWariorController = new ShowWariorController();

        public WarView()
        {
            InitializeComponent();
        }

        private void WarView_Load(object sender, EventArgs e)
        {
            dgvWarior.DataSource = showWariorController.GetAll();
        }

        private void RefreshTable()
        {
            dgvWarior.DataSource = showWariorController.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Warior warior = new Warior();
            warior.Kills = int.Parse(txtKills.Text);
            warior.Health = int.Parse(txtHealth.Text);
            showWariorController.CreateWarior(warior);
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvWarior.CurrentRow;
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            ShowWariorController.DeleteWarior(id);
            RefreshTable();
        }
    }
}
