using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	internal struct OnCustomInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCustomInviteReceivedCallbackInfo>, ISettable<OnCustomInviteReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF0")]
		public object ClientData
		{
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x561330", Offset = "0x55F930", VA = "0x180561330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x561580", Offset = "0x55FB80", VA = "0x180561580")]
			set
			{
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00009BCC File Offset: 0x00007DCC
		[Token(Token = "0x17000AF1")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF2")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x561500", Offset = "0x55FB00", VA = "0x180561500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0x561700", Offset = "0x55FD00", VA = "0x180561700")]
			set
			{
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60025B3")]
			[Address(RVA = "0x561410", Offset = "0x55FA10", VA = "0x180561410")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x561640", Offset = "0x55FC40", VA = "0x180561640")]
			set
			{
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF4")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x60025B5")]
			[Address(RVA = "0x5613A0", Offset = "0x55F9A0", VA = "0x1805613A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025B6")]
			[Address(RVA = "0x5615E0", Offset = "0x55FBE0", VA = "0x1805615E0")]
			set
			{
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF5")]
		public Utf8String Payload
		{
			[Token(Token = "0x60025B7")]
			[Address(RVA = "0x561490", Offset = "0x55FA90", VA = "0x180561490")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025B8")]
			[Address(RVA = "0x5616A0", Offset = "0x55FCA0", VA = "0x1805616A0")]
			set
			{
			}
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x560FA0", Offset = "0x55F5A0", VA = "0x180560FA0", Slot = "6")]
		public void Set(ref OnCustomInviteReceivedCallbackInfo other)
		{
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x561120", Offset = "0x55F720", VA = "0x180561120", Slot = "7")]
		public void Set(ref OnCustomInviteReceivedCallbackInfo? other)
		{
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x560EF0", Offset = "0x55F4F0", VA = "0x180560EF0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x560F70", Offset = "0x55F570", VA = "0x180560F70", Slot = "5")]
		public void Get(out OnCustomInviteReceivedCallbackInfo output)
		{
		}

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CustomInviteId;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Payload;
	}
}
