using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000129 RID: 297
	// (Invoke) Token: 0x0600094A RID: 2378
	[Token(Token = "0x2000129")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinSessionCallbackInternal(ref JoinSessionCallbackInfoInternal data);
}
