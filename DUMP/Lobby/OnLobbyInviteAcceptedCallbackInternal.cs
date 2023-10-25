using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000447 RID: 1095
	// (Invoke) Token: 0x06001C94 RID: 7316
	[Token(Token = "0x2000447")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyInviteAcceptedCallbackInternal(ref LobbyInviteAcceptedCallbackInfoInternal data);
}
