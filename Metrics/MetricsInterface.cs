using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Metrics
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public sealed class MetricsInterface : Handle
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public MetricsInterface()
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public MetricsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x5180B0", Offset = "0x5166B0", VA = "0x1805180B0")]
		public Result BeginPlayerSession(ref BeginPlayerSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x518150", Offset = "0x516750", VA = "0x180518150")]
		public Result EndPlayerSession(ref EndPlayerSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		public const int BeginplayersessionApiLatest = 1;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		public const int EndplayersessionApiLatest = 1;
	}
}
