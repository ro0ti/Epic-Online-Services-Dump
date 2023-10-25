using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000733 RID: 1843
	// (Invoke) Token: 0x06002F41 RID: 12097
	[Token(Token = "0x2000733")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr ReallocateMemoryFunc(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment);
}
