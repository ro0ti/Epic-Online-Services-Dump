using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	internal struct LobbySearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbySearchFindCallbackInfo>, ISettable<LobbySearchFindCallbackInfo>, IDisposable
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00007DFC File Offset: 0x00005FFC
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007EE")]
		public Result ResultCode
		{
			[Token(Token = "0x6001BE5")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001BE6")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007EF")]
		public object ClientData
		{
			[Token(Token = "0x6001BE7")]
			[Address(RVA = "0x52B7E0", Offset = "0x529DE0", VA = "0x18052B7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE8")]
			[Address(RVA = "0x52B850", Offset = "0x529E50", VA = "0x18052B850")]
			set
			{
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00007E14 File Offset: 0x00006014
		[Token(Token = "0x170007F0")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001BE9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BEA")]
		[Address(RVA = "0x52B780", Offset = "0x529D80", VA = "0x18052B780", Slot = "6")]
		public void Set(ref LobbySearchFindCallbackInfo other)
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x52B6C0", Offset = "0x529CC0", VA = "0x18052B6C0", Slot = "7")]
		public void Set(ref LobbySearchFindCallbackInfo? other)
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x52B650", Offset = "0x529C50", VA = "0x18052B650", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x52B6A0", Offset = "0x529CA0", VA = "0x18052B6A0", Slot = "5")]
		public void Get(out LobbySearchFindCallbackInfo output)
		{
		}

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
