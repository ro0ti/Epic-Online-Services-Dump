using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200045B RID: 1115
	// (Invoke) Token: 0x06001CE4 RID: 7396
	[Token(Token = "0x200045B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendInviteCallbackInternal(ref SendInviteCallbackInfoInternal data);
}
