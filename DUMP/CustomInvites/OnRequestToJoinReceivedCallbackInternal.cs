using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C6 RID: 1478
	// (Invoke) Token: 0x060025ED RID: 9709
	[Token(Token = "0x20005C6")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRequestToJoinReceivedCallbackInternal(ref RequestToJoinReceivedCallbackInfoInternal data);
}
