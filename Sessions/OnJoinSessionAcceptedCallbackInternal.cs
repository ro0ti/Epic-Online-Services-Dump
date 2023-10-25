using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000127 RID: 295
	// (Invoke) Token: 0x06000942 RID: 2370
	[Token(Token = "0x2000127")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinSessionAcceptedCallbackInternal(ref JoinSessionAcceptedCallbackInfoInternal data);
}
