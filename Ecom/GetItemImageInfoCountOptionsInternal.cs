using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	internal struct GetItemImageInfoCountOptionsInternal : ISettable<GetItemImageInfoCountOptions>, IDisposable
	{
		// Token: 0x17000A3D RID: 2621
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002358")]
			[Address(RVA = "0x547520", Offset = "0x545B20", VA = "0x180547520")]
			set
			{
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3E")]
		public Utf8String ItemId
		{
			[Token(Token = "0x6002359")]
			[Address(RVA = "0x5474C0", Offset = "0x545AC0", VA = "0x1805474C0")]
			set
			{
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x547400", Offset = "0x545A00", VA = "0x180547400", Slot = "4")]
		public void Set(ref GetItemImageInfoCountOptions other)
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x5472F0", Offset = "0x5458F0", VA = "0x1805472F0", Slot = "5")]
		public void Set(ref GetItemImageInfoCountOptions? other)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x547290", Offset = "0x545890", VA = "0x180547290", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;
	}
}
