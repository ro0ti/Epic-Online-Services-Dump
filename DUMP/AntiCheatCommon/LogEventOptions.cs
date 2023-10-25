using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C0 RID: 1728
	[Token(Token = "0x20006C0")]
	public struct LogEventOptions
	{
		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0000B144 File Offset: 0x00009344
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE2")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BFC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BFD")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x0000B15C File Offset: 0x0000935C
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE3")]
		public uint EventId
		{
			[Token(Token = "0x6002BFE")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002BFF")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE4")]
		public LogEventParamPair[] Params
		{
			[Token(Token = "0x6002C00")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002C01")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
