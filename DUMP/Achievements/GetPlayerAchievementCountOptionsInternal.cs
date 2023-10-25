using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	internal struct GetPlayerAchievementCountOptionsInternal : ISettable<GetPlayerAchievementCountOptions>, IDisposable
	{
		// Token: 0x17000E8D RID: 3725
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E8D")]
		public ProductUserId UserId
		{
			[Token(Token = "0x600305E")]
			[Address(RVA = "0x588580", Offset = "0x586B80", VA = "0x180588580")]
			set
			{
			}
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x588520", Offset = "0x586B20", VA = "0x180588520", Slot = "4")]
		public void Set(ref GetPlayerAchievementCountOptions other)
		{
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x588480", Offset = "0x586A80", VA = "0x180588480", Slot = "5")]
		public void Set(ref GetPlayerAchievementCountOptions? other)
		{
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x588430", Offset = "0x586A30", VA = "0x180588430", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;
	}
}
