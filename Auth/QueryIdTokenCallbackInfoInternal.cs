using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000680 RID: 1664
	[Token(Token = "0x2000680")]
	internal struct QueryIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryIdTokenCallbackInfo>, ISettable<QueryIdTokenCallbackInfo>, IDisposable
	{
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0000AA3C File Offset: 0x00008C3C
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C63")]
		public Result ResultCode
		{
			[Token(Token = "0x6002A95")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C64")]
		public object ClientData
		{
			[Token(Token = "0x6002A97")]
			[Address(RVA = "0x57CD40", Offset = "0x57B340", VA = "0x18057CD40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0x57CEB0", Offset = "0x57B4B0", VA = "0x18057CEB0")]
			set
			{
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0000AA54 File Offset: 0x00008C54
		[Token(Token = "0x17000C65")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002A99")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C66")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A9A")]
			[Address(RVA = "0x57CDB0", Offset = "0x57B3B0", VA = "0x18057CDB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A9B")]
			[Address(RVA = "0x57CF10", Offset = "0x57B510", VA = "0x18057CF10")]
			set
			{
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C67")]
		public EpicAccountId TargetAccountId
		{
			[Token(Token = "0x6002A9C")]
			[Address(RVA = "0x57CE30", Offset = "0x57B430", VA = "0x18057CE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A9D")]
			[Address(RVA = "0x57CF70", Offset = "0x57B570", VA = "0x18057CF70")]
			set
			{
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x57CAC0", Offset = "0x57B0C0", VA = "0x18057CAC0", Slot = "6")]
		public void Set(ref QueryIdTokenCallbackInfo other)
		{
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x57CBC0", Offset = "0x57B1C0", VA = "0x18057CBC0", Slot = "7")]
		public void Set(ref QueryIdTokenCallbackInfo? other)
		{
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x57CA30", Offset = "0x57B030", VA = "0x18057CA30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x57CAA0", Offset = "0x57B0A0", VA = "0x18057CAA0", Slot = "5")]
		public void Get(out QueryIdTokenCallbackInfo output)
		{
		}

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetAccountId;
	}
}
