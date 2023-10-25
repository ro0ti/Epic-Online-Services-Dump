using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	public struct CopyEntitlementByIdOptions
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009EB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009EC")]
		public Utf8String EntitlementId
		{
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
