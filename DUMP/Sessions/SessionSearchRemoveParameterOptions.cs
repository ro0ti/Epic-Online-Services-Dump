using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public struct SessionSearchRemoveParameterOptions
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000294")]
		public Utf8String Key
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0000416C File Offset: 0x0000236C
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000295")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ComparisonOp.Equal;
			}
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
