using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057C RID: 1404
	[Token(Token = "0x200057C")]
	internal struct QueryEntitlementTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryEntitlementTokenCallbackInfo>, ISettable<QueryEntitlementTokenCallbackInfo>, IDisposable
	{
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0000974C File Offset: 0x0000794C
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6E")]
		public Result ResultCode
		{
			[Token(Token = "0x6002415")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002416")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6F")]
		public object ClientData
		{
			[Token(Token = "0x6002417")]
			[Address(RVA = "0x54B2A0", Offset = "0x5498A0", VA = "0x18054B2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002418")]
			[Address(RVA = "0x54B400", Offset = "0x549A00", VA = "0x18054B400")]
			set
			{
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x00009764 File Offset: 0x00007964
		[Token(Token = "0x17000A70")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002419")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A71")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600241A")]
			[Address(RVA = "0x54B380", Offset = "0x549980", VA = "0x18054B380")]
			get
			{
				return null;
			}
			[Token(Token = "0x600241B")]
			[Address(RVA = "0x54B4C0", Offset = "0x549AC0", VA = "0x18054B4C0")]
			set
			{
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A72")]
		public Utf8String EntitlementToken
		{
			[Token(Token = "0x600241C")]
			[Address(RVA = "0x54B310", Offset = "0x549910", VA = "0x18054B310")]
			get
			{
				return null;
			}
			[Token(Token = "0x600241D")]
			[Address(RVA = "0x54B460", Offset = "0x549A60", VA = "0x18054B460")]
			set
			{
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x54B020", Offset = "0x549620", VA = "0x18054B020", Slot = "6")]
		public void Set(ref QueryEntitlementTokenCallbackInfo other)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x54B120", Offset = "0x549720", VA = "0x18054B120", Slot = "7")]
		public void Set(ref QueryEntitlementTokenCallbackInfo? other)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x54AF90", Offset = "0x549590", VA = "0x18054AF90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x54B000", Offset = "0x549600", VA = "0x18054B000", Slot = "5")]
		public void Get(out QueryEntitlementTokenCallbackInfo output)
		{
		}

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_EntitlementToken;
	}
}
