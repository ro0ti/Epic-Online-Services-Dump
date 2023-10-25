using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	internal struct SetInputDeviceSettingsOptionsInternal : ISettable<SetInputDeviceSettingsOptions>, IDisposable
	{
		// Token: 0x1700038F RID: 911
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x4E5A40", Offset = "0x4E4040", VA = "0x1804E5A40")]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000390")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x4E5B00", Offset = "0x4E4100", VA = "0x1804E5B00")]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000391")]
		public bool PlatformAEC
		{
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0x4E5AA0", Offset = "0x4E40A0", VA = "0x1804E5AA0")]
			set
			{
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x4E5940", Offset = "0x4E3F40", VA = "0x1804E5940", Slot = "4")]
		public void Set(ref SetInputDeviceSettingsOptions other)
		{
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x4E57E0", Offset = "0x4E3DE0", VA = "0x1804E57E0", Slot = "5")]
		public void Set(ref SetInputDeviceSettingsOptions? other)
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x4E5780", Offset = "0x4E3D80", VA = "0x1804E5780", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RealDeviceId;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x18")]
		private int m_PlatformAEC;
	}
}
