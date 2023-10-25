using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200043B RID: 1083
	// (Invoke) Token: 0x06001C64 RID: 7268
	[Token(Token = "0x200043B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinLobbyAcceptedCallbackInternal(ref JoinLobbyAcceptedCallbackInfoInternal data);
}
