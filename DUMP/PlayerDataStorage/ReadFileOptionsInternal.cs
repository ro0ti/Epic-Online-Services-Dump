using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	internal struct ReadFileOptionsInternal : ISettable<ReadFileOptions>, IDisposable
	{
		// Token: 0x170005A0 RID: 1440
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600152C")]
			[Address(RVA = "0x501520", Offset = "0x4FFB20", VA = "0x180501520")]
			set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A1")]
		public Utf8String Filename
		{
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x5014C0", Offset = "0x4FFAC0", VA = "0x1805014C0")]
			set
			{
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A2")]
		public uint ReadChunkLengthBytes
		{
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x170005A3")]
		public static OnReadFileDataCallbackInternal ReadFileDataCallback
		{
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x501370", Offset = "0x4FF970", VA = "0x180501370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x170005A4")]
		public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x5012B0", Offset = "0x4FF8B0", VA = "0x1805012B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x501130", Offset = "0x4FF730", VA = "0x180501130", Slot = "4")]
		public void Set(ref ReadFileOptions other)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x500F30", Offset = "0x4FF530", VA = "0x180500F30", Slot = "5")]
		public void Set(ref ReadFileOptions? other)
		{
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x500EB0", Offset = "0x4FF4B0", VA = "0x180500EB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ReadChunkLengthBytes;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ReadFileDataCallback;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_FileTransferProgressCallback;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x0")]
		private static OnReadFileDataCallbackInternal s_ReadFileDataCallback;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x8")]
		private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;
	}
}
