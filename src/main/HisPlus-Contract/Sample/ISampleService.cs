﻿using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract.Services
{
    [ServiceContract]
    public interface ISampleService : IServiceRoot
    {
        [OperationContract]        
        IEnumerable<GblRoleDTO> L1CacheTest();

        [OperationContract]
        bool L1Transaction();

        [OperationContract]
        PatientInHosInfoDTO GetPatientInHosInfo(string cardNo);

        [OperationContract]
        void L2Transaction(GblRoleDTO roleDTO, BsLocationDTO locationDTO);
    }
}
