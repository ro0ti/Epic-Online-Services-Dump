using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001E7 RID: 487
	// (Invoke) Token: 0x06000D89 RID: 3465
	[Token(Token = "0x20001E7")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAudioOutputStateCallbackInternal(ref AudioOutputStateCallbackInfoInternal data);
}
