using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	internal struct OnQueryOutputDevicesInformationCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryOutputDevicesInformationCallbackInfo>, ISettable<OnQueryOutputDevicesInformationCallbackInfo>, IDisposable
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000342")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000343")]
		public object ClientData
		{
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x4DB490", Offset = "0x4D9A90", VA = "0x1804DB490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x4DB500", Offset = "0x4D9B00", VA = "0x1804DB500")]
			set
			{
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x17000344")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x4DB430", Offset = "0x4D9A30", VA = "0x1804DB430", Slot = "6")]
		public void Set(ref OnQueryOutputDevicesInformationCallbackInfo other)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x4DB370", Offset = "0x4D9970", VA = "0x1804DB370", Slot = "7")]
		public void Set(ref OnQueryOutputDevicesInformationCallbackInfo? other)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x4DB300", Offset = "0x4D9900", VA = "0x1804DB300", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x4DB350", Offset = "0x4D9950", VA = "0x1804DB350", Slot = "5")]
		public void Get(out OnQueryOutputDevicesInformationCallbackInfo output)
		{
		}

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
