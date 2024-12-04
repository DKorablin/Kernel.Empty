using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("751767ef-99cb-4f5a-9bab-88656ffbbb17")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://dkorablin.ru/project/Default.aspx?File=82")]
#else

[assembly: AssemblyTitle("Kernel.Empty")]
[assembly: AssemblyDescription("Empty kernel plugin to unify shared logic between plugin groups")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Kernel.Empty")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2010-2024")]
#endif