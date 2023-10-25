using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	internal struct GetEntitlementsCountOptionsInternal : ISettable<GetEntitlementsCountOptions>, IDisposable
	{
		// Token: 0x17000A3A RID: 2618
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002350")]
			[Address(RVA = "0x546E80", Offset = "0x545480", VA = "0x180546E80")]
			set
			{
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x546E20", Offset = "0x545420", VA = "0x180546E20", Slot = "4")]
		public void Set(ref GetEntitlementsCountOptions other)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x546D80", Offset = "0x545380", VA = "0x180546D80", Slot = "5")]
		public void Set(ref GetEntitlementsCountOptions? other)
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x546D30", Offset = "0x545330", VA = "0x180546D30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
