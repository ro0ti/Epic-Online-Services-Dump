using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A1 RID: 1697
	// (Invoke) Token: 0x06002BA3 RID: 11171
	[Token(Token = "0x20006A1")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnClientActionRequiredCallbackInternal(ref OnClientActionRequiredCallbackInfoInternal data);
}
