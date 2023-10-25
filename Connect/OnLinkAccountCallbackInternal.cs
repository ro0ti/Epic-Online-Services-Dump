using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000624 RID: 1572
	// (Invoke) Token: 0x06002849 RID: 10313
	[Token(Token = "0x2000624")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLinkAccountCallbackInternal(ref LinkAccountCallbackInfoInternal data);
}
