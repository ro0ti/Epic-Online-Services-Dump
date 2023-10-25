using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	internal struct LobbyDetailsInfoInternal : IGettable<LobbyDetailsInfo>, ISettable<LobbyDetailsInfo>, IDisposable
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000792")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A9B")]
			[Address(RVA = "0x512740", Offset = "0x510D40", VA = "0x180512740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A9C")]
			[Address(RVA = "0x512B50", Offset = "0x511150", VA = "0x180512B50")]
			set
			{
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000793")]
		public ProductUserId LobbyOwnerUserId
		{
			[Token(Token = "0x6001A9D")]
			[Address(RVA = "0x5127B0", Offset = "0x510DB0", VA = "0x1805127B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A9E")]
			[Address(RVA = "0x512BB0", Offset = "0x5111B0", VA = "0x180512BB0")]
			set
			{
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0000773C File Offset: 0x0000593C
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000794")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6001A9F")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return LobbyPermissionLevel.Publicadvertised;
			}
			[Token(Token = "0x6001AA0")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x00007754 File Offset: 0x00005954
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000795")]
		public uint AvailableSlots
		{
			[Token(Token = "0x6001AA1")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001AA2")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0000776C File Offset: 0x0000596C
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000796")]
		public uint MaxMembers
		{
			[Token(Token = "0x6001AA3")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001AA4")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x00007784 File Offset: 0x00005984
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000797")]
		public bool AllowInvites
		{
			[Token(Token = "0x6001AA5")]
			[Address(RVA = "0x512580", Offset = "0x510B80", VA = "0x180512580")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AA6")]
			[Address(RVA = "0x5129B0", Offset = "0x510FB0", VA = "0x1805129B0")]
			set
			{
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000798")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6001AA7")]
			[Address(RVA = "0x5126D0", Offset = "0x510CD0", VA = "0x1805126D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AA8")]
			[Address(RVA = "0x512AF0", Offset = "0x5110F0", VA = "0x180512AF0")]
			set
			{
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0000779C File Offset: 0x0000599C
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000799")]
		public bool AllowHostMigration
		{
			[Token(Token = "0x6001AA9")]
			[Address(RVA = "0x512520", Offset = "0x510B20", VA = "0x180512520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AAA")]
			[Address(RVA = "0x512950", Offset = "0x510F50", VA = "0x180512950")]
			set
			{
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x000077B4 File Offset: 0x000059B4
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079A")]
		public bool RTCRoomEnabled
		{
			[Token(Token = "0x6001AAB")]
			[Address(RVA = "0x512890", Offset = "0x510E90", VA = "0x180512890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x512C70", Offset = "0x511270", VA = "0x180512C70")]
			set
			{
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x000077CC File Offset: 0x000059CC
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079B")]
		public bool AllowJoinById
		{
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x5125E0", Offset = "0x510BE0", VA = "0x1805125E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x512A10", Offset = "0x511010", VA = "0x180512A10")]
			set
			{
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x000077E4 File Offset: 0x000059E4
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079C")]
		public bool RejoinAfterKickRequiresInvite
		{
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x5128F0", Offset = "0x510EF0", VA = "0x1805128F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x512CD0", Offset = "0x5112D0", VA = "0x180512CD0")]
			set
			{
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x000077FC File Offset: 0x000059FC
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079D")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x512830", Offset = "0x510E30", VA = "0x180512830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x512C10", Offset = "0x511210", VA = "0x180512C10")]
			set
			{
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079E")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x512640", Offset = "0x510C40", VA = "0x180512640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x512A70", Offset = "0x511070", VA = "0x180512A70")]
			set
			{
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x512260", Offset = "0x510860", VA = "0x180512260", Slot = "5")]
		public void Set(ref LobbyDetailsInfo other)
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x511E70", Offset = "0x510470", VA = "0x180511E70", Slot = "6")]
		public void Set(ref LobbyDetailsInfo? other)
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x511DC0", Offset = "0x5103C0", VA = "0x180511DC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x511E40", Offset = "0x510440", VA = "0x180511E40", Slot = "4")]
		public void Get(out LobbyDetailsInfo output)
		{
		}

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyOwnerUserId;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x18")]
		private LobbyPermissionLevel m_PermissionLevel;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_AvailableSlots;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x20")]
		private uint m_MaxMembers;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x24")]
		private int m_AllowInvites;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_BucketId;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x30")]
		private int m_AllowHostMigration;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x34")]
		private int m_RTCRoomEnabled;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x38")]
		private int m_AllowJoinById;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x3C")]
		private int m_RejoinAfterKickRequiresInvite;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x40")]
		private int m_PresenceEnabled;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x50")]
		private uint m_AllowedPlatformIdsCount;
	}
}
