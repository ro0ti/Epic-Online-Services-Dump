using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200061E RID: 1566
	// (Invoke) Token: 0x06002831 RID: 10289
	[Token(Token = "0x200061E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCreateDeviceIdCallbackInternal(ref CreateDeviceIdCallbackInfoInternal data);
}
