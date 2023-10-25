using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200061C RID: 1564
	// (Invoke) Token: 0x06002829 RID: 10281
	[Token(Token = "0x200061C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAuthExpirationCallbackInternal(ref AuthExpirationCallbackInfoInternal data);
}
