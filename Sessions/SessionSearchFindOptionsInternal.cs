using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	internal struct SessionSearchFindOptionsInternal : ISettable<SessionSearchFindOptions>, IDisposable
	{
		// Token: 0x17000293 RID: 659
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000293")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x4CC390", Offset = "0x4CA990", VA = "0x1804CC390")]
			set
			{
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x4CC290", Offset = "0x4CA890", VA = "0x1804CC290", Slot = "4")]
		public void Set(ref SessionSearchFindOptions other)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x4CC2F0", Offset = "0x4CA8F0", VA = "0x1804CC2F0", Slot = "5")]
		public void Set(ref SessionSearchFindOptions? other)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x4CC240", Offset = "0x4CA840", VA = "0x1804CC240", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
