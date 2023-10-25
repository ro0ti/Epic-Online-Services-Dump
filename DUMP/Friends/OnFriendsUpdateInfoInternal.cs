using System;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	internal struct OnFriendsUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnFriendsUpdateInfo>, ISettable<OnFriendsUpdateInfo>, IDisposable
	{
		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700096D")]
		public object ClientData
		{
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x549E20", Offset = "0x548420", VA = "0x180549E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x549F90", Offset = "0x548590", VA = "0x180549F90")]
			set
			{
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x1700096E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600213B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700096F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x549E90", Offset = "0x548490", VA = "0x180549E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600213D")]
			[Address(RVA = "0x549FF0", Offset = "0x5485F0", VA = "0x180549FF0")]
			set
			{
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000970")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600213E")]
			[Address(RVA = "0x549F10", Offset = "0x548510", VA = "0x180549F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600213F")]
			[Address(RVA = "0x54A050", Offset = "0x548650", VA = "0x18054A050")]
			set
			{
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00008DEC File Offset: 0x00006FEC
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000971")]
		public FriendsStatus PreviousStatus
		{
			[Token(Token = "0x6002140")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return FriendsStatus.NotFriends;
			}
			[Token(Token = "0x6002141")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00008E04 File Offset: 0x00007004
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000972")]
		public FriendsStatus CurrentStatus
		{
			[Token(Token = "0x6002142")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return FriendsStatus.NotFriends;
			}
			[Token(Token = "0x6002143")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x549D10", Offset = "0x548310", VA = "0x180549D10", Slot = "6")]
		public void Set(ref OnFriendsUpdateInfo other)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x549B70", Offset = "0x548170", VA = "0x180549B70", Slot = "7")]
		public void Set(ref OnFriendsUpdateInfo? other)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x549AF0", Offset = "0x5480F0", VA = "0x180549AF0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x549B50", Offset = "0x548150", VA = "0x180549B50", Slot = "5")]
		public void Get(out OnFriendsUpdateInfo output)
		{
		}

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x18")]
		private FriendsStatus m_PreviousStatus;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x1C")]
		private FriendsStatus m_CurrentStatus;
	}
}
