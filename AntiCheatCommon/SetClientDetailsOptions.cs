using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	public struct SetClientDetailsOptions
	{
		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x0000BB4C File Offset: 0x00009D4C
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D84")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D63")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002D64")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x0000BB64 File Offset: 0x00009D64
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D85")]
		public AntiCheatCommonClientFlags ClientFlags
		{
			[Token(Token = "0x6002D65")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientFlags.None;
			}
			[Token(Token = "0x6002D66")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x0000BB7C File Offset: 0x00009D7C
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D86")]
		public AntiCheatCommonClientInput ClientInputMethod
		{
			[Token(Token = "0x6002D67")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientInput.Unknown;
			}
			[Token(Token = "0x6002D68")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
