using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200026D RID: 621
	// (Invoke) Token: 0x06001145 RID: 4421
	[Token(Token = "0x200026D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnBlockParticipantCallbackInternal(ref BlockParticipantCallbackInfoInternal data);
}
