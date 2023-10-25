using System;


namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public struct EndPlayerSessionOptionsAccountId
	{
		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00006D94 File Offset: 0x00004F94
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B0")]
		public MetricsAccountIdType AccountIdType
		{
			[Token(Token = "0x6001837")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return MetricsAccountIdType.Epic;
			}
			[Token(Token = "0x6001838")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			private set
			{
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B1")]
		public EpicAccountId Epic
		{
			[Token(Token = "0x6001839")]
			[Address(RVA = "0x50ACB0", Offset = "0x5092B0", VA = "0x18050ACB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600183A")]
			[Address(RVA = "0x50AE70", Offset = "0x509470", VA = "0x18050AE70")]
			set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B2")]
		public Utf8String External
		{
			[Token(Token = "0x600183B")]
			[Address(RVA = "0x50AD40", Offset = "0x509340", VA = "0x18050AD40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600183C")]
			[Address(RVA = "0x50AF00", Offset = "0x509500", VA = "0x18050AF00")]
			set
			{
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00006DAC File Offset: 0x00004FAC
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x50ADD0", Offset = "0x5093D0", VA = "0x18050ADD0")]
		public static implicit operator EndPlayerSessionOptionsAccountId(EpicAccountId value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x50AE40", Offset = "0x509440", VA = "0x18050AE40")]
		public static implicit operator EndPlayerSessionOptionsAccountId(Utf8String value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x50AE00", Offset = "0x509400", VA = "0x18050AE00")]
		public static implicit operator EndPlayerSessionOptionsAccountId(string value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x50AC60", Offset = "0x509260", VA = "0x18050AC60")]
		internal void Set(ref EndPlayerSessionOptionsAccountIdInternal other)
		{
		}

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x0")]
		private MetricsAccountIdType m_AccountIdType;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x8")]
		private EpicAccountId m_Epic;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x10")]
		private Utf8String m_External;
	}
}
