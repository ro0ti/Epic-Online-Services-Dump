using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200024B RID: 587
	// (Invoke) Token: 0x06001027 RID: 4135
	[Token(Token = "0x200024B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSetParticipantHardMuteCompleteCallbackInternal(ref SetParticipantHardMuteCompleteCallbackInfoInternal data);
}
