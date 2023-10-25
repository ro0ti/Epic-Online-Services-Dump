using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002F9 RID: 761
	// (Invoke) Token: 0x06001484 RID: 5252
	[Token(Token = "0x20002F9")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate ReadResult OnReadFileDataCallbackInternal(ref ReadFileDataCallbackInfoInternal data);
}
