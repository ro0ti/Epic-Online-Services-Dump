using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C2 RID: 1474
	// (Invoke) Token: 0x060025D2 RID: 9682
	[Token(Token = "0x20005C2")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRequestToJoinAcceptedCallbackInternal(ref OnRequestToJoinAcceptedCallbackInfoInternal data);
}
