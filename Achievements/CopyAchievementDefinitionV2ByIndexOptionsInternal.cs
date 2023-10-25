using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	internal struct CopyAchievementDefinitionV2ByIndexOptionsInternal : ISettable<CopyAchievementDefinitionV2ByIndexOptions>, IDisposable
	{
		// Token: 0x17000E4D RID: 3661
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E4D")]
		public uint AchievementIndex
		{
			[Token(Token = "0x6002FCD")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x521760", Offset = "0x51FD60", VA = "0x180521760", Slot = "4")]
		public void Set(ref CopyAchievementDefinitionV2ByIndexOptions other)
		{
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x585000", Offset = "0x583600", VA = "0x180585000", Slot = "5")]
		public void Set(ref CopyAchievementDefinitionV2ByIndexOptions? other)
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001589 RID: 5513
		[Token(Token = "0x4001589")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400158A RID: 5514
		[Token(Token = "0x400158A")]
		[FieldOffset(Offset = "0x4")]
		private uint m_AchievementIndex;
	}
}
