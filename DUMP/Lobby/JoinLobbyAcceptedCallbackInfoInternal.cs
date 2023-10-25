using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	internal struct JoinLobbyAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyAcceptedCallbackInfo>, ISettable<JoinLobbyAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700072E")]
		public object ClientData
		{
			[Token(Token = "0x6001993")]
			[Address(RVA = "0x50E070", Offset = "0x50C670", VA = "0x18050E070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x50E160", Offset = "0x50C760", VA = "0x18050E160")]
			set
			{
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x000072D4 File Offset: 0x000054D4
		[Token(Token = "0x1700072F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001995")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000730")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x50E0E0", Offset = "0x50C6E0", VA = "0x18050E0E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001997")]
			[Address(RVA = "0x50E1C0", Offset = "0x50C7C0", VA = "0x18050E1C0")]
			set
			{
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x000072EC File Offset: 0x000054EC
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000731")]
		public ulong UiEventId
		{
			[Token(Token = "0x6001998")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001999")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x50DFB0", Offset = "0x50C5B0", VA = "0x18050DFB0", Slot = "6")]
		public void Set(ref JoinLobbyAcceptedCallbackInfo other)
		{
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x50DE90", Offset = "0x50C490", VA = "0x18050DE90", Slot = "7")]
		public void Set(ref JoinLobbyAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600199C")]
		[Address(RVA = "0x50DE10", Offset = "0x50C410", VA = "0x18050DE10", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x50DE70", Offset = "0x50C470", VA = "0x18050DE70", Slot = "5")]
		public void Get(out JoinLobbyAcceptedCallbackInfo output)
		{
		}

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_UiEventId;
	}
}
