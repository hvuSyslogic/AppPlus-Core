using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using HisPlus.Core.Abstractions.Support;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using HisPlus.Contract.Messages;
using HisPlus.Infrastructure.CodeContracts;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Services
{
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
            return UnitOfWork.Do(uow => 
            {
                var queryable = uow.Repo<BsPatient>().Get(x => x.CardNo == cardNo).Join(
                    uow.Repo<InHosInfo>().Get(),
                    x => x.InPatNo,
                    y => y.InPatNo,
                    (x, y) => new PatientInHosInfo { Patient = x, InHosInfo = y });

                if (queryable.LongCount() > 0)
                {
                    var result = queryable.First();

                    return new PatientInHosInfoDTO()
                    {
                        Patient = result.Patient.MapTo<BsPatientDTO>(),
                        InHosInfo = result.InHosInfo.MapTo<InHosInfoDTO>()
                    };
                }

                return null;
            });

            
        }

        public IEnumerable<GblRoleDTO> L1CacheTest()
        {
            var currentDateTime = GetCurrentDateTime();

            return UnitOfWork.Do(uow => 
            {
                var date = uow.Repo<BsPatient>();

                var query1 = uow.Repo<GblRole>().Get();
                var query2 = uow.Repo<BsPatient>().Get()
                    .Where(x => (x.BirthDate > currentDateTime));
                
                query2.ToList();

                return query1.MapTo<GblRoleDTO>();
            });
        }

        public bool L1Transaction()
        {
            return UnitOfWork.Do(uow => 
            {
                var role = uow.Repo<GblRole>().Get().FirstOrDefault();
                Requires.NotNull(role, "role");
                role.IconIndex = 9999;
                uow.Repo<GblRole>().Update(role);

                var roleModule = uow.Repo<GblRoleModule>().Get().FirstOrDefault();
                Requires.NotNull(roleModule, "roleModule");

                roleModule.ModuleId = 9999999;
                uow.Repo<GblRoleModule>().Add(roleModule);

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
                LocationService.Add(locationDTO);
            });
        }
    }
}