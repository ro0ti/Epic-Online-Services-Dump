using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	internal struct CopyPlayerAchievementByIndexOptionsInternal : ISettable<CopyPlayerAchievementByIndexOptions>, IDisposable
	{
		// Token: 0x17000E57 RID: 3671
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E57")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002FE3")]
			[Address(RVA = "0x585710", Offset = "0x583D10", VA = "0x180585710")]
			set
			{
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E58")]
		public uint AchievementIndex
		{
			[Token(Token = "0x6002FE4")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E59")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002FE5")]
			[Address(RVA = "0x5856B0", Offset = "0x583CB0", VA = "0x1805856B0")]
			set
			{
			}
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x5855E0", Offset = "0x583BE0", VA = "0x1805855E0", Slot = "4")]
		public void Set(ref CopyPlayerAchievementByIndexOptions other)
		{
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x5854B0", Offset = "0x583AB0", VA = "0x1805854B0", Slot = "5")]
		public void Set(ref CopyPlayerAchievementByIndexOptions? other)
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x585450", Offset = "0x583A50", VA = "0x180585450", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AchievementIndex;

		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;
	}
}
