using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	internal struct QueryInvitesCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryInvitesCallbackInfo>, ISettable<QueryInvitesCallbackInfo>, IDisposable
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00003A7C File Offset: 0x00001C7C
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000202")]
		public Result ResultCode
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000203")]
		public object ClientData
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x4C28C0", Offset = "0x4C0EC0", VA = "0x1804C28C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x4C29B0", Offset = "0x4C0FB0", VA = "0x1804C29B0")]
			set
			{
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x17000204")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000205")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x4C2930", Offset = "0x4C0F30", VA = "0x1804C2930")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x4C2A10", Offset = "0x4C1010", VA = "0x1804C2A10")]
			set
			{
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x4C2800", Offset = "0x4C0E00", VA = "0x1804C2800", Slot = "6")]
		public void Set(ref QueryInvitesCallbackInfo other)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x4C26E0", Offset = "0x4C0CE0", VA = "0x1804C26E0", Slot = "7")]
		public void Set(ref QueryInvitesCallbackInfo? other)
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x4C2660", Offset = "0x4C0C60", VA = "0x1804C2660", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x4C26C0", Offset = "0x4C0CC0", VA = "0x1804C26C0", Slot = "5")]
		public void Get(out QueryInvitesCallbackInfo output)
		{
		}

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
