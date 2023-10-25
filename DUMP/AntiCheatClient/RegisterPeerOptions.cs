using System;
using System.Runtime.CompilerServices;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	public struct RegisterPeerOptions
	{
		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x0000BF24 File Offset: 0x0000A124
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB2")]
		public IntPtr PeerHandle
		{
			[Token(Token = "0x6002E31")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002E32")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x0000BF3C File Offset: 0x0000A13C
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB3")]
		public AntiCheatCommonClientType ClientType
		{
			[Token(Token = "0x6002E33")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientType.ProtectedClient;
			}
			[Token(Token = "0x6002E34")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0000BF54 File Offset: 0x0000A154
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB4")]
		public AntiCheatCommonClientPlatform ClientPlatform
		{
			[Token(Token = "0x6002E35")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientPlatform.Unknown;
			}
			[Token(Token = "0x6002E36")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x0000BF6C File Offset: 0x0000A16C
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB5")]
		public uint AuthenticationTimeout
		{
			[Token(Token = "0x6002E37")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002E38")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB6")]
		public Utf8String AccountId_DEPRECATED
		{
			[Token(Token = "0x6002E39")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002E3A")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB7")]
		public Utf8String IpAddress
		{
			[Token(Token = "0x6002E3B")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002E3C")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB8")]
		public ProductUserId PeerProductUserId
		{
			[Token(Token = "0x6002E3D")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002E3E")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
