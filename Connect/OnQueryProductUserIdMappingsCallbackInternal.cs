using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200062C RID: 1580
	// (Invoke) Token: 0x06002869 RID: 10345
	[Token(Token = "0x200062C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryProductUserIdMappingsCallbackInternal(ref QueryProductUserIdMappingsCallbackInfoInternal data);
}
