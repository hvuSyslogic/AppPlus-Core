using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public class HisPlusConfigurationSection : ConfigurationSection
    {
        #region Constants

        private const string ServiceCallModeAttributeName = "serviceCallMode";   

        #endregion

        #region Properties

        [ConfigurationProperty(ServiceCallModeAttributeName, IsRequired = true)]
        public ServiceCallMode ServiceCallMode
        {
            get 
            {
                var serviceCallMode = this[ServiceCallModeAttributeName] ?? "";
                return (ServiceCallMode)Enum.Parse(typeof(ServiceCallMode), serviceCallMode.ToString());
            }
        }

        [ConfigurationProperty("middleWare", IsDefaultCollection = false)]
        public MiddleWareSection Middle
        {
            get { return (MiddleWareSection)base["middleWare"]; }
            set { base["middleWare"] = value; }
        }

        #endregion
    }

}
