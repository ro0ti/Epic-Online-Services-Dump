using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000079 RID: 121
	// (Invoke) Token: 0x0600051E RID: 1310
	[Token(Token = "0x2000079")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnHideFriendsCallbackInternal(ref HideFriendsCallbackInfoInternal data);
}
