using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	internal struct QueryActivePlayerSanctionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryActivePlayerSanctionsCallbackInfo>, ISettable<QueryActivePlayerSanctionsCallbackInfo>, IDisposable
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0000452C File Offset: 0x0000272C
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D3")]
		public Result ResultCode
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D4")]
		public object ClientData
		{
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x4DF060", Offset = "0x4DD660", VA = "0x1804DF060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x4DF1D0", Offset = "0x4DD7D0", VA = "0x1804DF1D0")]
			set
			{
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x170002D5")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D6")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x4DF150", Offset = "0x4DD750", VA = "0x1804DF150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x4DF290", Offset = "0x4DD890", VA = "0x1804DF290")]
			set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x4DF0D0", Offset = "0x4DD6D0", VA = "0x1804DF0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x4DF230", Offset = "0x4DD830", VA = "0x1804DF230")]
			set
			{
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x4DEF60", Offset = "0x4DD560", VA = "0x1804DEF60", Slot = "6")]
		public void Set(ref QueryActivePlayerSanctionsCallbackInfo other)
		{
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x4DEDE0", Offset = "0x4DD3E0", VA = "0x1804DEDE0", Slot = "7")]
		public void Set(ref QueryActivePlayerSanctionsCallbackInfo? other)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x4DED50", Offset = "0x4DD350", VA = "0x1804DED50", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x4DEDC0", Offset = "0x4DD3C0", VA = "0x1804DEDC0", Slot = "5")]
		public void Get(out QueryActivePlayerSanctionsCallbackInfo output)
		{
		}

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;
	}
}
