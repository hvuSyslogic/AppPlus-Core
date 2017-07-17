using HisPlus.Core;
using HisPlus.Core.EntityFramework;
using HisPlus.Core.Infrastructure.CodeContracts;
using HisPlus.Core.Service;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Services
{
    [GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]    
    public class SampleService : ServiceRoot, ISampleService
    {
        class PatientInHosInfo
        {
            internal BsPatient Patient { get; set; }
            internal InHosInfo InHosInfo { get; set; }
        }

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        public IGblRoleService RoleService { get; set; }

        public IGblRoleModuleService RoleModuleService { get; set; }

        public PatientInHosInfoDTO GetPatientInHosInfo(string cardNo)
        {
            var c = UnitOfWork.Do(uow => 
            {
                var queryable = uow.Repo<BsPatient>().Retrieve(x => x.CardNo == cardNo).Join(
                    uow.Repo<InHosInfo>().Retrieve(),
                    x => x.InPatNo,
                    y => y.InPatNo,
                    (x, y) => new PatientInHosInfo { Patient = x, InHosInfo = y });
                
                return queryable.First();
            });

            return new PatientInHosInfoDTO()
            {
                Patient = c.Patient.MapTo<BsPatientDTO>(),
                InHosInfo = c.InHosInfo.MapTo<InHosInfoDTO>()
            };
        }

        public IEnumerable<GblRoleDTO> L1CacheTest()
        {
            var currentDateTime = GetCurrentDateTime();

            return UnitOfWork.Do(uow => 
            {
                var date = uow.Repo<BsPatient>();

                var query1 = uow.Repo<GblRole>().Retrieve();
                var query2 = uow.Repo<BsPatient>().Retrieve()
                    .Where(x => (x.BirthDate > currentDateTime));
                
                query2.ToList();

                return query1.MapTo<GblRoleDTO>();
            });
        }

        public bool TransactionTest()
        {
            return UnitOfWork.Do(uow => 
            {
                var role = uow.Repo<GblRole>().Retrieve().FirstOrDefault();
                Requires.NotNull(role, "role");
                role.IconIndex = 9999;
                uow.Repo<GblRole>().Update(role);

                var roleModule = uow.Repo<GblRoleModule>().Retrieve().FirstOrDefault();
                Requires.NotNull(roleModule, "roleModule");

                roleModule.ModuleId = 9999999;
                uow.Repo<GblRoleModule>().Create(roleModule);

                return true;
            });
        }
    }
}