using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200043D RID: 1085
	// (Invoke) Token: 0x06001C6C RID: 7276
	[Token(Token = "0x200043D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinLobbyByIdCallbackInternal(ref JoinLobbyByIdCallbackInfoInternal data);
}
