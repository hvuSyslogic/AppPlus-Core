using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public class HisPlusConfigurationManager
    {
        #region Constants

        private const string SectionName = "hisPlusConfiguration";

        #endregion

        public static HisPlusConfigurationSection HisPlusConfiguration
        {
            get
            {
                return (HisPlusConfigurationSection)ConfigurationManager.GetSection(SectionName);
            }
        }        
    }
}
