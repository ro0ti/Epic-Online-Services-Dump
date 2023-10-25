using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005CC RID: 1484
	// (Invoke) Token: 0x06002610 RID: 9744
	[Token(Token = "0x20005CC")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRequestToJoinResponseReceivedCallbackInternal(ref RequestToJoinResponseReceivedCallbackInfoInternal data);
}
