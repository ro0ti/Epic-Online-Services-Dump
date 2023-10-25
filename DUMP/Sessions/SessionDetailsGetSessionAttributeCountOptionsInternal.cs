using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	internal struct SessionDetailsGetSessionAttributeCountOptionsInternal : ISettable<SessionDetailsGetSessionAttributeCountOptions>, IDisposable
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref SessionDetailsGetSessionAttributeCountOptions other)
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4C74D0", Offset = "0x4C5AD0", VA = "0x1804C74D0", Slot = "5")]
		public void Set(ref SessionDetailsGetSessionAttributeCountOptions? other)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
