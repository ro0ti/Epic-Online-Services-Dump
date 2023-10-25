using System;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	internal struct GetBlockedUserAtIndexOptionsInternal : ISettable<GetBlockedUserAtIndexOptions>, IDisposable
	{
		// Token: 0x17000951 RID: 2385
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000951")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020DB")]
			[Address(RVA = "0x546830", Offset = "0x544E30", VA = "0x180546830")]
			set
			{
			}
		}

		// Token: 0x17000952 RID: 2386
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000952")]
		public int Index
		{
			[Token(Token = "0x60020DC")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x5467B0", Offset = "0x544DB0", VA = "0x1805467B0", Slot = "4")]
		public void Set(ref GetBlockedUserAtIndexOptions other)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x5466E0", Offset = "0x544CE0", VA = "0x1805466E0", Slot = "5")]
		public void Set(ref GetBlockedUserAtIndexOptions? other)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x546690", Offset = "0x544C90", VA = "0x180546690", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x10")]
		private int m_Index;
	}
}
