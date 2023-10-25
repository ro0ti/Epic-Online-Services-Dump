using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A3 RID: 1699
	// (Invoke) Token: 0x06002BAB RID: 11179
	[Token(Token = "0x20006A3")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnClientAuthStatusChangedCallbackInternal(ref OnClientAuthStatusChangedCallbackInfoInternal data);
}
