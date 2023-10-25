using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	internal struct SessionSearchGetSearchResultCountOptionsInternal : ISettable<SessionSearchGetSearchResultCountOptions>, IDisposable
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref SessionSearchGetSearchResultCountOptions other)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x4CC3F0", Offset = "0x4CA9F0", VA = "0x1804CC3F0", Slot = "5")]
		public void Set(ref SessionSearchGetSearchResultCountOptions? other)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
