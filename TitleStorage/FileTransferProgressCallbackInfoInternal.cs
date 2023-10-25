using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal, IGettable<FileTransferProgressCallbackInfo>, ISettable<FileTransferProgressCallbackInfo>, IDisposable
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000121")]
		public object ClientData
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x4A5960", Offset = "0x4A3F60", VA = "0x1804A5960")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x4A5B00", Offset = "0x4A4100", VA = "0x1804A5B00")]
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x17000122")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000123")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x4A5A70", Offset = "0x4A4070", VA = "0x1804A5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x4A5C00", Offset = "0x4A4200", VA = "0x1804A5C00")]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000124")]
		public Utf8String Filename
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x4A5A00", Offset = "0x4A4000", VA = "0x1804A5A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x4A5BA0", Offset = "0x4A41A0", VA = "0x1804A5BA0")]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000125")]
		public uint BytesTransferred
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000126")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x4A5790", Offset = "0x4A3D90", VA = "0x1804A5790", Slot = "6")]
		public void Set(ref FileTransferProgressCallbackInfo other)
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x4A5830", Offset = "0x4A3E30", VA = "0x1804A5830", Slot = "7")]
		public void Set(ref FileTransferProgressCallbackInfo? other)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x4A5650", Offset = "0x4A3C50", VA = "0x1804A5650", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x4A5770", Offset = "0x4A3D70", VA = "0x1804A5770", Slot = "5")]
		public void Get(out FileTransferProgressCallbackInfo output)
		{
		}

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x18")]
		private uint m_BytesTransferred;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_TotalFileSizeBytes;
	}
}
