using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000047 RID: 71
	// (Invoke) Token: 0x06000403 RID: 1027
	[Token(Token = "0x2000047")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryUserInfoByDisplayNameCallbackInternal(ref QueryUserInfoByDisplayNameCallbackInfoInternal data);
}
