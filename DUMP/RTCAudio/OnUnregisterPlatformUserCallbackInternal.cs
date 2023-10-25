using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001FF RID: 511
	// (Invoke) Token: 0x06000E18 RID: 3608
	[Token(Token = "0x20001FF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUnregisterPlatformUserCallbackInternal(ref OnUnregisterPlatformUserCallbackInfoInternal data);
}
