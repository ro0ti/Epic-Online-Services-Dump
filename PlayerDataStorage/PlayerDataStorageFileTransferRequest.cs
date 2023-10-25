using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public sealed class PlayerDataStorageFileTransferRequest : Handle
	{
		// Token: 0x06001497 RID: 5271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public PlayerDataStorageFileTransferRequest()
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public PlayerDataStorageFileTransferRequest(IntPtr innerHandle)
		{
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x4F8D40", Offset = "0x4F7340", VA = "0x1804F8D40")]
		public Result CancelRequest()
		{
			return Result.Success;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x4F8D50", Offset = "0x4F7350", VA = "0x1804F8D50")]
		public Result GetFileRequestState()
		{
			return Result.Success;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x4F8D60", Offset = "0x4F7360", VA = "0x1804F8D60")]
		public Result GetFilename(out Utf8String outStringBuffer)
		{
			return Result.Success;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x4F8E10", Offset = "0x4F7410", VA = "0x1804F8E10")]
		public void Release()
		{
		}
	}
}
