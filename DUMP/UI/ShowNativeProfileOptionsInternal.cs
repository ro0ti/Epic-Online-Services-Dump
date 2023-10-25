using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	internal struct ShowNativeProfileOptionsInternal : ISettable<ShowNativeProfileOptions>, IDisposable
	{
		// Token: 0x170000FD RID: 253
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FD")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x4B1000", Offset = "0x4AF600", VA = "0x1804B1000")]
			set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FE")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x4B10B0", Offset = "0x4AF6B0", VA = "0x1804B10B0")]
			set
			{
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x4B0FC0", Offset = "0x4AF5C0", VA = "0x1804B0FC0", Slot = "4")]
		public void Set(ref ShowNativeProfileOptions other)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x4B0F20", Offset = "0x4AF520", VA = "0x1804B0F20", Slot = "5")]
		public void Set(ref ShowNativeProfileOptions? other)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x4B0E40", Offset = "0x4AF440", VA = "0x1804B0E40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
