using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Logging
{
	// Token: 0x02000392 RID: 914
	// (Invoke) Token: 0x06001867 RID: 6247
	[Token(Token = "0x2000392")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void LogMessageFuncInternal(ref LogMessageInternal message);
}
