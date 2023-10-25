using System;


namespace Epic.OnlineServices.Reports
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	public sealed class ReportsInterface : Handle
	{
		// Token: 0x060011F8 RID: 4600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public ReportsInterface()
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public ReportsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x501620", Offset = "0x4FFC20", VA = "0x180501620")]
		public void SendPlayerBehaviorReport(ref SendPlayerBehaviorReportOptions options, object clientData, OnSendPlayerBehaviorReportCompleteCallback completionDelegate)
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x501580", Offset = "0x4FFB80", VA = "0x180501580")]
		[MonoPInvokeCallback(typeof(OnSendPlayerBehaviorReportCompleteCallbackInternal))]
		internal static void OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		public const int ReportcontextMaxLength = 4096;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		public const int ReportmessageMaxLength = 512;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		public const int SendplayerbehaviorreportApiLatest = 2;
	}
}
