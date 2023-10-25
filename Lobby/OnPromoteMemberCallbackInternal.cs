using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000453 RID: 1107
	// (Invoke) Token: 0x06001CC4 RID: 7364
	[Token(Token = "0x2000453")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPromoteMemberCallbackInternal(ref PromoteMemberCallbackInfoInternal data);
}
