using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000722 RID: 1826
	// (Invoke) Token: 0x06002EB8 RID: 11960
	[Token(Token = "0x2000722")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr AllocateMemoryFunc(UIntPtr sizeInBytes, UIntPtr alignment);
}
