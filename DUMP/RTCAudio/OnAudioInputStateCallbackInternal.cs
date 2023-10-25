using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001E5 RID: 485
	// (Invoke) Token: 0x06000D81 RID: 3457
	[Token(Token = "0x20001E5")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAudioInputStateCallbackInternal(ref AudioInputStateCallbackInfoInternal data);
}
