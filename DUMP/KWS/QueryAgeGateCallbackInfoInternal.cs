using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	internal struct QueryAgeGateCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryAgeGateCallbackInfo>, ISettable<QueryAgeGateCallbackInfo>, IDisposable
	{
		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0000881C File Offset: 0x00006A1C
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E2")]
		public Result ResultCode
		{
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E3")]
		public object ClientData
		{
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x5323B0", Offset = "0x5309B0", VA = "0x1805323B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F84")]
			[Address(RVA = "0x532490", Offset = "0x530A90", VA = "0x180532490")]
			set
			{
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00008834 File Offset: 0x00006A34
		[Token(Token = "0x170008E4")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001F85")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E5")]
		public Utf8String CountryCode
		{
			[Token(Token = "0x6001F86")]
			[Address(RVA = "0x532420", Offset = "0x530A20", VA = "0x180532420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x5324F0", Offset = "0x530AF0", VA = "0x1805324F0")]
			set
			{
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0000884C File Offset: 0x00006A4C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E6")]
		public uint AgeOfConsent
		{
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0", Slot = "6")]
		public void Set(ref QueryAgeGateCallbackInfo other)
		{
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x532270", Offset = "0x530870", VA = "0x180532270", Slot = "7")]
		public void Set(ref QueryAgeGateCallbackInfo? other)
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x532120", Offset = "0x530720", VA = "0x180532120", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x532180", Offset = "0x530780", VA = "0x180532180", Slot = "5")]
		public void Get(out QueryAgeGateCallbackInfo output)
		{
		}

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_CountryCode;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AgeOfConsent;
	}
}
