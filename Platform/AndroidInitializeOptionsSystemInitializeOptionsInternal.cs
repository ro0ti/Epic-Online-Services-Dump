using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000720 RID: 1824
	[Token(Token = "0x2000720")]
	internal struct AndroidInitializeOptionsSystemInitializeOptionsInternal : IGettable<AndroidInitializeOptionsSystemInitializeOptions>, ISettable<AndroidInitializeOptionsSystemInitializeOptions>, IDisposable
	{
		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x0000C074 File Offset: 0x0000A274
		// (set) Token: 0x06002E7B RID: 11899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD9")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E7B")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDA")]
		public Utf8String OptionalInternalDirectory
		{
			[Token(Token = "0x6002E7C")]
			[Address(RVA = "0x56C250", Offset = "0x56A850", VA = "0x18056C250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E7D")]
			[Address(RVA = "0x56C320", Offset = "0x56A920", VA = "0x18056C320")]
			set
			{
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDB")]
		public Utf8String OptionalExternalDirectory
		{
			[Token(Token = "0x6002E7E")]
			[Address(RVA = "0x56C1E0", Offset = "0x56A7E0", VA = "0x18056C1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E7F")]
			[Address(RVA = "0x56C2C0", Offset = "0x56A8C0", VA = "0x18056C2C0")]
			set
			{
			}
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x56C110", Offset = "0x56A710", VA = "0x18056C110", Slot = "5")]
		public void Set(ref AndroidInitializeOptionsSystemInitializeOptions other)
		{
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x56BF30", Offset = "0x56A530", VA = "0x18056BF30", Slot = "6")]
		public void Set(ref AndroidInitializeOptionsSystemInitializeOptions? other)
		{
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x56BEA0", Offset = "0x56A4A0", VA = "0x18056BEA0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x56BF10", Offset = "0x56A510", VA = "0x18056BF10", Slot = "4")]
		public void Get(out AndroidInitializeOptionsSystemInitializeOptions output)
		{
		}

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040014BA RID: 5306
		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Reserved;

		// Token: 0x040014BB RID: 5307
		[Token(Token = "0x40014BB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OptionalInternalDirectory;

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40014BC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_OptionalExternalDirectory;
	}
}
