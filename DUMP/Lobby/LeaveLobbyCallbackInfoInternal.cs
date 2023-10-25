using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	internal struct LeaveLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveLobbyCallbackInfo>, ISettable<LeaveLobbyCallbackInfo>, IDisposable
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000074E4 File Offset: 0x000056E4
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000764")]
		public Result ResultCode
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000765")]
		public object ClientData
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0x510590", Offset = "0x50EB90", VA = "0x180510590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x510670", Offset = "0x50EC70", VA = "0x180510670")]
			set
			{
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x000074FC File Offset: 0x000056FC
		[Token(Token = "0x17000766")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000767")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0x510600", Offset = "0x50EC00", VA = "0x180510600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0x5106D0", Offset = "0x50ECD0", VA = "0x1805106D0")]
			set
			{
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x5103B0", Offset = "0x50E9B0", VA = "0x1805103B0", Slot = "6")]
		public void Set(ref LeaveLobbyCallbackInfo other)
		{
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x510470", Offset = "0x50EA70", VA = "0x180510470", Slot = "7")]
		public void Set(ref LeaveLobbyCallbackInfo? other)
		{
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x510330", Offset = "0x50E930", VA = "0x180510330", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x510390", Offset = "0x50E990", VA = "0x180510390", Slot = "5")]
		public void Get(out LeaveLobbyCallbackInfo output)
		{
		}

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
