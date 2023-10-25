using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200043F RID: 1087
	// (Invoke) Token: 0x06001C74 RID: 7284
	[Token(Token = "0x200043F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinLobbyCallbackInternal(ref JoinLobbyCallbackInfoInternal data);
}
