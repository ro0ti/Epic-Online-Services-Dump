using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	internal struct SetAudioInputSettingsOptionsInternal : ISettable<SetAudioInputSettingsOptions>, IDisposable
	{
		// Token: 0x17000382 RID: 898
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000382")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x4E5380", Offset = "0x4E3980", VA = "0x1804E5380")]
			set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000383")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x4E5320", Offset = "0x4E3920", VA = "0x1804E5320")]
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000384")]
		public float Volume
		{
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000385")]
		public bool PlatformAEC
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x4E53E0", Offset = "0x4E39E0", VA = "0x1804E53E0")]
			set
			{
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x4E5080", Offset = "0x4E3680", VA = "0x1804E5080", Slot = "4")]
		public void Set(ref SetAudioInputSettingsOptions other)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x4E5190", Offset = "0x4E3790", VA = "0x1804E5190", Slot = "5")]
		public void Set(ref SetAudioInputSettingsOptions? other)
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x4E5020", Offset = "0x4E3620", VA = "0x1804E5020", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceId;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x18")]
		private float m_Volume;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x1C")]
		private int m_PlatformAEC;
	}
}
