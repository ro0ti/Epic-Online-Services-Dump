using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000425 RID: 1061
	// (Invoke) Token: 0x06001BFC RID: 7164
	[Token(Token = "0x2000425")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void LobbySearchOnFindCallbackInternal(ref LobbySearchFindCallbackInfoInternal data);
}
