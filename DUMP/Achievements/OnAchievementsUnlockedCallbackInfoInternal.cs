using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	internal struct OnAchievementsUnlockedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackInfo>, ISettable<OnAchievementsUnlockedCallbackInfo>, IDisposable
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E93")]
		public object ClientData
		{
			[Token(Token = "0x6003078")]
			[Address(RVA = "0x588AA0", Offset = "0x5870A0", VA = "0x180588AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003079")]
			[Address(RVA = "0x588C20", Offset = "0x587220", VA = "0x180588C20")]
			set
			{
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x0000C824 File Offset: 0x0000AA24
		[Token(Token = "0x17000E94")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600307A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E95")]
		public ProductUserId UserId
		{
			[Token(Token = "0x600307B")]
			[Address(RVA = "0x588B10", Offset = "0x587110", VA = "0x180588B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600307C")]
			[Address(RVA = "0x588C80", Offset = "0x587280", VA = "0x180588C80")]
			set
			{
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E96")]
		public Utf8String[] AchievementIds
		{
			[Token(Token = "0x600307D")]
			[Address(RVA = "0x588A10", Offset = "0x587010", VA = "0x180588A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600307E")]
			[Address(RVA = "0x588B90", Offset = "0x587190", VA = "0x180588B90")]
			set
			{
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600307F")]
		[Address(RVA = "0x588940", Offset = "0x586F40", VA = "0x180588940", Slot = "6")]
		public void Set(ref OnAchievementsUnlockedCallbackInfo other)
		{
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x588810", Offset = "0x586E10", VA = "0x180588810", Slot = "7")]
		public void Set(ref OnAchievementsUnlockedCallbackInfo? other)
		{
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x588790", Offset = "0x586D90", VA = "0x180588790", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x5887F0", Offset = "0x586DF0", VA = "0x1805887F0", Slot = "5")]
		public void Get(out OnAchievementsUnlockedCallbackInfo output)
		{
		}

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AchievementsCount;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AchievementIds;
	}
}
