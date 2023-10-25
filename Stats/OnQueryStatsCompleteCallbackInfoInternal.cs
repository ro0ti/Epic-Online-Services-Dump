using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	internal struct OnQueryStatsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryStatsCompleteCallbackInfo>, ISettable<OnQueryStatsCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000182")]
		public Result ResultCode
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000183")]
		public object ClientData
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x4C0340", Offset = "0x4BE940", VA = "0x1804C0340")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x4C04B0", Offset = "0x4BEAB0", VA = "0x1804C04B0")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x17000184")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000185")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x4C03B0", Offset = "0x4BE9B0", VA = "0x1804C03B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x4C0510", Offset = "0x4BEB10", VA = "0x1804C0510")]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000186")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x4C0430", Offset = "0x4BEA30", VA = "0x1804C0430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x4C0570", Offset = "0x4BEB70", VA = "0x1804C0570")]
			set
			{
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4C0240", Offset = "0x4BE840", VA = "0x1804C0240", Slot = "6")]
		public void Set(ref OnQueryStatsCompleteCallbackInfo other)
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x4C00C0", Offset = "0x4BE6C0", VA = "0x1804C00C0", Slot = "7")]
		public void Set(ref OnQueryStatsCompleteCallbackInfo? other)
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x4C0030", Offset = "0x4BE630", VA = "0x1804C0030", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x4C00A0", Offset = "0x4BE6A0", VA = "0x1804C00A0", Slot = "5")]
		public void Get(out OnQueryStatsCompleteCallbackInfo output)
		{
		}

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
