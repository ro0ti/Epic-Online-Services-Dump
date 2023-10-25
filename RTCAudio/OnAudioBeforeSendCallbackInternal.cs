using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001E1 RID: 481
	// (Invoke) Token: 0x06000D71 RID: 3441
	[Token(Token = "0x20001E1")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAudioBeforeSendCallbackInternal(ref AudioBeforeSendCallbackInfoInternal data);
}
