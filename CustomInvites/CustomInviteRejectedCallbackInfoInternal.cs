using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	internal struct CustomInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<CustomInviteRejectedCallbackInfo>, ISettable<CustomInviteRejectedCallbackInfo>, IDisposable
	{
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD2")]
		public object ClientData
		{
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x53FE90", Offset = "0x53E490", VA = "0x18053FE90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x5400E0", Offset = "0x53E6E0", VA = "0x1805400E0")]
			set
			{
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00009A64 File Offset: 0x00007C64
		[Token(Token = "0x17000AD3")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD4")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002530")]
			[Address(RVA = "0x540060", Offset = "0x53E660", VA = "0x180540060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002531")]
			[Address(RVA = "0x540260", Offset = "0x53E860", VA = "0x180540260")]
			set
			{
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002532")]
			[Address(RVA = "0x53FF70", Offset = "0x53E570", VA = "0x18053FF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002533")]
			[Address(RVA = "0x5401A0", Offset = "0x53E7A0", VA = "0x1805401A0")]
			set
			{
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD6")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x6002534")]
			[Address(RVA = "0x53FF00", Offset = "0x53E500", VA = "0x18053FF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002535")]
			[Address(RVA = "0x540140", Offset = "0x53E740", VA = "0x180540140")]
			set
			{
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD7")]
		public Utf8String Payload
		{
			[Token(Token = "0x6002536")]
			[Address(RVA = "0x53FFF0", Offset = "0x53E5F0", VA = "0x18053FFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x540200", Offset = "0x53E800", VA = "0x180540200")]
			set
			{
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x53FD10", Offset = "0x53E310", VA = "0x18053FD10", Slot = "6")]
		public void Set(ref CustomInviteRejectedCallbackInfo other)
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x53FB00", Offset = "0x53E100", VA = "0x18053FB00", Slot = "7")]
		public void Set(ref CustomInviteRejectedCallbackInfo? other)
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x53FA50", Offset = "0x53E050", VA = "0x18053FA50", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x53FAD0", Offset = "0x53E0D0", VA = "0x18053FAD0", Slot = "5")]
		public void Get(out CustomInviteRejectedCallbackInfo output)
		{
		}

		// Token: 0x0400107D RID: 4221
		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CustomInviteId;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Payload;
	}
}
