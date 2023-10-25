using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002F7 RID: 759
	// (Invoke) Token: 0x0600147C RID: 5244
	[Token(Token = "0x20002F7")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnReadFileCompleteCallbackInternal(ref ReadFileCallbackInfoInternal data);
}
