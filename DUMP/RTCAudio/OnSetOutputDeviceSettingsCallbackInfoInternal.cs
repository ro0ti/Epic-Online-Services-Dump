using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	internal struct OnSetOutputDeviceSettingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnSetOutputDeviceSettingsCallbackInfo>, ISettable<OnSetOutputDeviceSettingsCallbackInfo>, IDisposable
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00004A54 File Offset: 0x00002C54
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000356")]
		public Result ResultCode
		{
			[Token(Token = "0x6000E08")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000E09")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000357")]
		public object ClientData
		{
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x4DC670", Offset = "0x4DAC70", VA = "0x1804DC670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x4DC750", Offset = "0x4DAD50", VA = "0x1804DC750")]
			set
			{
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x17000358")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000359")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x4DC6E0", Offset = "0x4DACE0", VA = "0x1804DC6E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x4DC7B0", Offset = "0x4DADB0", VA = "0x1804DC7B0")]
			set
			{
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x4DC5B0", Offset = "0x4DABB0", VA = "0x1804DC5B0", Slot = "6")]
		public void Set(ref OnSetOutputDeviceSettingsCallbackInfo other)
		{
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x4DC490", Offset = "0x4DAA90", VA = "0x1804DC490", Slot = "7")]
		public void Set(ref OnSetOutputDeviceSettingsCallbackInfo? other)
		{
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x4DC410", Offset = "0x4DAA10", VA = "0x1804DC410", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x4DC470", Offset = "0x4DAA70", VA = "0x1804DC470", Slot = "5")]
		public void Get(out OnSetOutputDeviceSettingsCallbackInfo output)
		{
		}

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RealDeviceId;
	}
}
