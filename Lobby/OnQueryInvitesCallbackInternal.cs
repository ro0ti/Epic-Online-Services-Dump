using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000455 RID: 1109
	// (Invoke) Token: 0x06001CCC RID: 7372
	[Token(Token = "0x2000455")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryInvitesCallbackInternal(ref QueryInvitesCallbackInfoInternal data);
}
