using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	public struct RegisterEventParamDef
	{
		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D80")]
		public Utf8String ParamName
		{
			[Token(Token = "0x6002D56")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002D57")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x0000BB1C File Offset: 0x00009D1C
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D81")]
		public AntiCheatCommonEventParamType ParamType
		{
			[Token(Token = "0x6002D58")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonEventParamType.Invalid;
			}
			[Token(Token = "0x6002D59")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x57E6D0", Offset = "0x57CCD0", VA = "0x18057E6D0")]
		internal void Set(ref RegisterEventParamDefInternal other)
		{
		}
	}
}
