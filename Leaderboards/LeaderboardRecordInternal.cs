using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	internal struct LeaderboardRecordInternal : IGettable<LeaderboardRecord>, ISettable<LeaderboardRecord>, IDisposable
	{
		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000883")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001E24")]
			[Address(RVA = "0x5262B0", Offset = "0x5248B0", VA = "0x1805262B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x526390", Offset = "0x524990", VA = "0x180526390")]
			set
			{
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00008354 File Offset: 0x00006554
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000884")]
		public uint Rank
		{
			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0000836C File Offset: 0x0000656C
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000885")]
		public int Score
		{
			[Token(Token = "0x6001E28")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000886")]
		public Utf8String UserDisplayName
		{
			[Token(Token = "0x6001E2A")]
			[Address(RVA = "0x526240", Offset = "0x524840", VA = "0x180526240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E2B")]
			[Address(RVA = "0x526330", Offset = "0x524930", VA = "0x180526330")]
			set
			{
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x526170", Offset = "0x524770", VA = "0x180526170", Slot = "5")]
		public void Set(ref LeaderboardRecord other)
		{
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x526020", Offset = "0x524620", VA = "0x180526020", Slot = "6")]
		public void Set(ref LeaderboardRecord? other)
		{
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x525FA0", Offset = "0x5245A0", VA = "0x180525FA0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x526000", Offset = "0x524600", VA = "0x180526000", Slot = "4")]
		public void Get(out LeaderboardRecord output)
		{
		}

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Rank;

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x14")]
		private int m_Score;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_UserDisplayName;
	}
}
