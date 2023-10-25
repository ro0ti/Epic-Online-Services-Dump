using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000275 RID: 629
	// (Invoke) Token: 0x06001165 RID: 4453
	[Token(Token = "0x2000275")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnParticipantStatusChangedCallbackInternal(ref ParticipantStatusChangedCallbackInfoInternal data);
}
