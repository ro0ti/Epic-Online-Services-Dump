using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	internal struct QueryStatsOptionsInternal : ISettable<QueryStatsOptions>, IDisposable
	{
		// Token: 0x1700018C RID: 396
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x4C31D0", Offset = "0x4C17D0", VA = "0x1804C31D0")]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018D")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x4C3230", Offset = "0x4C1830", VA = "0x1804C3230")]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018E")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x4C3160", Offset = "0x4C1760", VA = "0x1804C3160")]
			set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018F")]
		public Utf8String[] StatNames
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x4C32A0", Offset = "0x4C18A0", VA = "0x1804C32A0")]
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000190")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x4C3330", Offset = "0x4C1930", VA = "0x1804C3330")]
			set
			{
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x4C2D90", Offset = "0x4C1390", VA = "0x1804C2D90", Slot = "4")]
		public void Set(ref QueryStatsOptions other)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x4C2F40", Offset = "0x4C1540", VA = "0x1804C2F40", Slot = "5")]
		public void Set(ref QueryStatsOptions? other)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x4C2D20", Offset = "0x4C1320", VA = "0x1804C2D20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x10")]
		private long m_StartTime;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x18")]
		private long m_EndTime;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_StatNames;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x28")]
		private uint m_StatNamesCount;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_TargetUserId;
	}
}
