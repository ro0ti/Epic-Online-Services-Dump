using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000628 RID: 1576
	// (Invoke) Token: 0x06002859 RID: 10329
	[Token(Token = "0x2000628")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLoginStatusChangedCallbackInternal(ref LoginStatusChangedCallbackInfoInternal data);
}
