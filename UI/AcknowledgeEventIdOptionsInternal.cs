using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal struct AcknowledgeEventIdOptionsInternal : ISettable<AcknowledgeEventIdOptions>, IDisposable
	{
		// Token: 0x1700008E RID: 142
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008E")]
		public ulong UiEventId
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008F")]
		public Result Result
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4874E0", Offset = "0x485AE0", VA = "0x1804874E0", Slot = "4")]
		public void Set(ref AcknowledgeEventIdOptions other)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x487500", Offset = "0x485B00", VA = "0x180487500", Slot = "5")]
		public void Set(ref AcknowledgeEventIdOptions? other)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_UiEventId;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x10")]
		private Result m_Result;
	}
}
