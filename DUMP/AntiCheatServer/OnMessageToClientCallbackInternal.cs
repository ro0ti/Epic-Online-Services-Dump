using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A5 RID: 1701
	// (Invoke) Token: 0x06002BB3 RID: 11187
	[Token(Token = "0x20006A5")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnMessageToClientCallbackInternal(ref OnMessageToClientCallbackInfoInternal data);
}
