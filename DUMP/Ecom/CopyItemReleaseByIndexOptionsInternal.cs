using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	internal struct CopyItemReleaseByIndexOptionsInternal : ISettable<CopyItemReleaseByIndexOptions>, IDisposable
	{
		// Token: 0x17000A06 RID: 2566
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A06")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x53E7D0", Offset = "0x53CDD0", VA = "0x18053E7D0")]
			set
			{
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A07")]
		public Utf8String ItemId
		{
			[Token(Token = "0x60022B6")]
			[Address(RVA = "0x53E770", Offset = "0x53CD70", VA = "0x18053E770")]
			set
			{
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A08")]
		public uint ReleaseIndex
		{
			[Token(Token = "0x60022B7")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x53E6A0", Offset = "0x53CCA0", VA = "0x18053E6A0", Slot = "4")]
		public void Set(ref CopyItemReleaseByIndexOptions other)
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x53E570", Offset = "0x53CB70", VA = "0x18053E570", Slot = "5")]
		public void Set(ref CopyItemReleaseByIndexOptions? other)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x53E510", Offset = "0x53CB10", VA = "0x18053E510", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ReleaseIndex;
	}
}
