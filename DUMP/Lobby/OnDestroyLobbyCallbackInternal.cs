using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000437 RID: 1079
	// (Invoke) Token: 0x06001C54 RID: 7252
	[Token(Token = "0x2000437")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDestroyLobbyCallbackInternal(ref DestroyLobbyCallbackInfoInternal data);
}
