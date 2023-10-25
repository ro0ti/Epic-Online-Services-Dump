using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000708 RID: 1800
	// (Invoke) Token: 0x06002DF1 RID: 11761
	[Token(Token = "0x2000708")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnMessageToServerCallbackInternal(ref OnMessageToServerCallbackInfoInternal data);
}
