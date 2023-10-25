using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	internal struct QueryOwnershipCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipCallbackInfo>, ISettable<QueryOwnershipCallbackInfo>, IDisposable
	{
		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0000986C File Offset: 0x00007A6C
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A93")]
		public Result ResultCode
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A94")]
		public object ClientData
		{
			[Token(Token = "0x6002473")]
			[Address(RVA = "0x54DC60", Offset = "0x54C260", VA = "0x18054DC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x54DDE0", Offset = "0x54C3E0", VA = "0x18054DDE0")]
			set
			{
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x00009884 File Offset: 0x00007A84
		[Token(Token = "0x17000A95")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002475")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A96")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002476")]
			[Address(RVA = "0x54DD60", Offset = "0x54C360", VA = "0x18054DD60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002477")]
			[Address(RVA = "0x54DEC0", Offset = "0x54C4C0", VA = "0x18054DEC0")]
			set
			{
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A97")]
		public ItemOwnership[] ItemOwnership
		{
			[Token(Token = "0x6002478")]
			[Address(RVA = "0x54DCD0", Offset = "0x54C2D0", VA = "0x18054DCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002479")]
			[Address(RVA = "0x54DE40", Offset = "0x54C440", VA = "0x18054DE40")]
			set
			{
			}
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x54DA50", Offset = "0x54C050", VA = "0x18054DA50", Slot = "6")]
		public void Set(ref QueryOwnershipCallbackInfo other)
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x54DB20", Offset = "0x54C120", VA = "0x18054DB20", Slot = "7")]
		public void Set(ref QueryOwnershipCallbackInfo? other)
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x54D9C0", Offset = "0x54BFC0", VA = "0x18054D9C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x54DA30", Offset = "0x54C030", VA = "0x18054DA30", Slot = "5")]
		public void Get(out QueryOwnershipCallbackInfo output)
		{
		}

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ItemOwnership;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ItemOwnershipCount;
	}
}
