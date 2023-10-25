using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F7 RID: 503
	// (Invoke) Token: 0x06000DE2 RID: 3554
	[Token(Token = "0x20001F7")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSetInputDeviceSettingsCallbackInternal(ref OnSetInputDeviceSettingsCallbackInfoInternal data);
}
