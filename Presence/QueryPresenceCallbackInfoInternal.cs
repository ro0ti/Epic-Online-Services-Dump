using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	internal struct QueryPresenceCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryPresenceCallbackInfo>, ISettable<QueryPresenceCallbackInfo>, IDisposable
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00005A8C File Offset: 0x00003C8C
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700051B")]
		public Result ResultCode
		{
			[Token(Token = "0x600136D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600136E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700051C")]
		public object ClientData
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x4FE490", Offset = "0x4FCA90", VA = "0x1804FE490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001370")]
			[Address(RVA = "0x4FE600", Offset = "0x4FCC00", VA = "0x1804FE600")]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x1700051D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001371")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700051E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001372")]
			[Address(RVA = "0x4FE500", Offset = "0x4FCB00", VA = "0x1804FE500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001373")]
			[Address(RVA = "0x4FE660", Offset = "0x4FCC60", VA = "0x1804FE660")]
			set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700051F")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6001374")]
			[Address(RVA = "0x4FE580", Offset = "0x4FCB80", VA = "0x1804FE580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x4FE6C0", Offset = "0x4FCCC0", VA = "0x1804FE6C0")]
			set
			{
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x4FE390", Offset = "0x4FC990", VA = "0x1804FE390", Slot = "6")]
		public void Set(ref QueryPresenceCallbackInfo other)
		{
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x4FE210", Offset = "0x4FC810", VA = "0x1804FE210", Slot = "7")]
		public void Set(ref QueryPresenceCallbackInfo? other)
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x4FE180", Offset = "0x4FC780", VA = "0x1804FE180", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x4FE1F0", Offset = "0x4FC7F0", VA = "0x1804FE1F0", Slot = "5")]
		public void Get(out QueryPresenceCallbackInfo output)
		{
		}

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
