using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	internal struct CopyStatByIndexOptionsInternal : ISettable<CopyStatByIndexOptions>, IDisposable
	{
		// Token: 0x17000163 RID: 355
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000163")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x4BB340", Offset = "0x4B9940", VA = "0x1804BB340")]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000164")]
		public uint StatIndex
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4BB1F0", Offset = "0x4B97F0", VA = "0x1804BB1F0", Slot = "4")]
		public void Set(ref CopyStatByIndexOptions other)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4BB270", Offset = "0x4B9870", VA = "0x1804BB270", Slot = "5")]
		public void Set(ref CopyStatByIndexOptions? other)
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4BB1A0", Offset = "0x4B97A0", VA = "0x1804BB1A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x10")]
		private uint m_StatIndex;
	}
}
