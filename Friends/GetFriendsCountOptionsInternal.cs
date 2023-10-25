using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	internal struct GetFriendsCountOptionsInternal : ISettable<GetFriendsCountOptions>, IDisposable
	{
		// Token: 0x1700095A RID: 2394
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x547230", Offset = "0x545830", VA = "0x180547230")]
			set
			{
			}
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x547130", Offset = "0x545730", VA = "0x180547130", Slot = "4")]
		public void Set(ref GetFriendsCountOptions other)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x547190", Offset = "0x545790", VA = "0x180547190", Slot = "5")]
		public void Set(ref GetFriendsCountOptions? other)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x5470E0", Offset = "0x5456E0", VA = "0x1805470E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
