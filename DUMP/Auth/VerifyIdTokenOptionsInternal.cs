using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000688 RID: 1672
	[Token(Token = "0x2000688")]
	internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>, IDisposable
	{
		// Token: 0x17000C9C RID: 3228
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C9C")]
		public IdToken? IdToken
		{
			[Token(Token = "0x6002B15")]
			[Address(RVA = "0x581F20", Offset = "0x580520", VA = "0x180581F20")]
			set
			{
			}
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x581DD0", Offset = "0x5803D0", VA = "0x180581DD0", Slot = "4")]
		public void Set(ref VerifyIdTokenOptions other)
		{
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x581E50", Offset = "0x580450", VA = "0x180581E50", Slot = "5")]
		public void Set(ref VerifyIdTokenOptions? other)
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x581D80", Offset = "0x580380", VA = "0x180581D80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012B3 RID: 4787
		[Token(Token = "0x40012B3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_IdToken;
	}
}
