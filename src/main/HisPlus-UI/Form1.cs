using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Serialize.Linq.Extensions;
using HisPlus.Infrastructure;
using HisPlus.Client;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Infrastructure.DependencyInjection;

namespace HisPlus.UI
{
    public partial class Form1 : Form
    {
        static bool IsInitialized = false;

        static Form1()
        {
            new Thread((ThreadStart)delegate()
            {
                var result = ServiceHandler.CallService((IBsUserService x) => x.GetCurrentDateTime());
                IsInitialized = true;
            }).Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AssertInitializationCompleted()
        {
            int ms = 1;

            new Thread((ThreadStart)delegate()
            {
                while (!IsInitialized)
                {
                    Thread.Sleep(ms);
                }
            }).Start();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {            
            string userId = TxtUserId.Text.Trim();
            string password = MD5Encrypt(TxtPasswrod.Text.Trim());

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("UserId can not be null or empty", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password can not be null or empty", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AssertInitializationCompleted();

            var userInfo =  ServiceHandler.CallService((IBsUserService x) => x.ValidateUser(userId, password));

            if (userInfo == null)
            {
                MessageBox.Show("UserId or Password is invalid", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainForm mainForm = new MainForm(userInfo);
            mainForm.Show();
        }
        
        public static string MD5Encrypt(string password)
        {
#pragma warning disable 0618
            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
#pragma warning restore 0618
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtUserId.Text = "";
            TxtPasswrod.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           TxtUserId.Text = "999999";
           TxtPasswrod.Text = "1";
        }
    }
}
