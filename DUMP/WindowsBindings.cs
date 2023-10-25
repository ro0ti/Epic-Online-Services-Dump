using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.Platform;


namespace Epic.OnlineServices
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public static class WindowsBindings
	{
		// Token: 0x0600037E RID: 894
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x4B8370", Offset = "0x4B6970", VA = "0x1804B8370")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_Create(ref WindowsOptionsInternal options);
	}
}
