using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000676 RID: 1654
	// (Invoke) Token: 0x06002A5B RID: 10843
	[Token(Token = "0x2000676")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLogoutCallbackInternal(ref LogoutCallbackInfoInternal data);
}
