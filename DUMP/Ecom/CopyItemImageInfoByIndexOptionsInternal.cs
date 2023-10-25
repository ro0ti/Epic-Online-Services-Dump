using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	internal struct CopyItemImageInfoByIndexOptionsInternal : ISettable<CopyItemImageInfoByIndexOptions>, IDisposable
	{
		// Token: 0x17000A00 RID: 2560
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A00")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022A9")]
			[Address(RVA = "0x53E4B0", Offset = "0x53CAB0", VA = "0x18053E4B0")]
			set
			{
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A01")]
		public Utf8String ItemId
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0x53E450", Offset = "0x53CA50", VA = "0x18053E450")]
			set
			{
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A02")]
		public uint ImageInfoIndex
		{
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x53E250", Offset = "0x53C850", VA = "0x18053E250", Slot = "4")]
		public void Set(ref CopyItemImageInfoByIndexOptions other)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x53E320", Offset = "0x53C920", VA = "0x18053E320", Slot = "5")]
		public void Set(ref CopyItemImageInfoByIndexOptions? other)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x53E1F0", Offset = "0x53C7F0", VA = "0x18053E1F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ImageInfoIndex;
	}
}
