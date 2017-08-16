using HisPlus.Client;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HisPlus.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(BsUserDTO user)
            : this()
        {
            tsbUserId.Text = user.Name;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var locations = ServiceHandler.CallService((IBsLocationService x) => x.GetAll());
            this.dataGridView1.DataSource = locations;
        }
    }
}
