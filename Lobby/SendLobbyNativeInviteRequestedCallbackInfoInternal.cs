using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	internal struct SendLobbyNativeInviteRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendLobbyNativeInviteRequestedCallbackInfo>, ISettable<SendLobbyNativeInviteRequestedCallbackInfo>, IDisposable
	{
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084F")]
		public object ClientData
		{
			[Token(Token = "0x6001D99")]
			[Address(RVA = "0x536F40", Offset = "0x535540", VA = "0x180536F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0x537180", Offset = "0x535780", VA = "0x180537180")]
			set
			{
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000081BC File Offset: 0x000063BC
		[Token(Token = "0x17000850")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D9B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000081D4 File Offset: 0x000063D4
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000851")]
		public ulong UiEventId
		{
			[Token(Token = "0x6001D9C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D9D")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000852")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D9E")]
			[Address(RVA = "0x537020", Offset = "0x535620", VA = "0x180537020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9F")]
			[Address(RVA = "0x537240", Offset = "0x535840", VA = "0x180537240")]
			set
			{
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000853")]
		public Utf8String TargetNativeAccountType
		{
			[Token(Token = "0x6001DA0")]
			[Address(RVA = "0x5370A0", Offset = "0x5356A0", VA = "0x1805370A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA1")]
			[Address(RVA = "0x5372A0", Offset = "0x5358A0", VA = "0x1805372A0")]
			set
			{
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000854")]
		public Utf8String TargetUserNativeAccountId
		{
			[Token(Token = "0x6001DA2")]
			[Address(RVA = "0x537110", Offset = "0x535710", VA = "0x180537110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x537300", Offset = "0x535900", VA = "0x180537300")]
			set
			{
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000855")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x536FB0", Offset = "0x5355B0", VA = "0x180536FB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x5371E0", Offset = "0x5357E0", VA = "0x1805371E0")]
			set
			{
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x536B90", Offset = "0x535190", VA = "0x180536B90", Slot = "6")]
		public void Set(ref SendLobbyNativeInviteRequestedCallbackInfo other)
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x536D20", Offset = "0x535320", VA = "0x180536D20", Slot = "7")]
		public void Set(ref SendLobbyNativeInviteRequestedCallbackInfo? other)
		{
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x536AF0", Offset = "0x5350F0", VA = "0x180536AF0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x536B70", Offset = "0x535170", VA = "0x180536B70", Slot = "5")]
		public void Get(out SendLobbyNativeInviteRequestedCallbackInfo output)
		{
		}

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_UiEventId;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetNativeAccountType;

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_TargetUserNativeAccountId;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_LobbyId;
	}
}
