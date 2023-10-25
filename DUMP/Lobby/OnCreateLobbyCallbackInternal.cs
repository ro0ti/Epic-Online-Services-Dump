using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000435 RID: 1077
	// (Invoke) Token: 0x06001C4C RID: 7244
	[Token(Token = "0x2000435")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCreateLobbyCallbackInternal(ref CreateLobbyCallbackInfoInternal data);
}
