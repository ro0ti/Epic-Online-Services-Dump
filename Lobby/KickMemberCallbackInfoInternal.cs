using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D6 RID: 982
	[Token(Token = "0x20003D6")]
	internal struct KickMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<KickMemberCallbackInfo>, ISettable<KickMemberCallbackInfo>, IDisposable
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00007484 File Offset: 0x00005684
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000757")]
		public Result ResultCode
		{
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60019F1")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000758")]
		public object ClientData
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x50FC60", Offset = "0x50E260", VA = "0x18050FC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x50FD40", Offset = "0x50E340", VA = "0x18050FD40")]
			set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0000749C File Offset: 0x0000569C
		[Token(Token = "0x17000759")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075A")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x50FCD0", Offset = "0x50E2D0", VA = "0x18050FCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x50FDA0", Offset = "0x50E3A0", VA = "0x18050FDA0")]
			set
			{
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x50FA80", Offset = "0x50E080", VA = "0x18050FA80", Slot = "6")]
		public void Set(ref KickMemberCallbackInfo other)
		{
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x50FB40", Offset = "0x50E140", VA = "0x18050FB40", Slot = "7")]
		public void Set(ref KickMemberCallbackInfo? other)
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x50FA00", Offset = "0x50E000", VA = "0x18050FA00", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x50FA60", Offset = "0x50E060", VA = "0x18050FA60", Slot = "5")]
		public void Get(out KickMemberCallbackInfo output)
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
