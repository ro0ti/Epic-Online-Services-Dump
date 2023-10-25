using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	public sealed class Transaction : Handle
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public Transaction()
		{
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public Transaction(IntPtr innerHandle)
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0000998C File Offset: 0x00007B8C
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x551570", Offset = "0x54FB70", VA = "0x180551570")]
		public Result CopyEntitlementByIndex(ref TransactionCopyEntitlementByIndexOptions options, out Entitlement? outEntitlement)
		{
			return Result.Success;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000099A4 File Offset: 0x00007BA4
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x551660", Offset = "0x54FC60", VA = "0x180551660")]
		public uint GetEntitlementsCount(ref TransactionGetEntitlementsCountOptions options)
		{
			return 0U;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000099BC File Offset: 0x00007BBC
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x5516E0", Offset = "0x54FCE0", VA = "0x1805516E0")]
		public Result GetTransactionId(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x551780", Offset = "0x54FD80", VA = "0x180551780")]
		public void Release()
		{
		}

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		public const int TransactionCopyentitlementbyindexApiLatest = 1;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		public const int TransactionGetentitlementscountApiLatest = 1;
	}
}
