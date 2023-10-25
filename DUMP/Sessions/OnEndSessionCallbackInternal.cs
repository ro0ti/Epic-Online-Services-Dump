using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000125 RID: 293
	// (Invoke) Token: 0x0600093A RID: 2362
	[Token(Token = "0x2000125")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnEndSessionCallbackInternal(ref EndSessionCallbackInfoInternal data);
}
