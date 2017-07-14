using HisPlus.Infrastructure.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PatientInHosInfoDTO : DtoRoot
    {
        [DataMember]
        public BsPatientDTO Patient { get; set; }

        [DataMember]
        public InHosInfoDTO InHosInfo { get; set; }
    }
}
