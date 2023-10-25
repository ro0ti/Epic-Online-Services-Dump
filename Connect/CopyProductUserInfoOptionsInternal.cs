using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F8 RID: 1528
	[Token(Token = "0x20005F8")]
	internal struct CopyProductUserInfoOptionsInternal : ISettable<CopyProductUserInfoOptions>, IDisposable
	{
		// Token: 0x17000B60 RID: 2912
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B60")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600273C")]
			[Address(RVA = "0x558400", Offset = "0x556A00", VA = "0x180558400")]
			set
			{
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x5583A0", Offset = "0x5569A0", VA = "0x1805583A0", Slot = "4")]
		public void Set(ref CopyProductUserInfoOptions other)
		{
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x558300", Offset = "0x556900", VA = "0x180558300", Slot = "5")]
		public void Set(ref CopyProductUserInfoOptions? other)
		{
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x5582B0", Offset = "0x5568B0", VA = "0x1805582B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
