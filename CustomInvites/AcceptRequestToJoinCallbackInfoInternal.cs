using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	internal struct AcceptRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<AcceptRequestToJoinCallbackInfo>, ISettable<AcceptRequestToJoinCallbackInfo>, IDisposable
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x00009A1C File Offset: 0x00007C1C
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC4")]
		public Result ResultCode
		{
			[Token(Token = "0x60024F3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60024F4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC5")]
		public object ClientData
		{
			[Token(Token = "0x60024F5")]
			[Address(RVA = "0x5396D0", Offset = "0x537CD0", VA = "0x1805396D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024F6")]
			[Address(RVA = "0x539840", Offset = "0x537E40", VA = "0x180539840")]
			set
			{
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x00009A34 File Offset: 0x00007C34
		[Token(Token = "0x17000AC6")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60024F7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60024F8")]
			[Address(RVA = "0x539740", Offset = "0x537D40", VA = "0x180539740")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024F9")]
			[Address(RVA = "0x5398A0", Offset = "0x537EA0", VA = "0x1805398A0")]
			set
			{
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC8")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60024FA")]
			[Address(RVA = "0x5397C0", Offset = "0x537DC0", VA = "0x1805397C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024FB")]
			[Address(RVA = "0x539900", Offset = "0x537F00", VA = "0x180539900")]
			set
			{
			}
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x539450", Offset = "0x537A50", VA = "0x180539450", Slot = "6")]
		public void Set(ref AcceptRequestToJoinCallbackInfo other)
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x539550", Offset = "0x537B50", VA = "0x180539550", Slot = "7")]
		public void Set(ref AcceptRequestToJoinCallbackInfo? other)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x5393C0", Offset = "0x5379C0", VA = "0x1805393C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x539430", Offset = "0x537A30", VA = "0x180539430", Slot = "5")]
		public void Get(out AcceptRequestToJoinCallbackInfo output)
		{
		}

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
