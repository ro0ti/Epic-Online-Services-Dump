using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	internal struct ReadFileOptionsInternal : ISettable<ReadFileOptions>, IDisposable
	{
		// Token: 0x1700015C RID: 348
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x4C4D00", Offset = "0x4C3300", VA = "0x1804C4D00")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015D")]
		public Utf8String Filename
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x4C4CA0", Offset = "0x4C32A0", VA = "0x1804C4CA0")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015E")]
		public uint ReadChunkLengthBytes
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x1700015F")]
		public static OnReadFileDataCallbackInternal ReadFileDataCallback
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x4C4B50", Offset = "0x4C3150", VA = "0x1804C4B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x17000160")]
		public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x4C49F0", Offset = "0x4C2FF0", VA = "0x1804C49F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x4C4870", Offset = "0x4C2E70", VA = "0x1804C4870", Slot = "4")]
		public void Set(ref ReadFileOptions other)
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4C4670", Offset = "0x4C2C70", VA = "0x1804C4670", Slot = "5")]
		public void Set(ref ReadFileOptions? other)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4C45F0", Offset = "0x4C2BF0", VA = "0x1804C45F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ReadChunkLengthBytes;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ReadFileDataCallback;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_FileTransferProgressCallback;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x0")]
		private static OnReadFileDataCallbackInternal s_ReadFileDataCallback;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x8")]
		private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;
	}
}
