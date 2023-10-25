using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000B6 RID: 182
	// (Invoke) Token: 0x060006B3 RID: 1715
	[Token(Token = "0x20000B6")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryFileCompleteCallbackInternal(ref QueryFileCallbackInfoInternal data);
}
