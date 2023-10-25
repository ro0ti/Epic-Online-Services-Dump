using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	internal struct CopyUnlockedAchievementByIndexOptionsInternal : ISettable<CopyUnlockedAchievementByIndexOptions>, IDisposable
	{
		// Token: 0x17000E60 RID: 3680
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E60")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6002FF6")]
			[Address(RVA = "0x585C00", Offset = "0x584200", VA = "0x180585C00")]
			set
			{
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E61")]
		public uint AchievementIndex
		{
			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x585B80", Offset = "0x584180", VA = "0x180585B80", Slot = "4")]
		public void Set(ref CopyUnlockedAchievementByIndexOptions other)
		{
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x585AB0", Offset = "0x5840B0", VA = "0x180585AB0", Slot = "5")]
		public void Set(ref CopyUnlockedAchievementByIndexOptions? other)
		{
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x585A60", Offset = "0x584060", VA = "0x180585A60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040015A0 RID: 5536
		[Token(Token = "0x40015A0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040015A1 RID: 5537
		[Token(Token = "0x40015A1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x040015A2 RID: 5538
		[Token(Token = "0x40015A2")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AchievementIndex;
	}
}
