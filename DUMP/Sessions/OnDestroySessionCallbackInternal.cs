using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000123 RID: 291
	// (Invoke) Token: 0x06000932 RID: 2354
	[Token(Token = "0x2000123")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDestroySessionCallbackInternal(ref DestroySessionCallbackInfoInternal data);
}
