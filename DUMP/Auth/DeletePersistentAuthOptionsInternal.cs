using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000659 RID: 1625
	[Token(Token = "0x2000659")]
	internal struct DeletePersistentAuthOptionsInternal : ISettable<DeletePersistentAuthOptions>, IDisposable
	{
		// Token: 0x17000C1A RID: 3098
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1A")]
		public Utf8String RefreshToken
		{
			[Token(Token = "0x600299F")]
			[Address(RVA = "0x55A0E0", Offset = "0x5586E0", VA = "0x18055A0E0")]
			set
			{
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x55A080", Offset = "0x558680", VA = "0x18055A080", Slot = "4")]
		public void Set(ref DeletePersistentAuthOptions other)
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x559FE0", Offset = "0x5585E0", VA = "0x180559FE0", Slot = "5")]
		public void Set(ref DeletePersistentAuthOptions? other)
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x559F90", Offset = "0x558590", VA = "0x180559F90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_RefreshToken;
	}
}
