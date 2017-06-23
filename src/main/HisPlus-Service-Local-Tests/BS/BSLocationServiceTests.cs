﻿using AppPlus.Client;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.BS
{
    public class BSLocationServiceTests : TestBase
    {
        [Fact]
        public void TestMethod()
        {
            var result = ServiceHandler.CallService((IBsLocationService x) => x.RetrieveAll());
        }
    }
}