using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200044B RID: 1099
	// (Invoke) Token: 0x06001CA4 RID: 7332
	[Token(Token = "0x200044B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyInviteRejectedCallbackInternal(ref LobbyInviteRejectedCallbackInfoInternal data);
}
