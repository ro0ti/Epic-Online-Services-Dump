using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	internal struct InputDeviceInformationInternal : IGettable<InputDeviceInformation>, ISettable<InputDeviceInformation>, IDisposable
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000338")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x4D9AD0", Offset = "0x4D80D0", VA = "0x1804D9AD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x4D9C10", Offset = "0x4D8210", VA = "0x1804D9C10")]
			set
			{
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000339")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x4D9B30", Offset = "0x4D8130", VA = "0x1804D9B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x4D9C70", Offset = "0x4D8270", VA = "0x1804D9C70")]
			set
			{
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700033A")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x4D9BA0", Offset = "0x4D81A0", VA = "0x1804D9BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x4D9CD0", Offset = "0x4D82D0", VA = "0x1804D9CD0")]
			set
			{
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x4D9870", Offset = "0x4D7E70", VA = "0x1804D9870", Slot = "5")]
		public void Set(ref InputDeviceInformation other)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x4D9970", Offset = "0x4D7F70", VA = "0x1804D9970", Slot = "6")]
		public void Set(ref InputDeviceInformation? other)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x4D97F0", Offset = "0x4D7DF0", VA = "0x1804D97F0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x4D9850", Offset = "0x4D7E50", VA = "0x1804D9850", Slot = "4")]
		public void Get(out InputDeviceInformation output)
		{
		}

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x4")]
		private int m_DefaultDevice;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DeviceId;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceName;
	}
}
