using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	internal struct ShowReportPlayerOptionsInternal : ISettable<ShowReportPlayerOptions>, IDisposable
	{
		// Token: 0x17000101 RID: 257
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000101")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x4B1320", Offset = "0x4AF920", VA = "0x1804B1320")]
			set
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000102")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x4B13D0", Offset = "0x4AF9D0", VA = "0x1804B13D0")]
			set
			{
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4B1240", Offset = "0x4AF840", VA = "0x1804B1240", Slot = "4")]
		public void Set(ref ShowReportPlayerOptions other)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4B1280", Offset = "0x4AF880", VA = "0x1804B1280", Slot = "5")]
		public void Set(ref ShowReportPlayerOptions? other)
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x4B1160", Offset = "0x4AF760", VA = "0x1804B1160", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
