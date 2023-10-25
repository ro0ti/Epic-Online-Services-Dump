using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	internal struct AddNotifyAchievementsUnlockedV2OptionsInternal : ISettable<AddNotifyAchievementsUnlockedV2Options>, IDisposable
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x4EC400", Offset = "0x4EAA00", VA = "0x1804EC400", Slot = "4")]
		public void Set(ref AddNotifyAchievementsUnlockedV2Options other)
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x584BF0", Offset = "0x5831F0", VA = "0x180584BF0", Slot = "5")]
		public void Set(ref AddNotifyAchievementsUnlockedV2Options? other)
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400157E RID: 5502
		[Token(Token = "0x400157E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
