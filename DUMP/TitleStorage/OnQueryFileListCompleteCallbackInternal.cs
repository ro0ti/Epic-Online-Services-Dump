using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000B8 RID: 184
	// (Invoke) Token: 0x060006BB RID: 1723
	[Token(Token = "0x20000B8")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryFileListCompleteCallbackInternal(ref QueryFileListCallbackInfoInternal data);
}
