using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000DD RID: 221
	// (Invoke) Token: 0x060007BC RID: 1980
	[Token(Token = "0x20000DD")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryStatsCompleteCallbackInternal(ref OnQueryStatsCompleteCallbackInfoInternal data);
}
