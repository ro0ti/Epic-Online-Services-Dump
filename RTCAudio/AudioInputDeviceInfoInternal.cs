using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	internal struct AudioInputDeviceInfoInternal : IGettable<AudioInputDeviceInfo>, ISettable<AudioInputDeviceInfo>, IDisposable
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000312")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x4D6180", Offset = "0x4D4780", VA = "0x1804D6180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x4D62C0", Offset = "0x4D48C0", VA = "0x1804D62C0")]
			set
			{
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000313")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x4D61E0", Offset = "0x4D47E0", VA = "0x1804D61E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x4D6320", Offset = "0x4D4920", VA = "0x1804D6320")]
			set
			{
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000314")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x4D6250", Offset = "0x4D4850", VA = "0x1804D6250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x4D6380", Offset = "0x4D4980", VA = "0x1804D6380")]
			set
			{
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x4D6080", Offset = "0x4D4680", VA = "0x1804D6080", Slot = "5")]
		public void Set(ref AudioInputDeviceInfo other)
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x4D5F20", Offset = "0x4D4520", VA = "0x1804D5F20", Slot = "6")]
		public void Set(ref AudioInputDeviceInfo? other)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x4D5EA0", Offset = "0x4D44A0", VA = "0x1804D5EA0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x4D5F00", Offset = "0x4D4500", VA = "0x1804D5F00", Slot = "4")]
		public void Get(out AudioInputDeviceInfo output)
		{
		}

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x4")]
		private int m_DefaultDevice;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DeviceId;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceName;
	}
}
