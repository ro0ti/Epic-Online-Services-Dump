using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000081 RID: 129
	// (Invoke) Token: 0x0600054D RID: 1357
	[Token(Token = "0x2000081")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnShowFriendsCallbackInternal(ref ShowFriendsCallbackInfoInternal data);
}
