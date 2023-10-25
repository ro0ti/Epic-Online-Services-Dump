using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	internal struct UnlockAchievementsOptionsInternal : ISettable<UnlockAchievementsOptions>, IDisposable
	{
		// Token: 0x17000EDB RID: 3803
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDB")]
		public ProductUserId UserId
		{
			[Token(Token = "0x600314F")]
			[Address(RVA = "0x58C730", Offset = "0x58AD30", VA = "0x18058C730")]
			set
			{
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDC")]
		public Utf8String[] AchievementIds
		{
			[Token(Token = "0x6003150")]
			[Address(RVA = "0x58C6A0", Offset = "0x58ACA0", VA = "0x18058C6A0")]
			set
			{
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x58C530", Offset = "0x58AB30", VA = "0x18058C530", Slot = "4")]
		public void Set(ref UnlockAchievementsOptions other)
		{
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x58C5C0", Offset = "0x58ABC0", VA = "0x18058C5C0", Slot = "5")]
		public void Set(ref UnlockAchievementsOptions? other)
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x58C4D0", Offset = "0x58AAD0", VA = "0x18058C4D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AchievementIds;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AchievementsCount;
	}
}
