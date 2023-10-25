using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.Auth;


namespace Epic.OnlineServices
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class IOSBindings
	{
		// Token: 0x06000356 RID: 854
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x4AA620", Offset = "0x4A8C20", VA = "0x1804AA620")]
		[PreserveSig]
		internal static extern void EOS_Auth_Login(IntPtr handle, ref IOSLoginOptionsInternal options, IntPtr clientData, OnLoginCallbackInternal completionDelegate);
	}
}
