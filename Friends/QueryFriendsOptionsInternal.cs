using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	internal struct QueryFriendsOptionsInternal : ISettable<QueryFriendsOptions>, IDisposable
	{
		// Token: 0x1700097B RID: 2427
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002175")]
			[Address(RVA = "0x54C840", Offset = "0x54AE40", VA = "0x18054C840")]
			set
			{
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x54C740", Offset = "0x54AD40", VA = "0x18054C740", Slot = "4")]
		public void Set(ref QueryFriendsOptions other)
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x54C7A0", Offset = "0x54ADA0", VA = "0x18054C7A0", Slot = "5")]
		public void Set(ref QueryFriendsOptions? other)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x54C6F0", Offset = "0x54ACF0", VA = "0x18054C6F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
