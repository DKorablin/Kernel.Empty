using System;
using SAL.Flatbed;

namespace Kernel.Empty
{
	public class PluginWindows : IPluginKernel
	{
		Boolean IPlugin.OnConnection(ConnectMode mode)
			=> true;

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
			=> true;
	}
}