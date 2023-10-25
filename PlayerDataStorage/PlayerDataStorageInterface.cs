using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	public sealed class PlayerDataStorageInterface : Handle
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public PlayerDataStorageInterface()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public PlayerDataStorageInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x4F8E20", Offset = "0x4F7420", VA = "0x1804F8E20")]
		public Result CopyFileMetadataAtIndex(ref CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out FileMetadata? outMetadata)
		{
			return Result.Success;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x4F8F70", Offset = "0x4F7570", VA = "0x1804F8F70")]
		public Result CopyFileMetadataByFilename(ref CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out FileMetadata? outMetadata)
		{
			return Result.Success;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00005DEC File Offset: 0x00003FEC
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x4F9070", Offset = "0x4F7670", VA = "0x1804F9070")]
		public Result DeleteCache(ref DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
		{
			return Result.Success;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x4F9270", Offset = "0x4F7870", VA = "0x1804F9270")]
		public void DeleteFile(ref DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback)
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x4F9440", Offset = "0x4F7A40", VA = "0x1804F9440")]
		public void DuplicateFile(ref DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback)
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x4F9610", Offset = "0x4F7C10", VA = "0x1804F9610")]
		public Result GetFileMetadataCount(ref GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount)
		{
			return Result.Success;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x4FA070", Offset = "0x4F8670", VA = "0x1804FA070")]
		public void QueryFile(ref QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x4F9E70", Offset = "0x4F8470", VA = "0x1804F9E70")]
		public void QueryFileList(ref QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x4FA240", Offset = "0x4F8840", VA = "0x1804FA240")]
		public PlayerDataStorageFileTransferRequest ReadFile(ref ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback)
		{
			return null;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x4FA5A0", Offset = "0x4F8BA0", VA = "0x1804FA5A0")]
		public PlayerDataStorageFileTransferRequest WriteFile(ref WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback)
		{
			return null;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x4F9710", Offset = "0x4F7D10", VA = "0x1804F9710")]
		[MonoPInvokeCallback(typeof(OnDeleteCacheCompleteCallbackInternal))]
		internal static void OnDeleteCacheCompleteCallbackInternalImplementation(ref DeleteCacheCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x4F97B0", Offset = "0x4F7DB0", VA = "0x1804F97B0")]
		[MonoPInvokeCallback(typeof(OnDeleteFileCompleteCallbackInternal))]
		internal static void OnDeleteFileCompleteCallbackInternalImplementation(ref DeleteFileCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x4F9850", Offset = "0x4F7E50", VA = "0x1804F9850")]
		[MonoPInvokeCallback(typeof(OnDuplicateFileCompleteCallbackInternal))]
		internal static void OnDuplicateFileCompleteCallbackInternalImplementation(ref DuplicateFileCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x4F98F0", Offset = "0x4F7EF0", VA = "0x1804F98F0")]
		[MonoPInvokeCallback(typeof(OnFileTransferProgressCallbackInternal))]
		internal static void OnFileTransferProgressCallbackInternalImplementation(ref FileTransferProgressCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x4F9990", Offset = "0x4F7F90", VA = "0x1804F9990")]
		[MonoPInvokeCallback(typeof(OnQueryFileCompleteCallbackInternal))]
		internal static void OnQueryFileCompleteCallbackInternalImplementation(ref QueryFileCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x4F9A30", Offset = "0x4F8030", VA = "0x1804F9A30")]
		[MonoPInvokeCallback(typeof(OnQueryFileListCompleteCallbackInternal))]
		internal static void OnQueryFileListCompleteCallbackInternalImplementation(ref QueryFileListCallbackInfoInternal data)
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x4F9AD0", Offset = "0x4F80D0", VA = "0x1804F9AD0")]
		[MonoPInvokeCallback(typeof(OnReadFileCompleteCallbackInternal))]
		internal static void OnReadFileCompleteCallbackInternalImplementation(ref ReadFileCallbackInfoInternal data)
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x4F9B70", Offset = "0x4F8170", VA = "0x1804F9B70")]
		[MonoPInvokeCallback(typeof(OnReadFileDataCallbackInternal))]
		internal static ReadResult OnReadFileDataCallbackInternalImplementation(ref ReadFileDataCallbackInfoInternal data)
		{
			return (ReadResult)0;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x4F9C50", Offset = "0x4F8250", VA = "0x1804F9C50")]
		[MonoPInvokeCallback(typeof(OnWriteFileCompleteCallbackInternal))]
		internal static void OnWriteFileCompleteCallbackInternalImplementation(ref WriteFileCallbackInfoInternal data)
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x4F9CF0", Offset = "0x4F82F0", VA = "0x1804F9CF0")]
		[MonoPInvokeCallback(typeof(OnWriteFileDataCallbackInternal))]
		internal static WriteResult OnWriteFileDataCallbackInternalImplementation(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten)
		{
			return (WriteResult)0;
		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		public const int CopyfilemetadataatindexApiLatest = 1;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		public const int CopyfilemetadataatindexoptionsApiLatest = 1;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		public const int CopyfilemetadatabyfilenameApiLatest = 1;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		public const int DeletecacheApiLatest = 1;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		public const int DeletecacheoptionsApiLatest = 1;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		public const int DeletefileApiLatest = 1;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		public const int DeletefileoptionsApiLatest = 1;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		public const int DuplicatefileApiLatest = 1;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		public const int DuplicatefileoptionsApiLatest = 1;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		public const int FilemetadataApiLatest = 3;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		public const int FilenameMaxLengthBytes = 64;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		public const int GetfilemetadatacountApiLatest = 1;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		public const int GetfilemetadatacountoptionsApiLatest = 1;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		public const int QueryfileApiLatest = 1;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		public const int QueryfilelistApiLatest = 2;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		public const int QueryfilelistoptionsApiLatest = 2;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		public const int QueryfileoptionsApiLatest = 1;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		public const int ReadfileApiLatest = 1;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		public const int ReadfileoptionsApiLatest = 1;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		public const int TimeUndefined = -1;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		public const int WritefileApiLatest = 1;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		public const int WritefileoptionsApiLatest = 1;
	}
}
