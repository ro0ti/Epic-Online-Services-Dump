using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001DF RID: 479
	// (Invoke) Token: 0x06000D69 RID: 3433
	[Token(Token = "0x20001DF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAudioBeforeRenderCallbackInternal(ref AudioBeforeRenderCallbackInfoInternal data);
}
