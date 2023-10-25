using System;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	internal struct ClientCredentialsInternal : IGettable<ClientCredentials>, ISettable<ClientCredentials>, IDisposable
	{
		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDE")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002EC0")]
			[Address(RVA = "0x56FFF0", Offset = "0x56E5F0", VA = "0x18056FFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EC1")]
			[Address(RVA = "0x5700D0", Offset = "0x56E6D0", VA = "0x1805700D0")]
			set
			{
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDF")]
		public Utf8String ClientSecret
		{
			[Token(Token = "0x6002EC2")]
			[Address(RVA = "0x570060", Offset = "0x56E660", VA = "0x180570060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EC3")]
			[Address(RVA = "0x570130", Offset = "0x56E730", VA = "0x180570130")]
			set
			{
			}
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "5")]
		public void Set(ref ClientCredentials other)
		{
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x56FEF0", Offset = "0x56E4F0", VA = "0x18056FEF0", Slot = "6")]
		public void Set(ref ClientCredentials? other)
		{
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x56FDC0", Offset = "0x56E3C0", VA = "0x18056FDC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x56FE20", Offset = "0x56E420", VA = "0x18056FE20", Slot = "4")]
		public void Get(out ClientCredentials output)
		{
		}

		// Token: 0x040014D8 RID: 5336
		[Token(Token = "0x40014D8")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientId;

		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientSecret;
	}
}
