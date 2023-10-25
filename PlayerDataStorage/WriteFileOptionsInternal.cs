using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	internal struct WriteFileOptionsInternal : ISettable<WriteFileOptions>, IDisposable
	{
		// Token: 0x170005BC RID: 1468
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005BC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600156C")]
			[Address(RVA = "0x505150", Offset = "0x503750", VA = "0x180505150")]
			set
			{
			}
		}

		// Token: 0x170005BD RID: 1469
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005BD")]
		public Utf8String Filename
		{
			[Token(Token = "0x600156D")]
			[Address(RVA = "0x5050F0", Offset = "0x5036F0", VA = "0x1805050F0")]
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005BE")]
		public uint ChunkLengthBytes
		{
			[Token(Token = "0x600156E")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x170005BF")]
		public static OnWriteFileDataCallbackInternal WriteFileDataCallback
		{
			[Token(Token = "0x600156F")]
			[Address(RVA = "0x504FA0", Offset = "0x5035A0", VA = "0x180504FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x170005C0")]
		public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
		{
			[Token(Token = "0x6001570")]
			[Address(RVA = "0x504EE0", Offset = "0x5034E0", VA = "0x180504EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x504B60", Offset = "0x503160", VA = "0x180504B60", Slot = "4")]
		public void Set(ref WriteFileOptions other)
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x504CE0", Offset = "0x5032E0", VA = "0x180504CE0", Slot = "5")]
		public void Set(ref WriteFileOptions? other)
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x504AE0", Offset = "0x5030E0", VA = "0x180504AE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ChunkLengthBytes;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_WriteFileDataCallback;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_FileTransferProgressCallback;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x0")]
		private static OnWriteFileDataCallbackInternal s_WriteFileDataCallback;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x8")]
		private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;
	}
}
