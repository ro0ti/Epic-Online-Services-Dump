using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000634 RID: 1588
	[Token(Token = "0x2000634")]
	internal struct QueryExternalAccountMappingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryExternalAccountMappingsCallbackInfo>, ISettable<QueryExternalAccountMappingsCallbackInfo>, IDisposable
	{
		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x0000A34C File Offset: 0x0000854C
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBA")]
		public Result ResultCode
		{
			[Token(Token = "0x600288C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600288D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBB")]
		public object ClientData
		{
			[Token(Token = "0x600288E")]
			[Address(RVA = "0x564330", Offset = "0x562930", VA = "0x180564330")]
			get
			{
				return null;
			}
			[Token(Token = "0x600288F")]
			[Address(RVA = "0x564420", Offset = "0x562A20", VA = "0x180564420")]
			set
			{
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0000A364 File Offset: 0x00008564
		[Token(Token = "0x17000BBC")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002890")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002891")]
			[Address(RVA = "0x5643A0", Offset = "0x5629A0", VA = "0x1805643A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002892")]
			[Address(RVA = "0x564480", Offset = "0x562A80", VA = "0x180564480")]
			set
			{
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x564270", Offset = "0x562870", VA = "0x180564270", Slot = "6")]
		public void Set(ref QueryExternalAccountMappingsCallbackInfo other)
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x564150", Offset = "0x562750", VA = "0x180564150", Slot = "7")]
		public void Set(ref QueryExternalAccountMappingsCallbackInfo? other)
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x5640D0", Offset = "0x5626D0", VA = "0x1805640D0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x564130", Offset = "0x562730", VA = "0x180564130", Slot = "5")]
		public void Get(out QueryExternalAccountMappingsCallbackInfo output)
		{
		}

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
