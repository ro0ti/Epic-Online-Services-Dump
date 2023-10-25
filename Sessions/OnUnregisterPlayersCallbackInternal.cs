using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000141 RID: 321
	// (Invoke) Token: 0x060009A2 RID: 2466
	[Token(Token = "0x2000141")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUnregisterPlayersCallbackInternal(ref UnregisterPlayersCallbackInfoInternal data);
}
