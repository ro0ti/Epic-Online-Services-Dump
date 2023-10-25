using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000511 RID: 1297
	// (Invoke) Token: 0x0600212A RID: 8490
	[Token(Token = "0x2000511")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnFriendsUpdateCallbackInternal(ref OnFriendsUpdateInfoInternal data);
}
