using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000BA RID: 186
	// (Invoke) Token: 0x060006C3 RID: 1731
	[Token(Token = "0x20000BA")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnReadFileCompleteCallbackInternal(ref ReadFileCallbackInfoInternal data);
}
