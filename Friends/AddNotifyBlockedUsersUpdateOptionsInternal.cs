using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	internal struct AddNotifyBlockedUsersUpdateOptionsInternal : ISettable<AddNotifyBlockedUsersUpdateOptions>, IDisposable
	{
		// Token: 0x060020BC RID: 8380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyBlockedUsersUpdateOptions other)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x539D60", Offset = "0x538360", VA = "0x180539D60", Slot = "5")]
		public void Set(ref AddNotifyBlockedUsersUpdateOptions? other)
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
