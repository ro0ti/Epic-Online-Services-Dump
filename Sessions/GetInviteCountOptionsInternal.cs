using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	internal struct GetInviteCountOptionsInternal : ISettable<GetInviteCountOptions>, IDisposable
	{
		// Token: 0x170001DB RID: 475
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x4BCBE0", Offset = "0x4BB1E0", VA = "0x1804BCBE0")]
			set
			{
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x4BCAE0", Offset = "0x4BB0E0", VA = "0x1804BCAE0", Slot = "4")]
		public void Set(ref GetInviteCountOptions other)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x4BCB40", Offset = "0x4BB140", VA = "0x1804BCB40", Slot = "5")]
		public void Set(ref GetInviteCountOptions? other)
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x4BCA90", Offset = "0x4BB090", VA = "0x1804BCA90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
