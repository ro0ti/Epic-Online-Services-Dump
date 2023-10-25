using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Reports
{
	// Token: 0x02000287 RID: 647
	// (Invoke) Token: 0x060011F5 RID: 4597
	[Token(Token = "0x2000287")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendPlayerBehaviorReportCompleteCallbackInternal(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data);
}
