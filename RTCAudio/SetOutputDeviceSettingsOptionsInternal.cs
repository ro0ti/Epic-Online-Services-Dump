using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	internal struct SetOutputDeviceSettingsOptionsInternal : ISettable<SetOutputDeviceSettingsOptions>, IDisposable
	{
		// Token: 0x17000394 RID: 916
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000394")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x4E5D90", Offset = "0x4E4390", VA = "0x1804E5D90")]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000395")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x4E5DF0", Offset = "0x4E43F0", VA = "0x1804E5DF0")]
			set
			{
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x4E5BC0", Offset = "0x4E41C0", VA = "0x1804E5BC0", Slot = "4")]
		public void Set(ref SetOutputDeviceSettingsOptions other)
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x4E5C80", Offset = "0x4E4280", VA = "0x1804E5C80", Slot = "5")]
		public void Set(ref SetOutputDeviceSettingsOptions? other)
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x4E5B60", Offset = "0x4E4160", VA = "0x1804E5B60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RealDeviceId;
	}
}
