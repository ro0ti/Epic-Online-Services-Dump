using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	internal struct DumpSessionStateOptionsInternal : ISettable<DumpSessionStateOptions>, IDisposable
	{
		// Token: 0x170001D2 RID: 466
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D2")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x4BC550", Offset = "0x4BAB50", VA = "0x1804BC550")]
			set
			{
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4BC450", Offset = "0x4BAA50", VA = "0x1804BC450", Slot = "4")]
		public void Set(ref DumpSessionStateOptions other)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4BC4B0", Offset = "0x4BAAB0", VA = "0x1804BC4B0", Slot = "5")]
		public void Set(ref DumpSessionStateOptions? other)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4BC400", Offset = "0x4BAA00", VA = "0x1804BC400", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
