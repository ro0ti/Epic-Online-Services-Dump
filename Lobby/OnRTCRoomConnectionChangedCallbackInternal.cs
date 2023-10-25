using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000459 RID: 1113
	// (Invoke) Token: 0x06001CDC RID: 7388
	[Token(Token = "0x2000459")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRTCRoomConnectionChangedCallbackInternal(ref RTCRoomConnectionChangedCallbackInfoInternal data);
}
