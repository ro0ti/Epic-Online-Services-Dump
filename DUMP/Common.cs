using System;


namespace Epic.OnlineServices
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public sealed class Common
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x49F510", Offset = "0x49DB10", VA = "0x18049F510")]
		public static bool IsOperationComplete(Result result)
		{
			return default(bool);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x49F5F0", Offset = "0x49DBF0", VA = "0x18049F5F0")]
		public static Utf8String ToString(Result result)
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x49F730", Offset = "0x49DD30", VA = "0x18049F730")]
		public static Result ToString(ArraySegment<byte> byteArray, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x49F6C0", Offset = "0x49DCC0", VA = "0x18049F6C0")]
		public static Utf8String ToString(ArraySegment<byte> byteArray)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public Common()
		{
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		public const ulong InvalidNotificationid = 0UL;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String IptUnknown;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		public const int OptEpic = 100;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		public const int OptSteam = 4000;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		public const int OptUnknown = 0;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		public const int PagequeryApiLatest = 1;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		public const int PagequeryMaxcountDefault = 10;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		public const int PagequeryMaxcountMaximum = 100;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		public const int PaginationApiLatest = 1;
	}
}
