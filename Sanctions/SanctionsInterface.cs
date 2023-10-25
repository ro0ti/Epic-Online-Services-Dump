using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public sealed class SanctionsInterface : Handle
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public SanctionsInterface()
		{
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public SanctionsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x4E46E0", Offset = "0x4E2CE0", VA = "0x1804E46E0")]
		public Result CopyPlayerSanctionByIndex(ref CopyPlayerSanctionByIndexOptions options, out PlayerSanction? outSanction)
		{
			return Result.Success;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x4E4830", Offset = "0x4E2E30", VA = "0x1804E4830")]
		public uint GetPlayerSanctionCount(ref GetPlayerSanctionCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x4E49B0", Offset = "0x4E2FB0", VA = "0x1804E49B0")]
		public void QueryActivePlayerSanctions(ref QueryActivePlayerSanctionsOptions options, object clientData, OnQueryActivePlayerSanctionsCallback completionDelegate)
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x4E4910", Offset = "0x4E2F10", VA = "0x1804E4910")]
		[MonoPInvokeCallback(typeof(OnQueryActivePlayerSanctionsCallbackInternal))]
		internal static void OnQueryActivePlayerSanctionsCallbackInternalImplementation(ref QueryActivePlayerSanctionsCallbackInfoInternal data)
		{
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		public const int CopyplayersanctionbyindexApiLatest = 1;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		public const int GetplayersanctioncountApiLatest = 1;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		public const int PlayersanctionApiLatest = 2;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		public const int QueryactiveplayersanctionsApiLatest = 2;
	}
}
