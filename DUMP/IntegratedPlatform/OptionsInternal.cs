using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20004EB")]
	internal struct OptionsInternal : IGettable<Options>, ISettable<Options>, IDisposable
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000919")]
		public Utf8String Type
		{
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x54AEC0", Offset = "0x5494C0", VA = "0x18054AEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x54AF30", Offset = "0x549530", VA = "0x18054AF30")]
			set
			{
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00008ABC File Offset: 0x00006CBC
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091A")]
		public IntegratedPlatformManagementFlags Flags
		{
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return (IntegratedPlatformManagementFlags)0;
			}
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00008AD4 File Offset: 0x00006CD4
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091B")]
		public IntPtr InitOptions
		{
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x54AD40", Offset = "0x549340", VA = "0x18054AD40", Slot = "5")]
		public void Set(ref Options other)
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x54ADD0", Offset = "0x5493D0", VA = "0x18054ADD0", Slot = "6")]
		public void Set(ref Options? other)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x54ACC0", Offset = "0x5492C0", VA = "0x18054ACC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x54AD20", Offset = "0x549320", VA = "0x18054AD20", Slot = "4")]
		public void Get(out Options output)
		{
		}

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Type;

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x10")]
		private IntegratedPlatformManagementFlags m_Flags;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_InitOptions;
	}
}
