using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	internal struct LobbyUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyUpdateReceivedCallbackInfo>, ISettable<LobbyUpdateReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000803")]
		public object ClientData
		{
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x52CFA0", Offset = "0x52B5A0", VA = "0x18052CFA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x52D080", Offset = "0x52B680", VA = "0x18052D080")]
			set
			{
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00007EA4 File Offset: 0x000060A4
		[Token(Token = "0x17000804")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000805")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x52D010", Offset = "0x52B610", VA = "0x18052D010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x52D0E0", Offset = "0x52B6E0", VA = "0x18052D0E0")]
			set
			{
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x52CDF0", Offset = "0x52B3F0", VA = "0x18052CDF0", Slot = "6")]
		public void Set(ref LobbyUpdateReceivedCallbackInfo other)
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x52CEA0", Offset = "0x52B4A0", VA = "0x18052CEA0", Slot = "7")]
		public void Set(ref LobbyUpdateReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x52CD70", Offset = "0x52B370", VA = "0x18052CD70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x52CDD0", Offset = "0x52B3D0", VA = "0x18052CDD0", Slot = "5")]
		public void Get(out LobbyUpdateReceivedCallbackInfo output)
		{
		}

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;
	}
}
