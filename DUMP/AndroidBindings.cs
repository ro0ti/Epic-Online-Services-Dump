using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.Platform;
using Il2CppDummyDll;

namespace Epic.OnlineServices
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public static class AndroidBindings
	{
		// Token: 0x060000DB RID: 219
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x487790", Offset = "0x485D90", VA = "0x180487790")]
		[PreserveSig]
		internal static extern Result EOS_Initialize(ref AndroidInitializeOptionsInternal options);
	}
}
