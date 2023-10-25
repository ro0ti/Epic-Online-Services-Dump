using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000519 RID: 1305
	// (Invoke) Token: 0x0600215D RID: 8541
	[Token(Token = "0x2000519")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendInviteCallbackInternal(ref SendInviteCallbackInfoInternal data);
}
