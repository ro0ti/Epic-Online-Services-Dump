using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000B2 RID: 178
	// (Invoke) Token: 0x060006A3 RID: 1699
	[Token(Token = "0x20000B2")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeleteCacheCompleteCallbackInternal(ref DeleteCacheCallbackInfoInternal data);
}
