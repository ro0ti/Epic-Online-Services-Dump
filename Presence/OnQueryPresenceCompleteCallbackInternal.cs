using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B8 RID: 696
	// (Invoke) Token: 0x0600130D RID: 4877
	[Token(Token = "0x20002B8")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryPresenceCompleteCallbackInternal(ref QueryPresenceCallbackInfoInternal data);
}
