using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200045D RID: 1117
	// (Invoke) Token: 0x06001CEC RID: 7404
	[Token(Token = "0x200045D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendLobbyNativeInviteRequestedCallbackInternal(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data);
}
