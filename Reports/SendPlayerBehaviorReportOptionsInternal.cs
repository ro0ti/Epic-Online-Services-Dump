using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Reports
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	internal struct SendPlayerBehaviorReportOptionsInternal : ISettable<SendPlayerBehaviorReportOptions>, IDisposable
	{
		// Token: 0x170004B4 RID: 1204
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B4")]
		public ProductUserId ReporterUserId
		{
			[Token(Token = "0x6001215")]
			[Address(RVA = "0x502810", Offset = "0x500E10", VA = "0x180502810")]
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B5")]
		public ProductUserId ReportedUserId
		{
			[Token(Token = "0x6001216")]
			[Address(RVA = "0x5027B0", Offset = "0x500DB0", VA = "0x1805027B0")]
			set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B6")]
		public PlayerReportsCategory Category
		{
			[Token(Token = "0x6001217")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B7")]
		public Utf8String Message
		{
			[Token(Token = "0x6001218")]
			[Address(RVA = "0x502750", Offset = "0x500D50", VA = "0x180502750")]
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B8")]
		public Utf8String Context
		{
			[Token(Token = "0x6001219")]
			[Address(RVA = "0x5026F0", Offset = "0x500CF0", VA = "0x1805026F0")]
			set
			{
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x5023D0", Offset = "0x5009D0", VA = "0x1805023D0", Slot = "4")]
		public void Set(ref SendPlayerBehaviorReportOptions other)
		{
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x502520", Offset = "0x500B20", VA = "0x180502520", Slot = "5")]
		public void Set(ref SendPlayerBehaviorReportOptions? other)
		{
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x502350", Offset = "0x500950", VA = "0x180502350", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ReporterUserId;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ReportedUserId;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x18")]
		private PlayerReportsCategory m_Category;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Message;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_Context;
	}
}
