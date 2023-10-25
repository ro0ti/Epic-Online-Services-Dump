using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200067A RID: 1658
	// (Invoke) Token: 0x06002A6B RID: 10859
	[Token(Token = "0x200067A")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnVerifyIdTokenCallbackInternal(ref VerifyIdTokenCallbackInfoInternal data);
}
