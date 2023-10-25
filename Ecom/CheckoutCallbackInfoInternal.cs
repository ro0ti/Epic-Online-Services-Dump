using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	internal struct CheckoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<CheckoutCallbackInfo>, ISettable<CheckoutCallbackInfo>, IDisposable
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0000926C File Offset: 0x0000746C
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DE")]
		public Result ResultCode
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DF")]
		public object ClientData
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x53CCA0", Offset = "0x53B2A0", VA = "0x18053CCA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x53CE00", Offset = "0x53B400", VA = "0x18053CE00")]
			set
			{
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00009284 File Offset: 0x00007484
		[Token(Token = "0x170009E0")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E1")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x53CD10", Offset = "0x53B310", VA = "0x18053CD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002260")]
			[Address(RVA = "0x53CE60", Offset = "0x53B460", VA = "0x18053CE60")]
			set
			{
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002262 RID: 8802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E2")]
		public Utf8String TransactionId
		{
			[Token(Token = "0x6002261")]
			[Address(RVA = "0x53CD90", Offset = "0x53B390", VA = "0x18053CD90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002262")]
			[Address(RVA = "0x53CEC0", Offset = "0x53B4C0", VA = "0x18053CEC0")]
			set
			{
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x53CA20", Offset = "0x53B020", VA = "0x18053CA20", Slot = "6")]
		public void Set(ref CheckoutCallbackInfo other)
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x53CB20", Offset = "0x53B120", VA = "0x18053CB20", Slot = "7")]
		public void Set(ref CheckoutCallbackInfo? other)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x53C990", Offset = "0x53AF90", VA = "0x18053C990", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x53CA00", Offset = "0x53B000", VA = "0x18053CA00", Slot = "5")]
		public void Get(out CheckoutCallbackInfo output)
		{
		}

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TransactionId;
	}
}
