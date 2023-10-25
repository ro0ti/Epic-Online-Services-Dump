using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	internal struct AudioOutputDeviceInfoInternal : IGettable<AudioOutputDeviceInfo>, ISettable<AudioOutputDeviceInfo>, IDisposable
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0000479C File Offset: 0x0000299C
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000321")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x4D6E90", Offset = "0x4D5490", VA = "0x1804D6E90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x4D6FD0", Offset = "0x4D55D0", VA = "0x1804D6FD0")]
			set
			{
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000322")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x4D6EF0", Offset = "0x4D54F0", VA = "0x1804D6EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x4D7030", Offset = "0x4D5630", VA = "0x1804D7030")]
			set
			{
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000323")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x4D6F60", Offset = "0x4D5560", VA = "0x1804D6F60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x4D7090", Offset = "0x4D5690", VA = "0x1804D7090")]
			set
			{
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x4D6D90", Offset = "0x4D5390", VA = "0x1804D6D90", Slot = "5")]
		public void Set(ref AudioOutputDeviceInfo other)
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x4D6C30", Offset = "0x4D5230", VA = "0x1804D6C30", Slot = "6")]
		public void Set(ref AudioOutputDeviceInfo? other)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x4D6BB0", Offset = "0x4D51B0", VA = "0x1804D6BB0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x4D6C10", Offset = "0x4D5210", VA = "0x1804D6C10", Slot = "4")]
		public void Get(out AudioOutputDeviceInfo output)
		{
		}

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x4")]
		private int m_DefaultDevice;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DeviceId;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceName;
	}
}
