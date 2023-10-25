using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	public sealed class TitleStorageFileTransferRequest : Handle
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public TitleStorageFileTransferRequest()
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public TitleStorageFileTransferRequest(IntPtr innerHandle)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4D1BD0", Offset = "0x4D01D0", VA = "0x1804D1BD0")]
		public Result CancelRequest()
		{
			return Result.Success;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4D1BE0", Offset = "0x4D01E0", VA = "0x1804D1BE0")]
		public Result GetFileRequestState()
		{
			return Result.Success;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4D1BF0", Offset = "0x4D01F0", VA = "0x1804D1BF0")]
		public Result GetFilename(out Utf8String outStringBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4D1CA0", Offset = "0x4D02A0", VA = "0x1804D1CA0")]
		public void Release()
		{
		}
	}
}
