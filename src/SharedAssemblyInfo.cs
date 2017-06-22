using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AppPlus;

[assembly: AssemblyCompany(ProductInformation.Company)]
[assembly: AssemblyProduct(ProductInformation.Name)]
[assembly: AssemblyCopyright(ProductInformation.Copyright)]
[assembly: AssemblyTrademark(ProductInformation.Trademark)]

[assembly: AssemblyVersion(ProductInformation.VersionString)]
[assembly: AssemblyInformationalVersion(ProductInformation.InformationalVersion)]

[assembly: CLSCompliant(true)]

[assembly: AssemblyConfiguration(ProductInformation.Configuration)]

namespace AppPlus
{
    internal static class ProductInformation
    {
        internal const string VersionString = "1.17.43";
        internal const string Company = "Dragon Luo";
        internal const string Name = "App-Plus";
        internal const string Copyright = "Copyright © 2017 - 2020 Dragon Luo. All Rights Reserved.";
        internal const string Trademark = "App-Plus";
        internal const string InformationalVersion = VersionString;
        internal const string Configuration = "Debug";
    }
}
