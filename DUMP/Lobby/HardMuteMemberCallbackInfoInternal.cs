using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	internal struct HardMuteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<HardMuteMemberCallbackInfo>, ISettable<HardMuteMemberCallbackInfo>, IDisposable
	{
		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0000725C File Offset: 0x0000545C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700071A")]
		public Result ResultCode
		{
			[Token(Token = "0x6001966")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001967")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700071B")]
		public object ClientData
		{
			[Token(Token = "0x6001968")]
			[Address(RVA = "0x50C590", Offset = "0x50AB90", VA = "0x18050C590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001969")]
			[Address(RVA = "0x50C6F0", Offset = "0x50ACF0", VA = "0x18050C6F0")]
			set
			{
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00007274 File Offset: 0x00005474
		[Token(Token = "0x1700071C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600196A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700071D")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x600196B")]
			[Address(RVA = "0x50C600", Offset = "0x50AC00", VA = "0x18050C600")]
			get
			{
				return null;
			}
			[Token(Token = "0x600196C")]
			[Address(RVA = "0x50C750", Offset = "0x50AD50", VA = "0x18050C750")]
			set
			{
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700071E")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x50C670", Offset = "0x50AC70", VA = "0x18050C670")]
			get
			{
				return null;
			}
			[Token(Token = "0x600196E")]
			[Address(RVA = "0x50C7B0", Offset = "0x50ADB0", VA = "0x18050C7B0")]
			set
			{
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x50C310", Offset = "0x50A910", VA = "0x18050C310", Slot = "6")]
		public void Set(ref HardMuteMemberCallbackInfo other)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x50C410", Offset = "0x50AA10", VA = "0x18050C410", Slot = "7")]
		public void Set(ref HardMuteMemberCallbackInfo? other)
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x50C280", Offset = "0x50A880", VA = "0x18050C280", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x50C2F0", Offset = "0x50A8F0", VA = "0x18050C2F0", Slot = "5")]
		public void Get(out HardMuteMemberCallbackInfo output)
		{
		}

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
