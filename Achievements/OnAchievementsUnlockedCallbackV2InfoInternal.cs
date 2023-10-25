using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	internal struct OnAchievementsUnlockedCallbackV2InfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackV2Info>, ISettable<OnAchievementsUnlockedCallbackV2Info>, IDisposable
	{
		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E9B")]
		public object ClientData
		{
			[Token(Token = "0x6003095")]
			[Address(RVA = "0x589260", Offset = "0x587860", VA = "0x180589260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003096")]
			[Address(RVA = "0x589420", Offset = "0x587A20", VA = "0x180589420")]
			set
			{
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x0000C86C File Offset: 0x0000AA6C
		[Token(Token = "0x17000E9C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6003097")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E9D")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6003098")]
			[Address(RVA = "0x589340", Offset = "0x587940", VA = "0x180589340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003099")]
			[Address(RVA = "0x5894F0", Offset = "0x587AF0", VA = "0x1805894F0")]
			set
			{
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E9E")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x600309A")]
			[Address(RVA = "0x5891F0", Offset = "0x5877F0", VA = "0x1805891F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600309B")]
			[Address(RVA = "0x5893C0", Offset = "0x5879C0", VA = "0x1805893C0")]
			set
			{
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x0000C884 File Offset: 0x0000AA84
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E9F")]
		public DateTimeOffset? UnlockTime
		{
			[Token(Token = "0x600309C")]
			[Address(RVA = "0x5892D0", Offset = "0x5878D0", VA = "0x1805892D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600309D")]
			[Address(RVA = "0x589480", Offset = "0x587A80", VA = "0x180589480")]
			set
			{
			}
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x588EB0", Offset = "0x5874B0", VA = "0x180588EB0", Slot = "6")]
		public void Set(ref OnAchievementsUnlockedCallbackV2Info other)
		{
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x589020", Offset = "0x587620", VA = "0x180589020", Slot = "7")]
		public void Set(ref OnAchievementsUnlockedCallbackV2Info? other)
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x588E30", Offset = "0x587430", VA = "0x180588E30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x588E90", Offset = "0x587490", VA = "0x180588E90", Slot = "5")]
		public void Get(out OnAchievementsUnlockedCallbackV2Info output)
		{
		}

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AchievementId;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x18")]
		private long m_UnlockTime;
	}
}
