using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000139 RID: 313
	// (Invoke) Token: 0x06000982 RID: 2434
	[Token(Token = "0x2000139")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSessionInviteAcceptedCallbackInternal(ref SessionInviteAcceptedCallbackInfoInternal data);
}
