using System;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	internal struct GetFriendAtIndexOptionsInternal : ISettable<GetFriendAtIndexOptions>, IDisposable
	{
		// Token: 0x17000957 RID: 2391
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000957")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020EA")]
			[Address(RVA = "0x547080", Offset = "0x545680", VA = "0x180547080")]
			set
			{
			}
		}

		// Token: 0x17000958 RID: 2392
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000958")]
		public int Index
		{
			[Token(Token = "0x60020EB")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x547000", Offset = "0x545600", VA = "0x180547000", Slot = "4")]
		public void Set(ref GetFriendAtIndexOptions other)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x546F30", Offset = "0x545530", VA = "0x180546F30", Slot = "5")]
		public void Set(ref GetFriendAtIndexOptions? other)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x546EE0", Offset = "0x5454E0", VA = "0x180546EE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x10")]
		private int m_Index;
	}
}
