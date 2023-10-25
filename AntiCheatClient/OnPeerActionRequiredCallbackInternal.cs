using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x0200070C RID: 1804
	// (Invoke) Token: 0x06002E08 RID: 11784
	[Token(Token = "0x200070C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPeerActionRequiredCallbackInternal(ref OnClientActionRequiredCallbackInfoInternal data);
}
