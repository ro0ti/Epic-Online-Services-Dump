using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	internal struct DefinitionInternal : IGettable<Definition>, ISettable<Definition>, IDisposable
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000878")]
		public Utf8String LeaderboardId
		{
			[Token(Token = "0x6001E01")]
			[Address(RVA = "0x5231F0", Offset = "0x5217F0", VA = "0x1805231F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E02")]
			[Address(RVA = "0x5233B0", Offset = "0x5219B0", VA = "0x1805233B0")]
			set
			{
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000879")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001E03")]
			[Address(RVA = "0x5232D0", Offset = "0x5218D0", VA = "0x1805232D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0x523480", Offset = "0x521A80", VA = "0x180523480")]
			set
			{
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x000082DC File Offset: 0x000064DC
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700087A")]
		public LeaderboardAggregation Aggregation
		{
			[Token(Token = "0x6001E05")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return LeaderboardAggregation.Min;
			}
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x000082F4 File Offset: 0x000064F4
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700087B")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001E07")]
			[Address(RVA = "0x523260", Offset = "0x521860", VA = "0x180523260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0x523410", Offset = "0x521A10", VA = "0x180523410")]
			set
			{
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0000830C File Offset: 0x0000650C
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700087C")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001E09")]
			[Address(RVA = "0x523180", Offset = "0x521780", VA = "0x180523180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x523340", Offset = "0x521940", VA = "0x180523340")]
			set
			{
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x522DD0", Offset = "0x5213D0", VA = "0x180522DD0", Slot = "5")]
		public void Set(ref Definition other)
		{
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x522F70", Offset = "0x521570", VA = "0x180522F70", Slot = "6")]
		public void Set(ref Definition? other)
		{
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x522D40", Offset = "0x521340", VA = "0x180522D40", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x522DA0", Offset = "0x5213A0", VA = "0x180522DA0", Slot = "4")]
		public void Get(out Definition output)
		{
		}

		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LeaderboardId;

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_StatName;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x18")]
		private LeaderboardAggregation m_Aggregation;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x20")]
		private long m_StartTime;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x28")]
		private long m_EndTime;
	}
}
