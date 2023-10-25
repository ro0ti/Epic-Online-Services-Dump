using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	public struct LobbyDetailsInfo
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000785")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A80")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A81")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000786")]
		public ProductUserId LobbyOwnerUserId
		{
			[Token(Token = "0x6001A82")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A83")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00007664 File Offset: 0x00005864
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000787")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6001A84")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyPermissionLevel.Publicadvertised;
			}
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0000767C File Offset: 0x0000587C
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000788")]
		public uint AvailableSlots
		{
			[Token(Token = "0x6001A86")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001A87")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00007694 File Offset: 0x00005894
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000789")]
		public uint MaxMembers
		{
			[Token(Token = "0x6001A88")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001A89")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x000076AC File Offset: 0x000058AC
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078A")]
		public bool AllowInvites
		{
			[Token(Token = "0x6001A8A")]
			[Address(RVA = "0x4C45B0", Offset = "0x4C2BB0", VA = "0x1804C45B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x4C45E0", Offset = "0x4C2BE0", VA = "0x1804C45E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078B")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6001A8C")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A8D")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x000076C4 File Offset: 0x000058C4
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078C")]
		public bool AllowHostMigration
		{
			[Token(Token = "0x6001A8E")]
			[Address(RVA = "0x481820", Offset = "0x47FE20", VA = "0x180481820")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A8F")]
			[Address(RVA = "0x4818D0", Offset = "0x47FED0", VA = "0x1804818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x000076DC File Offset: 0x000058DC
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078D")]
		public bool RTCRoomEnabled
		{
			[Token(Token = "0x6001A90")]
			[Address(RVA = "0x4818A0", Offset = "0x47FEA0", VA = "0x1804818A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A91")]
			[Address(RVA = "0x513050", Offset = "0x511650", VA = "0x180513050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x000076F4 File Offset: 0x000058F4
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078E")]
		public bool AllowJoinById
		{
			[Token(Token = "0x6001A92")]
			[Address(RVA = "0x4818B0", Offset = "0x47FEB0", VA = "0x1804818B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A93")]
			[Address(RVA = "0x513040", Offset = "0x511640", VA = "0x180513040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0000770C File Offset: 0x0000590C
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700078F")]
		public bool RejoinAfterKickRequiresInvite
		{
			[Token(Token = "0x6001A94")]
			[Address(RVA = "0x513030", Offset = "0x511630", VA = "0x180513030")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A95")]
			[Address(RVA = "0x513060", Offset = "0x511660", VA = "0x180513060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x00007724 File Offset: 0x00005924
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000790")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6001A96")]
			[Address(RVA = "0x4F5200", Offset = "0x4F3800", VA = "0x1804F5200")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A97")]
			[Address(RVA = "0x4F5220", Offset = "0x4F3820", VA = "0x1804F5220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000791")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6001A98")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x512D30", Offset = "0x511330", VA = "0x180512D30")]
		internal void Set(ref LobbyDetailsInfoInternal other)
		{
		}
	}
}
