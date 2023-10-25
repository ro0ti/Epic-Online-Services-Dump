using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B6 RID: 1462
	// (Invoke) Token: 0x0600257C RID: 9596
	[Token(Token = "0x20005B6")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCustomInviteAcceptedCallbackInternal(ref OnCustomInviteAcceptedCallbackInfoInternal data);
}
