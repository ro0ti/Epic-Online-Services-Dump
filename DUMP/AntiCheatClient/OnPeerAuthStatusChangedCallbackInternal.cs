using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x0200070E RID: 1806
	// (Invoke) Token: 0x06002E10 RID: 11792
	[Token(Token = "0x200070E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPeerAuthStatusChangedCallbackInternal(ref OnClientAuthStatusChangedCallbackInfoInternal data);
}
