using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	internal struct DestroySessionOptionsInternal : ISettable<DestroySessionOptions>, IDisposable
	{
		// Token: 0x170001D0 RID: 464
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D0")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x4BC3A0", Offset = "0x4BA9A0", VA = "0x1804BC3A0")]
			set
			{
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4BC340", Offset = "0x4BA940", VA = "0x1804BC340", Slot = "4")]
		public void Set(ref DestroySessionOptions other)
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4BC2A0", Offset = "0x4BA8A0", VA = "0x1804BC2A0", Slot = "5")]
		public void Set(ref DestroySessionOptions? other)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4BC250", Offset = "0x4BA850", VA = "0x1804BC250", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
