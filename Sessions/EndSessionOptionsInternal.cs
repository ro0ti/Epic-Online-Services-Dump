using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, IDisposable
	{
		// Token: 0x170001D9 RID: 473
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D9")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x4BCA30", Offset = "0x4BB030", VA = "0x1804BCA30")]
			set
			{
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4BC9D0", Offset = "0x4BAFD0", VA = "0x1804BC9D0", Slot = "4")]
		public void Set(ref EndSessionOptions other)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x4BC930", Offset = "0x4BAF30", VA = "0x1804BC930", Slot = "5")]
		public void Set(ref EndSessionOptions? other)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4BC8E0", Offset = "0x4BAEE0", VA = "0x1804BC8E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
