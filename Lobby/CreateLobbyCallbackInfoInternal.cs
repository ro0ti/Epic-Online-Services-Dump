using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	internal struct CreateLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateLobbyCallbackInfo>, ISettable<CreateLobbyCallbackInfo>, IDisposable
	{
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0000707C File Offset: 0x0000527C
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006DB")]
		public Result ResultCode
		{
			[Token(Token = "0x60018E1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60018E2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006DC")]
		public object ClientData
		{
			[Token(Token = "0x60018E3")]
			[Address(RVA = "0x508DA0", Offset = "0x5073A0", VA = "0x180508DA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E4")]
			[Address(RVA = "0x508E80", Offset = "0x507480", VA = "0x180508E80")]
			set
			{
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00007094 File Offset: 0x00005294
		[Token(Token = "0x170006DD")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006DE")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x508E10", Offset = "0x507410", VA = "0x180508E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x508EE0", Offset = "0x5074E0", VA = "0x180508EE0")]
			set
			{
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x508CE0", Offset = "0x5072E0", VA = "0x180508CE0", Slot = "6")]
		public void Set(ref CreateLobbyCallbackInfo other)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x508BC0", Offset = "0x5071C0", VA = "0x180508BC0", Slot = "7")]
		public void Set(ref CreateLobbyCallbackInfo? other)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x508B40", Offset = "0x507140", VA = "0x180508B40", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x508BA0", Offset = "0x5071A0", VA = "0x180508BA0", Slot = "5")]
		public void Get(out CreateLobbyCallbackInfo output)
		{
		}

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4000B31")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
