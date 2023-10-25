using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	internal struct CopyAchievementDefinitionByAchievementIdOptionsInternal : ISettable<CopyAchievementDefinitionByAchievementIdOptions>, IDisposable
	{
		// Token: 0x17000E47 RID: 3655
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E47")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6002FBB")]
			[Address(RVA = "0x584D90", Offset = "0x583390", VA = "0x180584D90")]
			set
			{
			}
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x584D30", Offset = "0x583330", VA = "0x180584D30", Slot = "4")]
		public void Set(ref CopyAchievementDefinitionByAchievementIdOptions other)
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x584C90", Offset = "0x583290", VA = "0x180584C90", Slot = "5")]
		public void Set(ref CopyAchievementDefinitionByAchievementIdOptions? other)
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x584C40", Offset = "0x583240", VA = "0x180584C40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001580 RID: 5504
		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001581 RID: 5505
		[Token(Token = "0x4001581")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AchievementId;
	}
}
