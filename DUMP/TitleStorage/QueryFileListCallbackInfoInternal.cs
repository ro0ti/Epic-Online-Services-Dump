using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileListCallbackInfo>, ISettable<QueryFileListCallbackInfo>, IDisposable
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x000031AC File Offset: 0x000013AC
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000134")]
		public Result ResultCode
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000135")]
		public object ClientData
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x4C1E10", Offset = "0x4C0410", VA = "0x1804C1E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x4C1F00", Offset = "0x4C0500", VA = "0x1804C1F00")]
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x17000136")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000137")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x4C1E80", Offset = "0x4C0480", VA = "0x1804C1E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x4C1F60", Offset = "0x4C0560", VA = "0x1804C1F60")]
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000031DC File Offset: 0x000013DC
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000138")]
		public uint FileCount
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x4C1D40", Offset = "0x4C0340", VA = "0x1804C1D40", Slot = "6")]
		public void Set(ref QueryFileListCallbackInfo other)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x4C1C00", Offset = "0x4C0200", VA = "0x1804C1C00", Slot = "7")]
		public void Set(ref QueryFileListCallbackInfo? other)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x4C1B80", Offset = "0x4C0180", VA = "0x1804C1B80", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x4C1BE0", Offset = "0x4C01E0", VA = "0x1804C1BE0", Slot = "5")]
		public void Get(out QueryFileListCallbackInfo output)
		{
		}

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x18")]
		private uint m_FileCount;
	}
}
