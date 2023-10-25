using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x0600040B RID: 1035
	[Token(Token = "0x2000049")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryUserInfoByExternalAccountCallbackInternal(ref QueryUserInfoByExternalAccountCallbackInfoInternal data);
}
