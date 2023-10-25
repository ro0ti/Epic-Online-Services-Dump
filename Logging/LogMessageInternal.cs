using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Logging
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	internal struct LogMessageInternal : IGettable<LogMessage>, ISettable<LogMessage>, IDisposable
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B8")]
		public Utf8String Category
		{
			[Token(Token = "0x6001858")]
			[Address(RVA = "0x517BE0", Offset = "0x5161E0", VA = "0x180517BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x517CC0", Offset = "0x5162C0", VA = "0x180517CC0")]
			set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B9")]
		public Utf8String Message
		{
			[Token(Token = "0x600185A")]
			[Address(RVA = "0x517C50", Offset = "0x516250", VA = "0x180517C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x517D20", Offset = "0x516320", VA = "0x180517D20")]
			set
			{
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006BA")]
		public LogLevel Level
		{
			[Token(Token = "0x600185C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return LogLevel.Off;
			}
			[Token(Token = "0x600185D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x517A00", Offset = "0x516000", VA = "0x180517A00", Slot = "5")]
		public void Set(ref LogMessage other)
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x517AC0", Offset = "0x5160C0", VA = "0x180517AC0", Slot = "6")]
		public void Set(ref LogMessage? other)
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x517980", Offset = "0x515F80", VA = "0x180517980", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x5179E0", Offset = "0x515FE0", VA = "0x1805179E0", Slot = "4")]
		public void Get(out LogMessage output)
		{
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_Category;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Message;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x10")]
		private LogLevel m_Level;
	}
}
