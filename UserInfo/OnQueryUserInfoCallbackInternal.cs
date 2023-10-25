using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x06000413 RID: 1043
	[Token(Token = "0x200004B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryUserInfoCallbackInternal(ref QueryUserInfoCallbackInfoInternal data);
}
