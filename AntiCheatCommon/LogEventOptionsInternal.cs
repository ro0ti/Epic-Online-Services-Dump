using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C1 RID: 1729
	[Token(Token = "0x20006C1")]
	internal struct LogEventOptionsInternal : ISettable<LogEventOptions>, IDisposable
	{
		// Token: 0x17000CE5 RID: 3301
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE5")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002C02")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE6")]
		public uint EventId
		{
			[Token(Token = "0x6002C03")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE7")]
		public LogEventParamPair[] Params
		{
			[Token(Token = "0x6002C04")]
			[Address(RVA = "0x571990", Offset = "0x56FF90", VA = "0x180571990")]
			set
			{
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x571970", Offset = "0x56FF70", VA = "0x180571970", Slot = "4")]
		public void Set(ref LogEventOptions other)
		{
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x5718C0", Offset = "0x56FEC0", VA = "0x1805718C0", Slot = "5")]
		public void Set(ref LogEventOptions? other)
		{
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x571860", Offset = "0x56FE60", VA = "0x180571860", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x10")]
		private uint m_EventId;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x14")]
		private uint m_ParamsCount;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Params;
	}
}
