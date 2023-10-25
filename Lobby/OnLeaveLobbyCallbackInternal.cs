using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000443 RID: 1091
	// (Invoke) Token: 0x06001C84 RID: 7300
	[Token(Token = "0x2000443")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLeaveLobbyCallbackInternal(ref LeaveLobbyCallbackInfoInternal data);
}
