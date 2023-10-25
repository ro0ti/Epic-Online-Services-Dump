using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000249 RID: 585
	// (Invoke) Token: 0x0600101F RID: 4127
	[Token(Token = "0x2000249")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryJoinRoomTokenCompleteCallbackInternal(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data);
}
