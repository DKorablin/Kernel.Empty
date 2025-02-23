using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("751767ef-99cb-4f5a-9bab-88656ffbbb17")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://dkorablin.ru/project/Default.aspx?File=82")]
#else

[assembly: AssemblyDescription("Empty kernel plugin to unify shared logic between plugin groups")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2010-2024")]
#endif