using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	internal struct SessionModificationRemoveAttributeOptionsInternal : ISettable<SessionModificationRemoveAttributeOptions>, IDisposable
	{
		// Token: 0x1700027C RID: 636
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700027C")]
		public Utf8String Key
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x4CAE40", Offset = "0x4C9440", VA = "0x1804CAE40")]
			set
			{
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x4CAD40", Offset = "0x4C9340", VA = "0x1804CAD40", Slot = "4")]
		public void Set(ref SessionModificationRemoveAttributeOptions other)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x4CADA0", Offset = "0x4C93A0", VA = "0x1804CADA0", Slot = "5")]
		public void Set(ref SessionModificationRemoveAttributeOptions? other)
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x4CACF0", Offset = "0x4C92F0", VA = "0x1804CACF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;
	}
}
