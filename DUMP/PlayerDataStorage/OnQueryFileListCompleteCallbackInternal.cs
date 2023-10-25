using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002F5 RID: 757
	// (Invoke) Token: 0x06001474 RID: 5236
	[Token(Token = "0x20002F5")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryFileListCompleteCallbackInternal(ref QueryFileListCallbackInfoInternal data);
}
