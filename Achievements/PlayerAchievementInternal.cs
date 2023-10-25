using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	internal struct PlayerAchievementInternal : IGettable<PlayerAchievement>, ISettable<PlayerAchievement>, IDisposable
	{
		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EBD")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6003104")]
			[Address(RVA = "0x58AEF0", Offset = "0x5894F0", VA = "0x18058AEF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003105")]
			[Address(RVA = "0x58B230", Offset = "0x589830", VA = "0x18058B230")]
			set
			{
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x0000CA1C File Offset: 0x0000AC1C
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EBE")]
		public double Progress
		{
			[Token(Token = "0x6003106")]
			[Address(RVA = "0x58B120", Offset = "0x589720", VA = "0x18058B120")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6003107")]
			[Address(RVA = "0x58B410", Offset = "0x589A10", VA = "0x18058B410")]
			set
			{
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0000CA34 File Offset: 0x0000AC34
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EBF")]
		public DateTimeOffset? UnlockTime
		{
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x58B1C0", Offset = "0x5897C0", VA = "0x18058B1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x58B4A0", Offset = "0x589AA0", VA = "0x18058B4A0")]
			set
			{
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC0")]
		public PlayerStatInfo[] StatInfo
		{
			[Token(Token = "0x600310A")]
			[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
			get
			{
				return null;
			}
			[Token(Token = "0x600310B")]
			[Address(RVA = "0x58B420", Offset = "0x589A20", VA = "0x18058B420")]
			set
			{
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC1")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x58AFD0", Offset = "0x5895D0", VA = "0x18058AFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x58B2F0", Offset = "0x5898F0", VA = "0x18058B2F0")]
			set
			{
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC2")]
		public Utf8String Description
		{
			[Token(Token = "0x600310E")]
			[Address(RVA = "0x58AF60", Offset = "0x589560", VA = "0x18058AF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600310F")]
			[Address(RVA = "0x58B290", Offset = "0x589890", VA = "0x18058B290")]
			set
			{
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC3")]
		public Utf8String IconURL
		{
			[Token(Token = "0x6003110")]
			[Address(RVA = "0x58B0B0", Offset = "0x5896B0", VA = "0x18058B0B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003111")]
			[Address(RVA = "0x58B3B0", Offset = "0x5899B0", VA = "0x18058B3B0")]
			set
			{
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC4")]
		public Utf8String FlavorText
		{
			[Token(Token = "0x6003112")]
			[Address(RVA = "0x58B040", Offset = "0x589640", VA = "0x18058B040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003113")]
			[Address(RVA = "0x58B350", Offset = "0x589950", VA = "0x18058B350")]
			set
			{
			}
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x58ACE0", Offset = "0x5892E0", VA = "0x18058ACE0", Slot = "5")]
		public void Set(ref PlayerAchievement other)
		{
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x58AA10", Offset = "0x589010", VA = "0x18058AA10", Slot = "6")]
		public void Set(ref PlayerAchievement? other)
		{
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003116")]
		[Address(RVA = "0x58A950", Offset = "0x588F50", VA = "0x18058A950", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x58A9E0", Offset = "0x588FE0", VA = "0x18058A9E0", Slot = "4")]
		public void Get(out PlayerAchievement output)
		{
		}

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AchievementId;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x10")]
		private double m_Progress;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x18")]
		private long m_UnlockTime;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x20")]
		private int m_StatInfoCount;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_StatInfo;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_DisplayName;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_Description;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_IconURL;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_FlavorText;
	}
}
