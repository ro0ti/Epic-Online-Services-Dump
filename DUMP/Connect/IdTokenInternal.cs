using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable
	{
		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B94")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x55BC40", Offset = "0x55A240", VA = "0x18055BC40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x55BDE0", Offset = "0x55A3E0", VA = "0x18055BDE0")]
			set
			{
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027CC RID: 10188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B95")]
		public Utf8String JsonWebToken
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x55BBD0", Offset = "0x55A1D0", VA = "0x18055BBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x55BD20", Offset = "0x55A320", VA = "0x18055BD20")]
			set
			{
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x55BA20", Offset = "0x55A020", VA = "0x18055BA20", Slot = "5")]
		public void Set(ref IdToken other)
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x55B850", Offset = "0x559E50", VA = "0x18055B850", Slot = "6")]
		public void Set(ref IdToken? other)
		{
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x55B6A0", Offset = "0x559CA0", VA = "0x18055B6A0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x55B700", Offset = "0x559D00", VA = "0x18055B700", Slot = "4")]
		public void Get(out IdToken output)
		{
		}

		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ProductUserId;

		// Token: 0x04001179 RID: 4473
		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_JsonWebToken;
	}
}
