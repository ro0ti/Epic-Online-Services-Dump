using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public sealed class TitleStorageInterface : Handle
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public TitleStorageInterface()
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public TitleStorageInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x4D1CB0", Offset = "0x4D02B0", VA = "0x1804D1CB0")]
		public Result CopyFileMetadataAtIndex(ref CopyFileMetadataAtIndexOptions options, out FileMetadata? outMetadata)
		{
			return Result.Success;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4D1DB0", Offset = "0x4D03B0", VA = "0x1804D1DB0")]
		public Result CopyFileMetadataByFilename(ref CopyFileMetadataByFilenameOptions options, out FileMetadata? outMetadata)
		{
			return Result.Success;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x4D1EB0", Offset = "0x4D04B0", VA = "0x1804D1EB0")]
		public Result DeleteCache(ref DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
		{
			return Result.Success;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x4D2070", Offset = "0x4D0670", VA = "0x1804D2070")]
		public uint GetFileMetadataCount(ref GetFileMetadataCountOptions options)
		{
			return 0U;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4D2770", Offset = "0x4D0D70", VA = "0x1804D2770")]
		public void QueryFile(ref QueryFileOptions options, object clientData, OnQueryFileCompleteCallback completionCallback)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x4D2510", Offset = "0x4D0B10", VA = "0x1804D2510")]
		public void QueryFileList(ref QueryFileListOptions options, object clientData, OnQueryFileListCompleteCallback completionCallback)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x4D2940", Offset = "0x4D0F40", VA = "0x1804D2940")]
		public TitleStorageFileTransferRequest ReadFile(ref ReadFileOptions options, object clientData, OnReadFileCompleteCallback completionCallback)
		{
			return null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x4D2110", Offset = "0x4D0710", VA = "0x1804D2110")]
		[MonoPInvokeCallback(typeof(OnDeleteCacheCompleteCallbackInternal))]
		internal static void OnDeleteCacheCompleteCallbackInternalImplementation(ref DeleteCacheCallbackInfoInternal data)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4D21B0", Offset = "0x4D07B0", VA = "0x1804D21B0")]
		[MonoPInvokeCallback(typeof(OnFileTransferProgressCallbackInternal))]
		internal static void OnFileTransferProgressCallbackInternalImplementation(ref FileTransferProgressCallbackInfoInternal data)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4D2250", Offset = "0x4D0850", VA = "0x1804D2250")]
		[MonoPInvokeCallback(typeof(OnQueryFileCompleteCallbackInternal))]
		internal static void OnQueryFileCompleteCallbackInternalImplementation(ref QueryFileCallbackInfoInternal data)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4D22F0", Offset = "0x4D08F0", VA = "0x1804D22F0")]
		[MonoPInvokeCallback(typeof(OnQueryFileListCompleteCallbackInternal))]
		internal static void OnQueryFileListCompleteCallbackInternalImplementation(ref QueryFileListCallbackInfoInternal data)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4D2390", Offset = "0x4D0990", VA = "0x1804D2390")]
		[MonoPInvokeCallback(typeof(OnReadFileCompleteCallbackInternal))]
		internal static void OnReadFileCompleteCallbackInternalImplementation(ref ReadFileCallbackInfoInternal data)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4D2430", Offset = "0x4D0A30", VA = "0x1804D2430")]
		[MonoPInvokeCallback(typeof(OnReadFileDataCallbackInternal))]
		internal static ReadResult OnReadFileDataCallbackInternalImplementation(ref ReadFileDataCallbackInfoInternal data)
		{
			return (ReadResult)0;
		}

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		public const int CopyfilemetadataatindexApiLatest = 1;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		public const int CopyfilemetadataatindexoptionsApiLatest = 1;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		public const int CopyfilemetadatabyfilenameApiLatest = 1;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		public const int DeletecacheApiLatest = 1;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		public const int DeletecacheoptionsApiLatest = 1;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		public const int FilemetadataApiLatest = 2;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		public const int FilenameMaxLengthBytes = 64;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		public const int GetfilemetadatacountApiLatest = 1;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		public const int GetfilemetadatacountoptionsApiLatest = 1;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		public const int QueryfileApiLatest = 1;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		public const int QueryfilelistApiLatest = 1;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const int QueryfilelistoptionsApiLatest = 1;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		public const int QueryfileoptionsApiLatest = 1;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		public const int ReadfileApiLatest = 1;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		public const int ReadfileoptionsApiLatest = 1;
	}
}
