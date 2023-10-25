using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal, IGettable<FileTransferProgressCallbackInfo>, ISettable<FileTransferProgressCallbackInfo>, IDisposable
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000567")]
		public object ClientData
		{
			[Token(Token = "0x6001432")]
			[Address(RVA = "0x4F1A70", Offset = "0x4F0070", VA = "0x1804F1A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x4F1BD0", Offset = "0x4F01D0", VA = "0x1804F1BD0")]
			set
			{
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x17000568")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001434")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000569")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x4F1B50", Offset = "0x4F0150", VA = "0x1804F1B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001436")]
			[Address(RVA = "0x4F1C90", Offset = "0x4F0290", VA = "0x1804F1C90")]
			set
			{
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700056A")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001437")]
			[Address(RVA = "0x4F1AE0", Offset = "0x4F00E0", VA = "0x1804F1AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x4F1C30", Offset = "0x4F0230", VA = "0x1804F1C30")]
			set
			{
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00005D44 File Offset: 0x00003F44
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700056B")]
		public uint BytesTransferred
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00005D5C File Offset: 0x00003F5C
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700056C")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x4F17C0", Offset = "0x4EFDC0", VA = "0x1804F17C0", Slot = "6")]
		public void Set(ref FileTransferProgressCallbackInfo other)
		{
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x4F18D0", Offset = "0x4EFED0", VA = "0x1804F18D0", Slot = "7")]
		public void Set(ref FileTransferProgressCallbackInfo? other)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x4F1740", Offset = "0x4EFD40", VA = "0x1804F1740", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x4F17A0", Offset = "0x4EFDA0", VA = "0x1804F17A0", Slot = "5")]
		public void Get(out FileTransferProgressCallbackInfo output)
		{
		}

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x18")]
		private uint m_BytesTransferred;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_TotalFileSizeBytes;
	}
}
