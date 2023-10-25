using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004F7 RID: 1271
	[Token(Token = "0x20004F7")]
	internal struct AcceptInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<AcceptInviteCallbackInfo>, ISettable<AcceptInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00008C54 File Offset: 0x00006E54
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000946")]
		public Result ResultCode
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000947")]
		public object ClientData
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x538D30", Offset = "0x537330", VA = "0x180538D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x538EA0", Offset = "0x5374A0", VA = "0x180538EA0")]
			set
			{
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x17000948")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000949")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x538DA0", Offset = "0x5373A0", VA = "0x180538DA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x538F00", Offset = "0x537500", VA = "0x180538F00")]
			set
			{
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094A")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x538E20", Offset = "0x537420", VA = "0x180538E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x538F60", Offset = "0x537560", VA = "0x180538F60")]
			set
			{
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x538AB0", Offset = "0x5370B0", VA = "0x180538AB0", Slot = "6")]
		public void Set(ref AcceptInviteCallbackInfo other)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x538BB0", Offset = "0x5371B0", VA = "0x180538BB0", Slot = "7")]
		public void Set(ref AcceptInviteCallbackInfo? other)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x538A20", Offset = "0x537020", VA = "0x180538A20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x538A90", Offset = "0x537090", VA = "0x180538A90", Slot = "5")]
		public void Get(out AcceptInviteCallbackInfo output)
		{
		}

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
