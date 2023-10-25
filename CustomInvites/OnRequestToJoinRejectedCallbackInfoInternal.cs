using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005CA RID: 1482
	[Token(Token = "0x20005CA")]
	internal struct OnRequestToJoinRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRequestToJoinRejectedCallbackInfo>, ISettable<OnRequestToJoinRejectedCallbackInfo>, IDisposable
	{
		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B00")]
		public object ClientData
		{
			[Token(Token = "0x6002600")]
			[Address(RVA = "0x563480", Offset = "0x561A80", VA = "0x180563480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002601")]
			[Address(RVA = "0x5635F0", Offset = "0x561BF0", VA = "0x1805635F0")]
			set
			{
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x00009C2C File Offset: 0x00007E2C
		[Token(Token = "0x17000B01")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002602")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B02")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002603")]
			[Address(RVA = "0x563570", Offset = "0x561B70", VA = "0x180563570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x5636B0", Offset = "0x561CB0", VA = "0x1805636B0")]
			set
			{
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B03")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x5634F0", Offset = "0x561AF0", VA = "0x1805634F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x563650", Offset = "0x561C50", VA = "0x180563650")]
			set
			{
			}
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x563220", Offset = "0x561820", VA = "0x180563220", Slot = "6")]
		public void Set(ref OnRequestToJoinRejectedCallbackInfo other)
		{
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x563320", Offset = "0x561920", VA = "0x180563320", Slot = "7")]
		public void Set(ref OnRequestToJoinRejectedCallbackInfo? other)
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x5631A0", Offset = "0x5617A0", VA = "0x1805631A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x563200", Offset = "0x561800", VA = "0x180563200", Slot = "5")]
		public void Get(out OnRequestToJoinRejectedCallbackInfo output)
		{
		}

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
