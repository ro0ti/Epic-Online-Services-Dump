using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	internal struct OnQueryNATTypeCompleteInfoInternal : ICallbackInfoInternal, IGettable<OnQueryNATTypeCompleteInfo>, ISettable<OnQueryNATTypeCompleteInfo>, IDisposable
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700061A")]
		public Result ResultCode
		{
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600167A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700061B")]
		public object ClientData
		{
			[Token(Token = "0x600167B")]
			[Address(RVA = "0x51C2F0", Offset = "0x51A8F0", VA = "0x18051C2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600167C")]
			[Address(RVA = "0x51C360", Offset = "0x51A960", VA = "0x18051C360")]
			set
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x1700061C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600167D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x0000650C File Offset: 0x0000470C
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700061D")]
		public NATType NATType
		{
			[Token(Token = "0x600167E")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return NATType.Unknown;
			}
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x51C180", Offset = "0x51A780", VA = "0x18051C180", Slot = "6")]
		public void Set(ref OnQueryNATTypeCompleteInfo other)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x51C200", Offset = "0x51A800", VA = "0x18051C200", Slot = "7")]
		public void Set(ref OnQueryNATTypeCompleteInfo? other)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x51C110", Offset = "0x51A710", VA = "0x18051C110", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x51C160", Offset = "0x51A760", VA = "0x18051C160", Slot = "5")]
		public void Get(out OnQueryNATTypeCompleteInfo output)
		{
		}

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x10")]
		private NATType m_NATType;
	}
}
