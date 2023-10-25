using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	internal struct WindowsRTCOptionsPlatformSpecificOptionsInternal : IGettable<WindowsRTCOptionsPlatformSpecificOptions>, ISettable<WindowsRTCOptionsPlatformSpecificOptions>, IDisposable
	{
		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E45")]
		public Utf8String XAudio29DllPath
		{
			[Token(Token = "0x6002F95")]
			[Address(RVA = "0x58D100", Offset = "0x58B700", VA = "0x18058D100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0x58D170", Offset = "0x58B770", VA = "0x18058D170")]
			set
			{
			}
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F97")]
		[Address(RVA = "0x58D0A0", Offset = "0x58B6A0", VA = "0x18058D0A0", Slot = "5")]
		public void Set(ref WindowsRTCOptionsPlatformSpecificOptions other)
		{
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F98")]
		[Address(RVA = "0x58D000", Offset = "0x58B600", VA = "0x18058D000", Slot = "6")]
		public void Set(ref WindowsRTCOptionsPlatformSpecificOptions? other)
		{
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x58CF90", Offset = "0x58B590", VA = "0x18058CF90", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x58CFE0", Offset = "0x58B5E0", VA = "0x18058CFE0", Slot = "4")]
		public void Get(out WindowsRTCOptionsPlatformSpecificOptions output)
		{
		}

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_XAudio29DllPath;
	}
}
