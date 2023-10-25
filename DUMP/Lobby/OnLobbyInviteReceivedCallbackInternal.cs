using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000449 RID: 1097
	// (Invoke) Token: 0x06001C9C RID: 7324
	[Token(Token = "0x2000449")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyInviteReceivedCallbackInternal(ref LobbyInviteReceivedCallbackInfoInternal data);
}
