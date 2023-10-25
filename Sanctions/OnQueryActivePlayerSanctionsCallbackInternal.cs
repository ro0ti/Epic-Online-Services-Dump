using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001A8 RID: 424
	// (Invoke) Token: 0x06000C20 RID: 3104
	[Token(Token = "0x20001A8")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryActivePlayerSanctionsCallbackInternal(ref QueryActivePlayerSanctionsCallbackInfoInternal data);
}
