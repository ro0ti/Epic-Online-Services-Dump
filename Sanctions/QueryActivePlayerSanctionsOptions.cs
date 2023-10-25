using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public struct QueryActivePlayerSanctionsOptions
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D8")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
