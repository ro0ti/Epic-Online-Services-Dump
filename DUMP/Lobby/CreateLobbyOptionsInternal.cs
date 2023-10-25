using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	internal struct CreateLobbyOptionsInternal : ISettable<CreateLobbyOptions>, IDisposable
	{
		// Token: 0x170006ED RID: 1773
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006ED")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x509CB0", Offset = "0x5082B0", VA = "0x180509CB0")]
			set
			{
			}
		}

		// Token: 0x170006EE RID: 1774
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006EE")]
		public uint MaxLobbyMembers
		{
			[Token(Token = "0x6001909")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x170006EF RID: 1775
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006EF")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x600190A")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F0")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x600190B")]
			[Address(RVA = "0x509D10", Offset = "0x508310", VA = "0x180509D10")]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F1")]
		public bool AllowInvites
		{
			[Token(Token = "0x600190C")]
			[Address(RVA = "0x509920", Offset = "0x507F20", VA = "0x180509920")]
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F2")]
		public Utf8String BucketId
		{
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x509A00", Offset = "0x508000", VA = "0x180509A00")]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F3")]
		public bool DisableHostMigration
		{
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x509AC0", Offset = "0x5080C0", VA = "0x180509AC0")]
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F4")]
		public bool EnableRTCRoom
		{
			[Token(Token = "0x600190F")]
			[Address(RVA = "0x509B80", Offset = "0x508180", VA = "0x180509B80")]
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F5")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x6001910")]
			[Address(RVA = "0x509C40", Offset = "0x508240", VA = "0x180509C40")]
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F6")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001911")]
			[Address(RVA = "0x509BE0", Offset = "0x5081E0", VA = "0x180509BE0")]
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F7")]
		public bool EnableJoinById
		{
			[Token(Token = "0x6001912")]
			[Address(RVA = "0x509B20", Offset = "0x508120", VA = "0x180509B20")]
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F8")]
		public bool RejoinAfterKickRequiresInvite
		{
			[Token(Token = "0x6001913")]
			[Address(RVA = "0x509D70", Offset = "0x508370", VA = "0x180509D70")]
			set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006F9")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6001914")]
			[Address(RVA = "0x509980", Offset = "0x507F80", VA = "0x180509980")]
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006FA")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0x509A60", Offset = "0x508060", VA = "0x180509A60")]
			set
			{
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x5095B0", Offset = "0x507BB0", VA = "0x1805095B0", Slot = "4")]
		public void Set(ref CreateLobbyOptions other)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x509100", Offset = "0x507700", VA = "0x180509100", Slot = "5")]
		public void Set(ref CreateLobbyOptions? other)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x509080", Offset = "0x507680", VA = "0x180509080", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x10")]
		private uint m_MaxLobbyMembers;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x14")]
		private LobbyPermissionLevel m_PermissionLevel;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x18")]
		private int m_PresenceEnabled;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x1C")]
		private int m_AllowInvites;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_BucketId;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x28")]
		private int m_DisableHostMigration;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x2C")]
		private int m_EnableRTCRoom;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_LocalRTCOptions;

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x40")]
		private int m_EnableJoinById;

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x44")]
		private int m_RejoinAfterKickRequiresInvite;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x50")]
		private uint m_AllowedPlatformIdsCount;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x54")]
		private int m_CrossplayOptOut;
	}
}
