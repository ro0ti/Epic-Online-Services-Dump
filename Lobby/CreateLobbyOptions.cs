using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	public struct CreateLobbyOptions
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006DF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60018EC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018ED")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000070AC File Offset: 0x000052AC
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E0")]
		public uint MaxLobbyMembers
		{
			[Token(Token = "0x60018EE")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60018EF")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000070C4 File Offset: 0x000052C4
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E1")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x60018F0")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyPermissionLevel.Publicadvertised;
			}
			[Token(Token = "0x60018F1")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000070DC File Offset: 0x000052DC
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E2")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x60018F2")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E3")]
		public bool AllowInvites
		{
			[Token(Token = "0x60018F4")]
			[Address(RVA = "0x509DD0", Offset = "0x5083D0", VA = "0x180509DD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x509E30", Offset = "0x508430", VA = "0x180509E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E4")]
		public Utf8String BucketId
		{
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0000710C File Offset: 0x0000530C
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E5")]
		public bool DisableHostMigration
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00007124 File Offset: 0x00005324
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E6")]
		public bool EnableRTCRoom
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x509DF0", Offset = "0x5083F0", VA = "0x180509DF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x509E50", Offset = "0x508450", VA = "0x180509E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0000713C File Offset: 0x0000533C
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E7")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x509E00", Offset = "0x508400", VA = "0x180509E00")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018FD")]
			[Address(RVA = "0x509E60", Offset = "0x508460", VA = "0x180509E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E8")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60018FE")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018FF")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00007154 File Offset: 0x00005354
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006E9")]
		public bool EnableJoinById
		{
			[Token(Token = "0x6001900")]
			[Address(RVA = "0x3D4580", Offset = "0x3D2B80", VA = "0x1803D4580")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x475030", Offset = "0x473630", VA = "0x180475030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0000716C File Offset: 0x0000536C
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006EA")]
		public bool RejoinAfterKickRequiresInvite
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x509E20", Offset = "0x508420", VA = "0x180509E20")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x509E70", Offset = "0x508470", VA = "0x180509E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006EB")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6001904")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001905")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00007184 File Offset: 0x00005384
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006EC")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x509DE0", Offset = "0x5083E0", VA = "0x180509DE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x509E40", Offset = "0x508440", VA = "0x180509E40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
