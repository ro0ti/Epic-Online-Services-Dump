using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065D RID: 1629
	[Token(Token = "0x200065D")]
	internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0000A784 File Offset: 0x00008984
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C24")]
		public Result ResultCode
		{
			[Token(Token = "0x60029BC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60029BD")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C25")]
		public object ClientData
		{
			[Token(Token = "0x60029BE")]
			[Address(RVA = "0x55C680", Offset = "0x55AC80", VA = "0x18055C680")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029BF")]
			[Address(RVA = "0x55C8F0", Offset = "0x55AEF0", VA = "0x18055C8F0")]
			set
			{
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0000A79C File Offset: 0x0000899C
		[Token(Token = "0x17000C26")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60029C0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C27")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029C1")]
			[Address(RVA = "0x55C6F0", Offset = "0x55ACF0", VA = "0x18055C6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029C2")]
			[Address(RVA = "0x55C9B0", Offset = "0x55AFB0", VA = "0x18055C9B0")]
			set
			{
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x0000A7B4 File Offset: 0x000089B4
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C28")]
		public PinGrantInfo? PinGrantInfo
		{
			[Token(Token = "0x60029C3")]
			[Address(RVA = "0x55C7F0", Offset = "0x55ADF0", VA = "0x18055C7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029C4")]
			[Address(RVA = "0x55CA70", Offset = "0x55B070", VA = "0x18055CA70")]
			set
			{
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C29")]
		public EpicAccountId SelectedAccountId
		{
			[Token(Token = "0x60029C5")]
			[Address(RVA = "0x55C870", Offset = "0x55AE70", VA = "0x18055C870")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029C6")]
			[Address(RVA = "0x55CAE0", Offset = "0x55B0E0", VA = "0x18055CAE0")]
			set
			{
			}
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x55C380", Offset = "0x55A980", VA = "0x18055C380", Slot = "6")]
		public void Set(ref LinkAccountCallbackInfo other)
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x55C170", Offset = "0x55A770", VA = "0x18055C170", Slot = "7")]
		public void Set(ref LinkAccountCallbackInfo? other)
		{
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x55BFE0", Offset = "0x55A5E0", VA = "0x18055BFE0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x55C060", Offset = "0x55A660", VA = "0x18055C060", Slot = "5")]
		public void Get(out LinkAccountCallbackInfo output)
		{
		}

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_PinGrantInfo;

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SelectedAccountId;
	}
}
