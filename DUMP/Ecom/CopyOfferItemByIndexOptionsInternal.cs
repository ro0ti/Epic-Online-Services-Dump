using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	internal struct CopyOfferItemByIndexOptionsInternal : ISettable<CopyOfferItemByIndexOptions>, IDisposable
	{
		// Token: 0x17000A1E RID: 2590
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A1E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x53F4A0", Offset = "0x53DAA0", VA = "0x18053F4A0")]
			set
			{
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A1F")]
		public Utf8String OfferId
		{
			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x53F500", Offset = "0x53DB00", VA = "0x18053F500")]
			set
			{
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A20")]
		public uint ItemIndex
		{
			[Token(Token = "0x60022EA")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x53F2A0", Offset = "0x53D8A0", VA = "0x18053F2A0", Slot = "4")]
		public void Set(ref CopyOfferItemByIndexOptions other)
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x53F370", Offset = "0x53D970", VA = "0x18053F370", Slot = "5")]
		public void Set(ref CopyOfferItemByIndexOptions? other)
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x53F240", Offset = "0x53D840", VA = "0x18053F240", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OfferId;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ItemIndex;
	}
}
