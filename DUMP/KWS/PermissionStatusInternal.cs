using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	internal struct PermissionStatusInternal : IGettable<PermissionStatus>, ISettable<PermissionStatus>, IDisposable
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008CF")]
		public Utf8String Name
		{
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x530AD0", Offset = "0x52F0D0", VA = "0x180530AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x530B40", Offset = "0x52F140", VA = "0x180530B40")]
			set
			{
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0000875C File Offset: 0x0000695C
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D0")]
		public KWSPermissionStatus Status
		{
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return KWSPermissionStatus.Granted;
			}
			[Token(Token = "0x6001F53")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x530980", Offset = "0x52EF80", VA = "0x180530980", Slot = "5")]
		public void Set(ref PermissionStatus other)
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x530A00", Offset = "0x52F000", VA = "0x180530A00", Slot = "6")]
		public void Set(ref PermissionStatus? other)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x530910", Offset = "0x52EF10", VA = "0x180530910", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x530960", Offset = "0x52EF60", VA = "0x180530960", Slot = "4")]
		public void Get(out PermissionStatus output)
		{
		}

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Name;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x10")]
		private KWSPermissionStatus m_Status;
	}
}
