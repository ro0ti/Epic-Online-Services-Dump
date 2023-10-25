using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	internal struct SessionSearchSetParameterOptionsInternal : ISettable<SessionSearchSetParameterOptions>, IDisposable
	{
		// Token: 0x1700029C RID: 668
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029C")]
		public AttributeData? Parameter
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x4CC9F0", Offset = "0x4CAFF0", VA = "0x1804CC9F0")]
			set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029D")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x4CC810", Offset = "0x4CAE10", VA = "0x1804CC810", Slot = "4")]
		public void Set(ref SessionSearchSetParameterOptions other)
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x4CC8C0", Offset = "0x4CAEC0", VA = "0x1804CC8C0", Slot = "5")]
		public void Set(ref SessionSearchSetParameterOptions? other)
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x4CC7C0", Offset = "0x4CADC0", VA = "0x1804CC7C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Parameter;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x10")]
		private ComparisonOp m_ComparisonOp;
	}
}
