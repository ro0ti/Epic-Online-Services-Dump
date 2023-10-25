using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable
	{
		// Token: 0x17000C42 RID: 3138
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C42")]
		public Credentials? Credentials
		{
			[Token(Token = "0x6002A00")]
			[Address(RVA = "0x55ED10", Offset = "0x55D310", VA = "0x18055ED10")]
			set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C43")]
		public AuthScopeFlags ScopeFlags
		{
			[Token(Token = "0x6002A01")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C44")]
		public LoginFlags LoginFlags
		{
			[Token(Token = "0x6002A02")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x55EA00", Offset = "0x55D000", VA = "0x18055EA00", Slot = "4")]
		public void Set(ref LoginOptions other)
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x55E8D0", Offset = "0x55CED0", VA = "0x18055E8D0", Slot = "5")]
		public void Set(ref LoginOptions? other)
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x55E820", Offset = "0x55CE20", VA = "0x18055E820", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Credentials;

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x10")]
		private AuthScopeFlags m_ScopeFlags;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x18")]
		private LoginFlags m_LoginFlags;
	}
}
