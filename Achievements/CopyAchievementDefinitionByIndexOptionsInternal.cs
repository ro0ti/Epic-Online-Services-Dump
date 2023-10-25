using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	internal struct CopyAchievementDefinitionByIndexOptionsInternal : ISettable<CopyAchievementDefinitionByIndexOptions>, IDisposable
	{
		// Token: 0x17000E49 RID: 3657
		// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E49")]
		public uint AchievementIndex
		{
			[Token(Token = "0x6002FC1")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CopyAchievementDefinitionByIndexOptions other)
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x584DF0", Offset = "0x5833F0", VA = "0x180584DF0", Slot = "5")]
		public void Set(ref CopyAchievementDefinitionByIndexOptions? other)
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x4")]
		private uint m_AchievementIndex;
	}
}
