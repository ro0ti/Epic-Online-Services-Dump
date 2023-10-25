using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200044D RID: 1101
	// (Invoke) Token: 0x06001CAC RID: 7340
	[Token(Token = "0x200044D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyMemberStatusReceivedCallbackInternal(ref LobbyMemberStatusReceivedCallbackInfoInternal data);
}
