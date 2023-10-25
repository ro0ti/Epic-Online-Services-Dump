using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	internal struct QueryOffersCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOffersCallbackInfo>, ISettable<QueryOffersCallbackInfo>, IDisposable
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000097AC File Offset: 0x000079AC
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A7A")]
		public Result ResultCode
		{
			[Token(Token = "0x6002433")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002434")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A7B")]
		public object ClientData
		{
			[Token(Token = "0x6002435")]
			[Address(RVA = "0x54CB00", Offset = "0x54B100", VA = "0x18054CB00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002436")]
			[Address(RVA = "0x54CBF0", Offset = "0x54B1F0", VA = "0x18054CBF0")]
			set
			{
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x000097C4 File Offset: 0x000079C4
		[Token(Token = "0x17000A7C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002437")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A7D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002438")]
			[Address(RVA = "0x54CB70", Offset = "0x54B170", VA = "0x18054CB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002439")]
			[Address(RVA = "0x54CC50", Offset = "0x54B250", VA = "0x18054CC50")]
			set
			{
			}
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x54CA40", Offset = "0x54B040", VA = "0x18054CA40", Slot = "6")]
		public void Set(ref QueryOffersCallbackInfo other)
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x54C920", Offset = "0x54AF20", VA = "0x18054C920", Slot = "7")]
		public void Set(ref QueryOffersCallbackInfo? other)
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x54C8A0", Offset = "0x54AEA0", VA = "0x18054C8A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x54C900", Offset = "0x54AF00", VA = "0x18054C900", Slot = "5")]
		public void Get(out QueryOffersCallbackInfo output)
		{
		}

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
