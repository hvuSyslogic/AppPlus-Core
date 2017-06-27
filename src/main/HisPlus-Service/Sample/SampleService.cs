using AppPlus.Core.Common.CodeContracts;
using AppPlus.Core.Service;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using log4net;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.His.Services
{
    public class SampleService : ServiceRoot, ISampleService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [Dependency]
        public IGblRoleService RoleService { get; set; }

        [Dependency]
        public IGblRoleModuleService RoleModuleService { get; set; }

        public void test()
        {
            //using (var command = CommandWrapper)
            //{
            //    command.Execute(x =>
            //    {
            //        command.Execute(uow =>
            //        {
            //            Log.Debug("uow 1: " + uow.GetHashCode());

            //            var role = uow.Retrieve<GblRole>().FirstOrDefault();
            //            Requires.NotNull(role, "role");
            //            role.F4 = "DELETED";
            //            uow.Update<GblRole>(role);
            //        });

            //        command.Execute(uow =>
            //        {
            //            Log.Debug("uow 2: " + uow.GetHashCode());

            //            var roleModule = uow.Retrieve<GblRoleModule>().FirstOrDefault();
            //            Requires.NotNull(roleModule, "roleModule");

            //            roleModule.Id = 0;
            //            roleModule.ModuleId = 9999999;
            //            uow.Create<GblRoleModule>(roleModule);
            //        });
            //    }, new Core.EntityFramework.UnitOfWorkSettings() { TransactionScope = Core.TransactionOption.TransactionScope });                
            //}
        }
    }
}