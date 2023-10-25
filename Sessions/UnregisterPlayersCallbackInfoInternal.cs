using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	internal struct UnregisterPlayersCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnregisterPlayersCallbackInfo>, ISettable<UnregisterPlayersCallbackInfo>, IDisposable
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x000043F4 File Offset: 0x000025F4
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AC")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AD")]
		public object ClientData
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x4E6FA0", Offset = "0x4E55A0", VA = "0x1804E6FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x4E70A0", Offset = "0x4E56A0", VA = "0x1804E70A0")]
			set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x170002AE")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AF")]
		public ProductUserId[] UnregisteredPlayers
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x4E7010", Offset = "0x4E5610", VA = "0x1804E7010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x4E7100", Offset = "0x4E5700", VA = "0x1804E7100")]
			set
			{
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x4E6E20", Offset = "0x4E5420", VA = "0x1804E6E20", Slot = "6")]
		public void Set(ref UnregisterPlayersCallbackInfo other)
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E54B0", VA = "0x1804E6EB0", Slot = "7")]
		public void Set(ref UnregisterPlayersCallbackInfo? other)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x4E6DA0", Offset = "0x4E53A0", VA = "0x1804E6DA0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x4E6E00", Offset = "0x4E5400", VA = "0x1804E6E00", Slot = "5")]
		public void Get(out UnregisterPlayersCallbackInfo output)
		{
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_UnregisteredPlayers;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x18")]
		private uint m_UnregisteredPlayersCount;
	}
}
