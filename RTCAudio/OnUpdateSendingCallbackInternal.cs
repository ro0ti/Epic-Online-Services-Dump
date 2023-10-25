using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000209 RID: 521
	// (Invoke) Token: 0x06000E4B RID: 3659
	[Token(Token = "0x2000209")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateSendingCallbackInternal(ref UpdateSendingCallbackInfoInternal data);
}
