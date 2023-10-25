using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	internal struct LobbyInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteReceivedCallbackInfo>, ISettable<LobbyInviteReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B4")]
		public object ClientData
		{
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x5284B0", Offset = "0x526AB0", VA = "0x1805284B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x528690", Offset = "0x526C90", VA = "0x180528690")]
			set
			{
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[Token(Token = "0x170007B5")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B6")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x528520", Offset = "0x526B20", VA = "0x180528520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x5286F0", Offset = "0x526CF0", VA = "0x1805286F0")]
			set
			{
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x528590", Offset = "0x526B90", VA = "0x180528590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x528750", Offset = "0x526D50", VA = "0x180528750")]
			set
			{
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B8")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x528610", Offset = "0x526C10", VA = "0x180528610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x5287B0", Offset = "0x526DB0", VA = "0x1805287B0")]
			set
			{
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x528370", Offset = "0x526970", VA = "0x180528370", Slot = "6")]
		public void Set(ref LobbyInviteReceivedCallbackInfo other)
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x5281C0", Offset = "0x5267C0", VA = "0x1805281C0", Slot = "7")]
		public void Set(ref LobbyInviteReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x528130", Offset = "0x526730", VA = "0x180528130", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x5281A0", Offset = "0x5267A0", VA = "0x1805281A0", Slot = "5")]
		public void Get(out LobbyInviteReceivedCallbackInfo output)
		{
		}

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
