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
    }
}
