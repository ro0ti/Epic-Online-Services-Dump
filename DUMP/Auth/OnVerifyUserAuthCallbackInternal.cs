using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200067C RID: 1660
	// (Invoke) Token: 0x06002A73 RID: 10867
	[Token(Token = "0x200067C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnVerifyUserAuthCallbackInternal(ref VerifyUserAuthCallbackInfoInternal data);
}
