using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000451 RID: 1105
	// (Invoke) Token: 0x06001CBC RID: 7356
	[Token(Token = "0x2000451")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyUpdateReceivedCallbackInternal(ref LobbyUpdateReceivedCallbackInfoInternal data);
}
