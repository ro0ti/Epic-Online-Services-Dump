using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	internal struct CopyAchievementDefinitionV2ByAchievementIdOptionsInternal : ISettable<CopyAchievementDefinitionV2ByAchievementIdOptions>, IDisposable
	{
		// Token: 0x17000E4B RID: 3659
		// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E4B")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6002FC7")]
			[Address(RVA = "0x584FA0", Offset = "0x5835A0", VA = "0x180584FA0")]
			set
			{
			}
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x584F40", Offset = "0x583540", VA = "0x180584F40", Slot = "4")]
		public void Set(ref CopyAchievementDefinitionV2ByAchievementIdOptions other)
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x584EA0", Offset = "0x5834A0", VA = "0x180584EA0", Slot = "5")]
		public void Set(ref CopyAchievementDefinitionV2ByAchievementIdOptions? other)
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x584E50", Offset = "0x583450", VA = "0x180584E50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001586 RID: 5510
		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001587 RID: 5511
		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AchievementId;
	}
}
