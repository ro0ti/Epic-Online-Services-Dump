using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000620 RID: 1568
	// (Invoke) Token: 0x06002839 RID: 10297
	[Token(Token = "0x2000620")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCreateUserCallbackInternal(ref CreateUserCallbackInfoInternal data);
}
