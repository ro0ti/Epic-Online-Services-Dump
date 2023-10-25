using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C0 RID: 1472
	// (Invoke) Token: 0x060025CA RID: 9674
	[Token(Token = "0x20005C0")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRejectRequestToJoinCallbackInternal(ref RejectRequestToJoinCallbackInfoInternal data);
}
