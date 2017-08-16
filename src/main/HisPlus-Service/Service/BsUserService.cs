using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Core.Abstractions.Support;
using HisPlus.Domain;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Redis;

namespace HisPlus.Services
{
	public class BsUserService : AbstractService<BsUser, BsUserDTO, int>, IBsUserService
	{
        public BsUserDTO ValidateUser(string userId, string password)
        {
            return UnitOfWork.Do(uow =>
            {
                var st = new System.Diagnostics.Stopwatch();
                st.Start();
                string location = "";
                try
                {
                    var userCode = RedisContext.Cache.GetKeysByTagA(new[] { string.Format("BsUserDTO:Code:{0}", userId) }).ToList().FirstOrDefault();
                    if (!string.IsNullOrWhiteSpace(userCode))
                    {
                        location = "Redis";
                        return RedisContext.Cache.GetHashed<BsUserDTO>(userCode);
                    }
                    else
                    {
                        var queryable = uow.Repo<BsUser>().Get(x => x.Code == userId && x.Password == password);
                        location = "SQLServer";
                        if (queryable.Any())
                        {
                            return queryable.Single().MapTo<BsUserDTO>();
                        }
                    }
                }
                finally
                {
                    st.Stop();
                    Logger.InfoFormat("-----It took us {0} ms to fetch user from {1}", st.Elapsed.TotalMilliseconds, location);
                }

                return null;
            });
        }
	}
}
