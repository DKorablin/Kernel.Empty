using System;
using SAL.Flatbed;

namespace Kernel.Empty
{
	public class Plugin : IPluginKernel
	{
		Boolean IPlugin.OnConnection(ConnectMode mode)
			=> true;

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
			=> true;
	}
}