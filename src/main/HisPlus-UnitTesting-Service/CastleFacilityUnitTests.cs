using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using HisPlus.Contract;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.UnitTesting
{
    public class CastleFacilityUnitTests
    {
        [Fact(Skip="true")]
        public void Test_BasicHttpBinding()
        {
            IoCManager.Container.AddFacility<WcfFacility>().Register
            (Component.For<IBsGfxeService>().AsWcfClient(new DefaultClientModel
            {            
                Endpoint = WcfEndpoint.BoundTo(new BasicHttpBinding(BasicHttpSecurityMode.None)).At("http://localhost:14293/BsGfxeService.svc")
            }));

            var service = IoCManager.Container.Resolve<IBsGfxeService>();

            var result = service.GetAll();                    
        }

        [Fact(Skip="true")]
        public void Test_NetTcpBinding()
        {
            //IoCManager.Container.AddFacility<WcfFacility>().Register
            //(Component.For<IBsGfxeService>().AsWcfClient(new DefaultClientModel
            //{
            //    Endpoint = WcfEndpoint.BoundTo(new NetTcpBinding()).At("net.tcp://localhost:8088/BsGfxeService")
            //}));

            //var service = IoCManager.Container.Resolve<IBsGfxeService>();

            //var result = service.GetAll();            

            DuplexClientModel model = new DuplexClientModel
            {
                Endpoint = WcfEndpoint.ForContract<IBsGfxeService>()
                    .BoundTo(new NetTcpBinding())
                    .At("net.tcp://localhost/BsGfxeService")
            };

            IoCManager.Container.Register(WcfClient.ForChannels(model));

            var service = IoCManager.Container.Resolve<IBsGfxeService>();

            var result = service.GetAll();
        }
    }
}
