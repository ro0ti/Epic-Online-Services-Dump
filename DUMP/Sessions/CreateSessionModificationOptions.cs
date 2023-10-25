using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	public struct CreateSessionModificationOptions
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B8")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B9")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0000380C File Offset: 0x00001A0C
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BA")]
		public uint MaxPlayers
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BC")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BD")]
		public Utf8String SessionId
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BE")]
		public bool SanctionsEnabled
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x4BBE80", Offset = "0x4BA480", VA = "0x1804BBE80")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x4BBEB0", Offset = "0x4BA4B0", VA = "0x1804BBEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BF")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
