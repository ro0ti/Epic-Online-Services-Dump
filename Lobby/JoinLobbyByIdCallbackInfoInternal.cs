using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CE RID: 974
	[Token(Token = "0x20003CE")]
	internal struct JoinLobbyByIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyByIdCallbackInfo>, ISettable<JoinLobbyByIdCallbackInfo>, IDisposable
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00007334 File Offset: 0x00005534
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000735")]
		public Result ResultCode
		{
			[Token(Token = "0x60019A6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60019A7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000736")]
		public object ClientData
		{
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0x50E530", Offset = "0x50CB30", VA = "0x18050E530")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x50E610", Offset = "0x50CC10", VA = "0x18050E610")]
			set
			{
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0000734C File Offset: 0x0000554C
		[Token(Token = "0x17000737")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60019AA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000738")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019AB")]
			[Address(RVA = "0x50E5A0", Offset = "0x50CBA0", VA = "0x18050E5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019AC")]
			[Address(RVA = "0x50E670", Offset = "0x50CC70", VA = "0x18050E670")]
			set
			{
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x50E470", Offset = "0x50CA70", VA = "0x18050E470", Slot = "6")]
		public void Set(ref JoinLobbyByIdCallbackInfo other)
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x50E350", Offset = "0x50C950", VA = "0x18050E350", Slot = "7")]
		public void Set(ref JoinLobbyByIdCallbackInfo? other)
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x50E2D0", Offset = "0x50C8D0", VA = "0x18050E2D0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x50E330", Offset = "0x50C930", VA = "0x18050E330", Slot = "5")]
		public void Get(out JoinLobbyByIdCallbackInfo output)
		{
		}

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000B91 RID: 2961
		[Token(Token = "0x4000B91")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
