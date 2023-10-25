using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	internal struct ShowFriendsOptionsInternal : ISettable<ShowFriendsOptions>, IDisposable
	{
		// Token: 0x170000F1 RID: 241
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F1")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x4B0660", Offset = "0x4AEC60", VA = "0x1804B0660")]
			set
			{
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x4B0640", Offset = "0x4AEC40", VA = "0x1804B0640", Slot = "4")]
		public void Set(ref ShowFriendsOptions other)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x4B05D0", Offset = "0x4AEBD0", VA = "0x1804B05D0", Slot = "5")]
		public void Set(ref ShowFriendsOptions? other)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x4B0540", Offset = "0x4AEB40", VA = "0x1804B0540", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
