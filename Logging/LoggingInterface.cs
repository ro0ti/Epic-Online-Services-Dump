using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Logging
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public sealed class LoggingInterface
	{
		// Token: 0x0600184D RID: 6221 RVA: 0x00006E24 File Offset: 0x00005024
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x517F50", Offset = "0x516550", VA = "0x180517F50")]
		public static Result SetCallback(LogMessageFunc callback)
		{
			return Result.Success;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x5180A0", Offset = "0x5166A0", VA = "0x1805180A0")]
		public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
		{
			return Result.Success;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x517E70", Offset = "0x516470", VA = "0x180517E70")]
		[MonoPInvokeCallback(typeof(LogMessageFuncInternal))]
		internal static void LogMessageFuncInternalImplementation(ref LogMessageInternal message)
		{
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public LoggingInterface()
		{
		}
	}
}
