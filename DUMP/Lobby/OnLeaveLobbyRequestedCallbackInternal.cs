using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000445 RID: 1093
	// (Invoke) Token: 0x06001C8C RID: 7308
	[Token(Token = "0x2000445")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLeaveLobbyRequestedCallbackInternal(ref LeaveLobbyRequestedCallbackInfoInternal data);
}
