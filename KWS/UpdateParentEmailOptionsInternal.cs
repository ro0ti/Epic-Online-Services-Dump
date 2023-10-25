using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	internal struct UpdateParentEmailOptionsInternal : ISettable<UpdateParentEmailOptions>, IDisposable
	{
		// Token: 0x1700090C RID: 2316
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700090C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FED")]
			[Address(RVA = "0x538640", Offset = "0x536C40", VA = "0x180538640")]
			set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700090D")]
		public Utf8String ParentEmail
		{
			[Token(Token = "0x6001FEE")]
			[Address(RVA = "0x5386A0", Offset = "0x536CA0", VA = "0x1805386A0")]
			set
			{
			}
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x538470", Offset = "0x536A70", VA = "0x180538470", Slot = "4")]
		public void Set(ref UpdateParentEmailOptions other)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x538530", Offset = "0x536B30", VA = "0x180538530", Slot = "5")]
		public void Set(ref UpdateParentEmailOptions? other)
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x538410", Offset = "0x536A10", VA = "0x180538410", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ParentEmail;
	}
}
