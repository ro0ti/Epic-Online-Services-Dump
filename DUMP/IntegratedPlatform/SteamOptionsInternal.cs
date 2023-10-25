using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	internal struct SteamOptionsInternal : IGettable<SteamOptions>, ISettable<SteamOptions>, IDisposable
	{
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000925")]
		public Utf8String OverrideLibraryPath
		{
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x551360", Offset = "0x54F960", VA = "0x180551360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x5513D0", Offset = "0x54F9D0", VA = "0x1805513D0")]
			set
			{
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00008B34 File Offset: 0x00006D34
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000926")]
		public uint SteamMajorVersion
		{
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002057")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00008B4C File Offset: 0x00006D4C
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000927")]
		public uint SteamMinorVersion
		{
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x5512D0", Offset = "0x54F8D0", VA = "0x1805512D0", Slot = "5")]
		public void Set(ref SteamOptions other)
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x5511E0", Offset = "0x54F7E0", VA = "0x1805511E0", Slot = "6")]
		public void Set(ref SteamOptions? other)
		{
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x551170", Offset = "0x54F770", VA = "0x180551170", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x5511C0", Offset = "0x54F7C0", VA = "0x1805511C0", Slot = "4")]
		public void Get(out SteamOptions output)
		{
		}

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_OverrideLibraryPath;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x10")]
		private uint m_SteamMajorVersion;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x14")]
		private uint m_SteamMinorVersion;
	}
}
