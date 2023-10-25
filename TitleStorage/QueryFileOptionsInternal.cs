using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	internal struct QueryFileOptionsInternal : ISettable<QueryFileOptions>, IDisposable
	{
		// Token: 0x1700013F RID: 319
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x4C2600", Offset = "0x4C0C00", VA = "0x1804C2600")]
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000140")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x4C25A0", Offset = "0x4C0BA0", VA = "0x1804C25A0")]
			set
			{
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4C23D0", Offset = "0x4C09D0", VA = "0x1804C23D0", Slot = "4")]
		public void Set(ref QueryFileOptions other)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x4C2490", Offset = "0x4C0A90", VA = "0x1804C2490", Slot = "5")]
		public void Set(ref QueryFileOptions? other)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x4C2370", Offset = "0x4C0970", VA = "0x1804C2370", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;
	}
}
