using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	internal struct IngestStatOptionsInternal : ISettable<IngestStatOptions>, IDisposable
	{
		// Token: 0x1700017B RID: 379
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x4BDC30", Offset = "0x4BC230", VA = "0x1804BDC30")]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017C")]
		public IngestData[] Stats
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x4BDC90", Offset = "0x4BC290", VA = "0x1804BDC90")]
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017D")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x4BDD10", Offset = "0x4BC310", VA = "0x1804BDD10")]
			set
			{
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x4BDA30", Offset = "0x4BC030", VA = "0x1804BDA30", Slot = "4")]
		public void Set(ref IngestStatOptions other)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x4BDB00", Offset = "0x4BC100", VA = "0x1804BDB00", Slot = "5")]
		public void Set(ref IngestStatOptions? other)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x4BD9C0", Offset = "0x4BBFC0", VA = "0x1804BD9C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Stats;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		private uint m_StatsCount;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_TargetUserId;
	}
}
