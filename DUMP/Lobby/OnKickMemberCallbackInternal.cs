using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000441 RID: 1089
	// (Invoke) Token: 0x06001C7C RID: 7292
	[Token(Token = "0x2000441")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnKickMemberCallbackInternal(ref KickMemberCallbackInfoInternal data);
}
