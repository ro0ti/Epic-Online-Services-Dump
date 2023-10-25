using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200045F RID: 1119
	// (Invoke) Token: 0x06001CF4 RID: 7412
	[Token(Token = "0x200045F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateLobbyCallbackInternal(ref UpdateLobbyCallbackInfoInternal data);
}
