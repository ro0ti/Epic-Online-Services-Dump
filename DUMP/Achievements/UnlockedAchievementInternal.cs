using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	internal struct UnlockedAchievementInternal : IGettable<UnlockedAchievement>, ISettable<UnlockedAchievement>, IDisposable
	{
		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDF")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6003159")]
			[Address(RVA = "0x58CA10", Offset = "0x58B010", VA = "0x18058CA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600315A")]
			[Address(RVA = "0x58CAF0", Offset = "0x58B0F0", VA = "0x18058CAF0")]
			set
			{
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EE0")]
		public DateTimeOffset? UnlockTime
		{
			[Token(Token = "0x600315B")]
			[Address(RVA = "0x58CA80", Offset = "0x58B080", VA = "0x18058CA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600315C")]
			[Address(RVA = "0x58CB50", Offset = "0x58B150", VA = "0x18058CB50")]
			set
			{
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600315D")]
		[Address(RVA = "0x58C920", Offset = "0x58AF20", VA = "0x18058C920", Slot = "5")]
		public void Set(ref UnlockedAchievement other)
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x58C800", Offset = "0x58AE00", VA = "0x18058C800", Slot = "6")]
		public void Set(ref UnlockedAchievement? other)
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x58C790", Offset = "0x58AD90", VA = "0x18058C790", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x58C7E0", Offset = "0x58ADE0", VA = "0x18058C7E0", Slot = "4")]
		public void Get(out UnlockedAchievement output)
		{
		}

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AchievementId;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x10")]
		private long m_UnlockTime;
	}
}
