using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	internal struct SendInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendInviteCallbackInfo>, ISettable<SendInviteCallbackInfo>, IDisposable
	{
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700098D")]
		public Result ResultCode
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700098E")]
		public object ClientData
		{
			[Token(Token = "0x60021A5")]
			[Address(RVA = "0x550770", Offset = "0x54ED70", VA = "0x180550770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x5508E0", Offset = "0x54EEE0", VA = "0x1805508E0")]
			set
			{
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00008F24 File Offset: 0x00007124
		[Token(Token = "0x1700098F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60021A7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000990")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60021A8")]
			[Address(RVA = "0x5507E0", Offset = "0x54EDE0", VA = "0x1805507E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021A9")]
			[Address(RVA = "0x550940", Offset = "0x54EF40", VA = "0x180550940")]
			set
			{
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000991")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60021AA")]
			[Address(RVA = "0x550860", Offset = "0x54EE60", VA = "0x180550860")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021AB")]
			[Address(RVA = "0x5509A0", Offset = "0x54EFA0", VA = "0x1805509A0")]
			set
			{
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x5504F0", Offset = "0x54EAF0", VA = "0x1805504F0", Slot = "6")]
		public void Set(ref SendInviteCallbackInfo other)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x5505F0", Offset = "0x54EBF0", VA = "0x1805505F0", Slot = "7")]
		public void Set(ref SendInviteCallbackInfo? other)
		{
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x550460", Offset = "0x54EA60", VA = "0x180550460", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x5504D0", Offset = "0x54EAD0", VA = "0x1805504D0", Slot = "5")]
		public void Get(out SendInviteCallbackInfo output)
		{
		}

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
