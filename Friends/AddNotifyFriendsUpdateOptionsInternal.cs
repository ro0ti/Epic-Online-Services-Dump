using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	internal struct AddNotifyFriendsUpdateOptionsInternal : ISettable<AddNotifyFriendsUpdateOptions>, IDisposable
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyFriendsUpdateOptions other)
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x539EA0", Offset = "0x5384A0", VA = "0x180539EA0", Slot = "5")]
		public void Set(ref AddNotifyFriendsUpdateOptions? other)
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
