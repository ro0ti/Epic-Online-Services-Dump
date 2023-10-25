using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Reports
{
	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	public struct SendPlayerBehaviorReportOptions
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004AF")]
		public ProductUserId ReporterUserId
		{
			[Token(Token = "0x600120B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600120C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B0")]
		public ProductUserId ReportedUserId
		{
			[Token(Token = "0x600120D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600120E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000056E4 File Offset: 0x000038E4
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B1")]
		public PlayerReportsCategory Category
		{
			[Token(Token = "0x600120F")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return PlayerReportsCategory.Invalid;
			}
			[Token(Token = "0x6001210")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B2")]
		public Utf8String Message
		{
			[Token(Token = "0x6001211")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001212")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B3")]
		public Utf8String Context
		{
			[Token(Token = "0x6001213")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001214")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
