using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	internal struct CopyUnlockedAchievementByAchievementIdOptionsInternal : ISettable<CopyUnlockedAchievementByAchievementIdOptions>, IDisposable
	{
		// Token: 0x17000E5C RID: 3676
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E5C")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6002FED")]
			[Address(RVA = "0x585A00", Offset = "0x584000", VA = "0x180585A00")]
			set
			{
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E5D")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6002FEE")]
			[Address(RVA = "0x5859A0", Offset = "0x583FA0", VA = "0x1805859A0")]
			set
			{
			}
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x5857D0", Offset = "0x583DD0", VA = "0x1805857D0", Slot = "4")]
		public void Set(ref CopyUnlockedAchievementByAchievementIdOptions other)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x585890", Offset = "0x583E90", VA = "0x180585890", Slot = "5")]
		public void Set(ref CopyUnlockedAchievementByAchievementIdOptions? other)
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x585770", Offset = "0x583D70", VA = "0x180585770", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400159B RID: 5531
		[Token(Token = "0x400159B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400159C RID: 5532
		[Token(Token = "0x400159C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x0400159D RID: 5533
		[Token(Token = "0x400159D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AchievementId;
	}
}
