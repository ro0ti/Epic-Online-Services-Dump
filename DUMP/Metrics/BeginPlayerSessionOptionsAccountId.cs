using System;


namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public struct BeginPlayerSessionOptionsAccountId
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00006D1C File Offset: 0x00004F1C
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A9")]
		public MetricsAccountIdType AccountIdType
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return MetricsAccountIdType.Epic;
			}
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			private set
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AA")]
		public EpicAccountId Epic
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x507B70", Offset = "0x506170", VA = "0x180507B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001822")]
			[Address(RVA = "0x507D30", Offset = "0x506330", VA = "0x180507D30")]
			set
			{
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AB")]
		public Utf8String External
		{
			[Token(Token = "0x6001823")]
			[Address(RVA = "0x507C00", Offset = "0x506200", VA = "0x180507C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001824")]
			[Address(RVA = "0x507DC0", Offset = "0x5063C0", VA = "0x180507DC0")]
			set
			{
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x507CD0", Offset = "0x5062D0", VA = "0x180507CD0")]
		public static implicit operator BeginPlayerSessionOptionsAccountId(EpicAccountId value)
		{
			return default(BeginPlayerSessionOptionsAccountId);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x507D00", Offset = "0x506300", VA = "0x180507D00")]
		public static implicit operator BeginPlayerSessionOptionsAccountId(Utf8String value)
		{
			return default(BeginPlayerSessionOptionsAccountId);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x507C90", Offset = "0x506290", VA = "0x180507C90")]
		public static implicit operator BeginPlayerSessionOptionsAccountId(string value)
		{
			return default(BeginPlayerSessionOptionsAccountId);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x507B20", Offset = "0x506120", VA = "0x180507B20")]
		internal void Set(ref BeginPlayerSessionOptionsAccountIdInternal other)
		{
		}

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x0")]
		private MetricsAccountIdType m_AccountIdType;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x8")]
		private EpicAccountId m_Epic;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x10")]
		private Utf8String m_External;
	}
}
