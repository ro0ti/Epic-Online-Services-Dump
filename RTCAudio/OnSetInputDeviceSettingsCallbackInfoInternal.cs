using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	internal struct OnSetInputDeviceSettingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnSetInputDeviceSettingsCallbackInfo>, ISettable<OnSetInputDeviceSettingsCallbackInfo>, IDisposable
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x000049F4 File Offset: 0x00002BF4
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700034F")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000350")]
		public object ClientData
		{
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x4DC010", Offset = "0x4DA610", VA = "0x1804DC010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x4DC0F0", Offset = "0x4DA6F0", VA = "0x1804DC0F0")]
			set
			{
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x17000351")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000352")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x4DC080", Offset = "0x4DA680", VA = "0x1804DC080")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x4DC150", Offset = "0x4DA750", VA = "0x1804DC150")]
			set
			{
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x4DBF50", Offset = "0x4DA550", VA = "0x1804DBF50", Slot = "6")]
		public void Set(ref OnSetInputDeviceSettingsCallbackInfo other)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x4DBE30", Offset = "0x4DA430", VA = "0x1804DBE30", Slot = "7")]
		public void Set(ref OnSetInputDeviceSettingsCallbackInfo? other)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x4DBDB0", Offset = "0x4DA3B0", VA = "0x1804DBDB0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x4DBE10", Offset = "0x4DA410", VA = "0x1804DBE10", Slot = "5")]
		public void Get(out OnSetInputDeviceSettingsCallbackInfo output)
		{
		}

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RealDeviceId;
	}
}
