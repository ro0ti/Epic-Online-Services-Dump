using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000704 RID: 1796
	[Token(Token = "0x2000704")]
	internal struct OnClientIntegrityViolatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientIntegrityViolatedCallbackInfo>, ISettable<OnClientIntegrityViolatedCallbackInfo>, IDisposable
	{
		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D9D")]
		public object ClientData
		{
			[Token(Token = "0x6002DD9")]
			[Address(RVA = "0x578070", Offset = "0x576670", VA = "0x180578070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DDA")]
			[Address(RVA = "0x578150", Offset = "0x576750", VA = "0x180578150")]
			set
			{
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x0000BE04 File Offset: 0x0000A004
		[Token(Token = "0x17000D9E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002DDB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x0000BE1C File Offset: 0x0000A01C
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D9F")]
		public AntiCheatClientViolationType ViolationType
		{
			[Token(Token = "0x6002DDC")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			get
			{
				return AntiCheatClientViolationType.Invalid;
			}
			[Token(Token = "0x6002DDD")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA0")]
		public Utf8String ViolationMessage
		{
			[Token(Token = "0x6002DDE")]
			[Address(RVA = "0x5780E0", Offset = "0x5766E0", VA = "0x1805780E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DDF")]
			[Address(RVA = "0x5781B0", Offset = "0x5767B0", VA = "0x1805781B0")]
			set
			{
			}
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x577EA0", Offset = "0x5764A0", VA = "0x180577EA0", Slot = "6")]
		public void Set(ref OnClientIntegrityViolatedCallbackInfo other)
		{
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x577F50", Offset = "0x576550", VA = "0x180577F50", Slot = "7")]
		public void Set(ref OnClientIntegrityViolatedCallbackInfo? other)
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x577E20", Offset = "0x576420", VA = "0x180577E20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x577E80", Offset = "0x576480", VA = "0x180577E80", Slot = "5")]
		public void Get(out OnClientIntegrityViolatedCallbackInfo output)
		{
		}

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04001473 RID: 5235
		[Token(Token = "0x4001473")]
		[FieldOffset(Offset = "0x8")]
		private AntiCheatClientViolationType m_ViolationType;

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ViolationMessage;
	}
}
