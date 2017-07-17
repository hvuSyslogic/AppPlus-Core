using HisPlus.Client;
using HisPlus.Core.Redis;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HisPlus.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CacheProvider redis = new CacheProvider(0);
            
            new Thread((ThreadStart)delegate()
                {
                    var result = ServiceHandler.RetrievePagedData<IBsItemUnitService, BsItemUnitDTO, int>();
                }).Start();
        }

    }
}
