using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000BC RID: 188
	// (Invoke) Token: 0x060006CB RID: 1739
	[Token(Token = "0x20000BC")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate ReadResult OnReadFileDataCallbackInternal(ref ReadFileDataCallbackInfoInternal data);
}
