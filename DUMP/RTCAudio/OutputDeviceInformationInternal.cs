using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	internal struct OutputDeviceInformationInternal : IGettable<OutputDeviceInformation>, ISettable<OutputDeviceInformation>, IDisposable
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00004AFC File Offset: 0x00002CFC
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000364")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x4DDA70", Offset = "0x4DC070", VA = "0x1804DDA70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x4DDBB0", Offset = "0x4DC1B0", VA = "0x1804DDBB0")]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000365")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0x4DDAD0", Offset = "0x4DC0D0", VA = "0x1804DDAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x4DDC10", Offset = "0x4DC210", VA = "0x1804DDC10")]
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000366")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x4DDB40", Offset = "0x4DC140", VA = "0x1804DDB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x4DDC70", Offset = "0x4DC270", VA = "0x1804DDC70")]
			set
			{
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x4DD970", Offset = "0x4DBF70", VA = "0x1804DD970", Slot = "5")]
		public void Set(ref OutputDeviceInformation other)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x4DD810", Offset = "0x4DBE10", VA = "0x1804DD810", Slot = "6")]
		public void Set(ref OutputDeviceInformation? other)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x4DD790", Offset = "0x4DBD90", VA = "0x1804DD790", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x4DD7F0", Offset = "0x4DBDF0", VA = "0x1804DD7F0", Slot = "4")]
		public void Get(out OutputDeviceInformation output)
		{
		}

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x4")]
		private int m_DefaultDevice;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DeviceId;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DeviceName;
	}
}
