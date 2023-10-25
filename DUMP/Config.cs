using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public static class Config
	{
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		public const string LibraryName = "EOSSDK-Win64-Shipping";

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		public const CallingConvention LibraryCallingConvention = CallingConvention.Cdecl;
	}
}
