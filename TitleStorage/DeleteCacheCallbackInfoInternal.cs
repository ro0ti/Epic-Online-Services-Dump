using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	internal struct DeleteCacheCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteCacheCallbackInfo>, ISettable<DeleteCacheCallbackInfo>, IDisposable
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010E")]
		public Result ResultCode
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010F")]
		public object ClientData
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x4A1A00", Offset = "0x4A0000", VA = "0x1804A1A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x4A1B20", Offset = "0x4A0120", VA = "0x1804A1B20")]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x17000110")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000111")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x4A1AA0", Offset = "0x4A00A0", VA = "0x1804A1AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x4A1BC0", Offset = "0x4A01C0", VA = "0x1804A1BC0")]
			set
			{
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4A19C0", Offset = "0x49FFC0", VA = "0x1804A19C0", Slot = "6")]
		public void Set(ref DeleteCacheCallbackInfo other)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x4A1910", Offset = "0x49FF10", VA = "0x1804A1910", Slot = "7")]
		public void Set(ref DeleteCacheCallbackInfo? other)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x4A17D0", Offset = "0x49FDD0", VA = "0x1804A17D0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x4A18B0", Offset = "0x49FEB0", VA = "0x1804A18B0", Slot = "5")]
		public void Get(out DeleteCacheCallbackInfo output)
		{
		}

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
