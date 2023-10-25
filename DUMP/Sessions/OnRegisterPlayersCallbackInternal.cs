using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000131 RID: 305
	// (Invoke) Token: 0x06000962 RID: 2402
	[Token(Token = "0x2000131")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRegisterPlayersCallbackInternal(ref RegisterPlayersCallbackInfoInternal data);
}
