using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000672 RID: 1650
	// (Invoke) Token: 0x06002A4B RID: 10827
	[Token(Token = "0x2000672")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLoginCallbackInternal(ref LoginCallbackInfoInternal data);
}
