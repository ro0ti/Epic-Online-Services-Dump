using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001E3 RID: 483
	// (Invoke) Token: 0x06000D79 RID: 3449
	[Token(Token = "0x20001E3")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAudioDevicesChangedCallbackInternal(ref AudioDevicesChangedCallbackInfoInternal data);
}
