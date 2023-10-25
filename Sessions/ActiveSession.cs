using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public sealed class ActiveSession : Handle
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public ActiveSession()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public ActiveSession(IntPtr innerHandle)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x4B8D80", Offset = "0x4B7380", VA = "0x1804B8D80")]
		public Result CopyInfo(ref ActiveSessionCopyInfoOptions options, out ActiveSessionInfo? outActiveSessionInfo)
		{
			return Result.Success;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x4B8E60", Offset = "0x4B7460", VA = "0x1804B8E60")]
		public ProductUserId GetRegisteredPlayerByIndex(ref ActiveSessionGetRegisteredPlayerByIndexOptions options)
		{
			return null;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x4B8F20", Offset = "0x4B7520", VA = "0x1804B8F20")]
		public uint GetRegisteredPlayerCount(ref ActiveSessionGetRegisteredPlayerCountOptions options)
		{
			return 0U;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x4B8FA0", Offset = "0x4B75A0", VA = "0x1804B8FA0")]
		public void Release()
		{
		}

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		public const int ActivesessionCopyinfoApiLatest = 1;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		public const int ActivesessionGetregisteredplayerbyindexApiLatest = 1;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		public const int ActivesessionGetregisteredplayercountApiLatest = 1;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		public const int ActivesessionInfoApiLatest = 1;
	}
}
