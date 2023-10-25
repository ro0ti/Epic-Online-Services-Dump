using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000674 RID: 1652
	// (Invoke) Token: 0x06002A53 RID: 10835
	[Token(Token = "0x2000674")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLoginStatusChangedCallbackInternal(ref LoginStatusChangedCallbackInfoInternal data);
}
