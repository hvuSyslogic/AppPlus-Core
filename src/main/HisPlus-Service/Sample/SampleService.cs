using HisPlus.Core;
using HisPlus.Core.EntityFramework;
using HisPlus.Core.Infrastructure.CodeContracts;
using HisPlus.Core.Service;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

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

        public IGblRoleService RoleService { get; set; }
        
        public IBsLocationService LocationService { get; set; }

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

        public bool L1Transaction()
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

        public void L2Transaction(GblRoleDTO roleDTO, BsLocationDTO locationDTO)
        {
            Requires.NotNull(roleDTO, "roleDTO");
            Requires.NotNull(roleDTO, "locationDTO");

            roleDTO.GroupName = "Testing Group";
            locationDTO.PyCode = "9999999999999999999999999999999999999999999999999999999999999999";
            UnitOfWork.Do(uow =>
            {
                RoleService.Update(roleDTO);
                LocationService.Create(locationDTO);
            }, TransactionOption.TransactionScope);
        }
    }
}