using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	internal struct QueryDefinitionsOptionsInternal : ISettable<QueryDefinitionsOptions>, IDisposable
	{
		// Token: 0x17000ECE RID: 3790
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600312F")]
			[Address(RVA = "0x58BE60", Offset = "0x58A460", VA = "0x18058BE60")]
			set
			{
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECF")]
		public EpicAccountId EpicUserId_DEPRECATED
		{
			[Token(Token = "0x6003130")]
			[Address(RVA = "0x58BD70", Offset = "0x58A370", VA = "0x18058BD70")]
			set
			{
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED0")]
		public Utf8String[] HiddenAchievementIds_DEPRECATED
		{
			[Token(Token = "0x6003131")]
			[Address(RVA = "0x58BDD0", Offset = "0x58A3D0", VA = "0x18058BDD0")]
			set
			{
			}
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x58BCA0", Offset = "0x58A2A0", VA = "0x18058BCA0", Slot = "4")]
		public void Set(ref QueryDefinitionsOptions other)
		{
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x58BB70", Offset = "0x58A170", VA = "0x18058BB70", Slot = "5")]
		public void Set(ref QueryDefinitionsOptions? other)
		{
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x58BB00", Offset = "0x58A100", VA = "0x18058BB00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EpicUserId_DEPRECATED;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_HiddenAchievementIds_DEPRECATED;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x20")]
		private uint m_HiddenAchievementsCount_DEPRECATED;
	}
}
