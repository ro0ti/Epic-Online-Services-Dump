using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000632 RID: 1586
	// (Invoke) Token: 0x06002881 RID: 10369
	[Token(Token = "0x2000632")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnVerifyIdTokenCallbackInternal(ref VerifyIdTokenCallbackInfoInternal data);
}
