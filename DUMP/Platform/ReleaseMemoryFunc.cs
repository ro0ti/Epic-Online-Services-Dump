using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000734 RID: 1844
	// (Invoke) Token: 0x06002F45 RID: 12101
	[Token(Token = "0x2000734")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ReleaseMemoryFunc(IntPtr pointer);
}
