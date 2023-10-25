using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	internal struct SetAudioOutputSettingsOptionsInternal : ISettable<SetAudioOutputSettingsOptions>, IDisposable
	{
		// Token: 0x17000389 RID: 905
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000389")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x4E5720", Offset = "0x4E3D20", VA = "0x1804E5720")]
			set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038A")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x4E56C0", Offset = "0x4E3CC0", VA = "0x1804E56C0")]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038B")]
		public float Volume
		{
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			set
			{
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x4E54C0", Offset = "0x4E3AC0", VA = "0x1804E54C0", Slot = "4")]
		public void Set(ref SetAudioOutputSettingsOptions other)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x4E5590", Offset = "0x4E3B90", VA = "0x1804E5590", Slot = "5")]
		public void Set(ref SetAudioOutputSettingsOptions? other)
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x4E5460", Offset = "0x4E3A60", VA = "0x1804E5460", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceId;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x18")]
		private float m_Volume;
	}
}
