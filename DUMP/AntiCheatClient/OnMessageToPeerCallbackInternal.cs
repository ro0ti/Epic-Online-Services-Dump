using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000706 RID: 1798
	// (Invoke) Token: 0x06002DE9 RID: 11753
	[Token(Token = "0x2000706")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnMessageToPeerCallbackInternal(ref OnMessageToClientCallbackInfoInternal data);
}
