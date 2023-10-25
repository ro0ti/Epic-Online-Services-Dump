using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	internal struct GetUnlockedAchievementCountOptionsInternal : ISettable<GetUnlockedAchievementCountOptions>, IDisposable
	{
		// Token: 0x17000E8F RID: 3727
		// (set) Token: 0x06003064 RID: 12388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E8F")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6003064")]
			[Address(RVA = "0x588730", Offset = "0x586D30", VA = "0x180588730")]
			set
			{
			}
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x588630", Offset = "0x586C30", VA = "0x180588630", Slot = "4")]
		public void Set(ref GetUnlockedAchievementCountOptions other)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x588690", Offset = "0x586C90", VA = "0x180588690", Slot = "5")]
		public void Set(ref GetUnlockedAchievementCountOptions? other)
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x5885E0", Offset = "0x586BE0", VA = "0x1805885E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;
	}
}
