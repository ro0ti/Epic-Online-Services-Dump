using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	internal struct QueryInvitesCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryInvitesCallbackInfo>, ISettable<QueryInvitesCallbackInfo>, IDisposable
	{
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0000800C File Offset: 0x0000620C
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000820")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000821")]
		public object ClientData
		{
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x532940", Offset = "0x530F40", VA = "0x180532940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D27")]
			[Address(RVA = "0x532A30", Offset = "0x531030", VA = "0x180532A30")]
			set
			{
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00008024 File Offset: 0x00006224
		[Token(Token = "0x17000822")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D28")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000823")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D29")]
			[Address(RVA = "0x5329B0", Offset = "0x530FB0", VA = "0x1805329B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D2A")]
			[Address(RVA = "0x532A90", Offset = "0x531090", VA = "0x180532A90")]
			set
			{
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760", Slot = "6")]
		public void Set(ref QueryInvitesCallbackInfo other)
		{
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x532820", Offset = "0x530E20", VA = "0x180532820", Slot = "7")]
		public void Set(ref QueryInvitesCallbackInfo? other)
		{
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x5326E0", Offset = "0x530CE0", VA = "0x1805326E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x532740", Offset = "0x530D40", VA = "0x180532740", Slot = "5")]
		public void Get(out QueryInvitesCallbackInfo output)
		{
		}

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
