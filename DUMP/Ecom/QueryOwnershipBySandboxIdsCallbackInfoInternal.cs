using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	internal struct QueryOwnershipBySandboxIdsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipBySandboxIdsCallbackInfo>, ISettable<QueryOwnershipBySandboxIdsCallbackInfo>, IDisposable
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0000980C File Offset: 0x00007A0C
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A86")]
		public Result ResultCode
		{
			[Token(Token = "0x6002451")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002452")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A87")]
		public object ClientData
		{
			[Token(Token = "0x6002453")]
			[Address(RVA = "0x54D340", Offset = "0x54B940", VA = "0x18054D340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002454")]
			[Address(RVA = "0x54D4C0", Offset = "0x54BAC0", VA = "0x18054D4C0")]
			set
			{
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x00009824 File Offset: 0x00007A24
		[Token(Token = "0x17000A88")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002455")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A89")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002456")]
			[Address(RVA = "0x54D3B0", Offset = "0x54B9B0", VA = "0x18054D3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002457")]
			[Address(RVA = "0x54D520", Offset = "0x54BB20", VA = "0x18054D520")]
			set
			{
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8A")]
		public SandboxIdItemOwnership[] SandboxIdItemOwnerships
		{
			[Token(Token = "0x6002458")]
			[Address(RVA = "0x54D430", Offset = "0x54BA30", VA = "0x18054D430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x54D580", Offset = "0x54BB80", VA = "0x18054D580")]
			set
			{
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x54D130", Offset = "0x54B730", VA = "0x18054D130", Slot = "6")]
		public void Set(ref QueryOwnershipBySandboxIdsCallbackInfo other)
		{
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x54D200", Offset = "0x54B800", VA = "0x18054D200", Slot = "7")]
		public void Set(ref QueryOwnershipBySandboxIdsCallbackInfo? other)
		{
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x54D0A0", Offset = "0x54B6A0", VA = "0x18054D0A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x54D110", Offset = "0x54B710", VA = "0x18054D110", Slot = "5")]
		public void Get(out QueryOwnershipBySandboxIdsCallbackInfo output)
		{
		}

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SandboxIdItemOwnerships;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x20")]
		private uint m_SandboxIdItemOwnershipsCount;
	}
}
