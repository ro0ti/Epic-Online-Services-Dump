using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberStatusReceivedCallbackInfo>, ISettable<LobbyMemberStatusReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C8")]
		public object ClientData
		{
			[Token(Token = "0x6001B65")]
			[Address(RVA = "0x529620", Offset = "0x527C20", VA = "0x180529620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B66")]
			[Address(RVA = "0x529780", Offset = "0x527D80", VA = "0x180529780")]
			set
			{
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x170007C9")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001B67")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CA")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B68")]
			[Address(RVA = "0x529690", Offset = "0x527C90", VA = "0x180529690")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B69")]
			[Address(RVA = "0x5297E0", Offset = "0x527DE0", VA = "0x1805297E0")]
			set
			{
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CB")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0x529700", Offset = "0x527D00", VA = "0x180529700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x529840", Offset = "0x527E40", VA = "0x180529840")]
			set
			{
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CC")]
		public LobbyMemberStatus CurrentStatus
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return LobbyMemberStatus.Joined;
			}
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x5293A0", Offset = "0x5279A0", VA = "0x1805293A0", Slot = "6")]
		public void Set(ref LobbyMemberStatusReceivedCallbackInfo other)
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x5294A0", Offset = "0x527AA0", VA = "0x1805294A0", Slot = "7")]
		public void Set(ref LobbyMemberStatusReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x529320", Offset = "0x527920", VA = "0x180529320", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x529380", Offset = "0x527980", VA = "0x180529380", Slot = "5")]
		public void Get(out LobbyMemberStatusReceivedCallbackInfo output)
		{
		}

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x18")]
		private LobbyMemberStatus m_CurrentStatus;
	}
}
