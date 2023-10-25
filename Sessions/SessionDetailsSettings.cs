using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public struct SessionDetailsSettings
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024A")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00003D64 File Offset: 0x00001F64
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024B")]
		public uint NumPublicConnections
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00003D7C File Offset: 0x00001F7C
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024C")]
		public bool AllowJoinInProgress
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x4C8A90", Offset = "0x4C7090", VA = "0x1804C8A90")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x4C8AB0", Offset = "0x4C70B0", VA = "0x1804C8AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00003D94 File Offset: 0x00001F94
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024D")]
		public OnlineSessionPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return OnlineSessionPermissionLevel.PublicAdvertised;
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00003DAC File Offset: 0x00001FAC
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024E")]
		public bool InvitesAllowed
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x40E220", Offset = "0x40C820", VA = "0x18040E220")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x4C8AC0", Offset = "0x4C70C0", VA = "0x1804C8AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00003DC4 File Offset: 0x00001FC4
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700024F")]
		public bool SanctionsEnabled
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x4C8AA0", Offset = "0x4C70A0", VA = "0x1804C8AA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x4C8AD0", Offset = "0x4C70D0", VA = "0x1804C8AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000250")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x4C88F0", Offset = "0x4C6EF0", VA = "0x1804C88F0")]
		internal void Set(ref SessionDetailsSettingsInternal other)
		{
		}
	}
}
