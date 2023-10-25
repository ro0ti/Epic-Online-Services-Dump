using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000678 RID: 1656
	// (Invoke) Token: 0x06002A63 RID: 10851
	[Token(Token = "0x2000678")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryIdTokenCallbackInternal(ref QueryIdTokenCallbackInfoInternal data);
}
