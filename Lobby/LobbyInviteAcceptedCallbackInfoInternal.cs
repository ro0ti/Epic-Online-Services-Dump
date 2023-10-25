using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	internal struct LobbyInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteAcceptedCallbackInfo>, ISettable<LobbyInviteAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007AA")]
		public object ClientData
		{
			[Token(Token = "0x6001B1A")]
			[Address(RVA = "0x527B80", Offset = "0x526180", VA = "0x180527B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1B")]
			[Address(RVA = "0x527DD0", Offset = "0x5263D0", VA = "0x180527DD0")]
			set
			{
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x00007A84 File Offset: 0x00005C84
		[Token(Token = "0x170007AB")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001B1C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007AC")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B1D")]
			[Address(RVA = "0x527BF0", Offset = "0x5261F0", VA = "0x180527BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1E")]
			[Address(RVA = "0x527E30", Offset = "0x526430", VA = "0x180527E30")]
			set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007AD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B1F")]
			[Address(RVA = "0x527CD0", Offset = "0x5262D0", VA = "0x180527CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B20")]
			[Address(RVA = "0x527EF0", Offset = "0x5264F0", VA = "0x180527EF0")]
			set
			{
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007AE")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B21")]
			[Address(RVA = "0x527D50", Offset = "0x526350", VA = "0x180527D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B22")]
			[Address(RVA = "0x527F50", Offset = "0x526550", VA = "0x180527F50")]
			set
			{
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007AF")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B23")]
			[Address(RVA = "0x527C60", Offset = "0x526260", VA = "0x180527C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B24")]
			[Address(RVA = "0x527E90", Offset = "0x526490", VA = "0x180527E90")]
			set
			{
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x5277F0", Offset = "0x525DF0", VA = "0x1805277F0", Slot = "6")]
		public void Set(ref LobbyInviteAcceptedCallbackInfo other)
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x527970", Offset = "0x525F70", VA = "0x180527970", Slot = "7")]
		public void Set(ref LobbyInviteAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x527740", Offset = "0x525D40", VA = "0x180527740", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x5277C0", Offset = "0x525DC0", VA = "0x1805277C0", Slot = "5")]
		public void Get(out LobbyInviteAcceptedCallbackInfo output)
		{
		}

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_LobbyId;
	}
}
