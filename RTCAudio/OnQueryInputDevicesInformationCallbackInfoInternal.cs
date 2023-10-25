using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	internal struct OnQueryInputDevicesInformationCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryInputDevicesInformationCallbackInfo>, ISettable<OnQueryInputDevicesInformationCallbackInfo>, IDisposable
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700033D")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700033E")]
		public object ClientData
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x4DAF20", Offset = "0x4D9520", VA = "0x1804DAF20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x4DAF90", Offset = "0x4D9590", VA = "0x1804DAF90")]
			set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x1700033F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x4DAE00", Offset = "0x4D9400", VA = "0x1804DAE00", Slot = "6")]
		public void Set(ref OnQueryInputDevicesInformationCallbackInfo other)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x4DAE60", Offset = "0x4D9460", VA = "0x1804DAE60", Slot = "7")]
		public void Set(ref OnQueryInputDevicesInformationCallbackInfo? other)
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x4DAD90", Offset = "0x4D9390", VA = "0x1804DAD90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x4DADE0", Offset = "0x4D93E0", VA = "0x1804DADE0", Slot = "5")]
		public void Get(out OnQueryInputDevicesInformationCallbackInfo output)
		{
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
