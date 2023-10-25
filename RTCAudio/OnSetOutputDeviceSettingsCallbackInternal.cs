using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001FB RID: 507
	// (Invoke) Token: 0x06000DFD RID: 3581
	[Token(Token = "0x20001FB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSetOutputDeviceSettingsCallbackInternal(ref OnSetOutputDeviceSettingsCallbackInfoInternal data);
}
