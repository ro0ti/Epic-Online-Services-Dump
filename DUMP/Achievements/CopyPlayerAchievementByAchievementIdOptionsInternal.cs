using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	internal struct CopyPlayerAchievementByAchievementIdOptionsInternal : ISettable<CopyPlayerAchievementByAchievementIdOptions>, IDisposable
	{
		// Token: 0x17000E51 RID: 3665
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E51")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002FD7")]
			[Address(RVA = "0x5853F0", Offset = "0x5839F0", VA = "0x1805853F0")]
			set
			{
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E52")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6002FD8")]
			[Address(RVA = "0x585330", Offset = "0x583930", VA = "0x180585330")]
			set
			{
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E53")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002FD9")]
			[Address(RVA = "0x585390", Offset = "0x583990", VA = "0x180585390")]
			set
			{
			}
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x585230", Offset = "0x583830", VA = "0x180585230", Slot = "4")]
		public void Set(ref CopyPlayerAchievementByAchievementIdOptions other)
		{
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x5850D0", Offset = "0x5836D0", VA = "0x1805850D0", Slot = "5")]
		public void Set(ref CopyPlayerAchievementByAchievementIdOptions? other)
		{
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x585060", Offset = "0x583660", VA = "0x180585060", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AchievementId;

		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;
	}
}
