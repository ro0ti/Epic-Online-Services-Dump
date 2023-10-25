using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	internal struct WindowsRTCOptionsInternal : IGettable<WindowsRTCOptions>, ISettable<WindowsRTCOptions>, IDisposable
	{
		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E42")]
		public WindowsRTCOptionsPlatformSpecificOptions? PlatformSpecificOptions
		{
			[Token(Token = "0x6002F8A")]
			[Address(RVA = "0x58CEA0", Offset = "0x58B4A0", VA = "0x18058CEA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F8B")]
			[Address(RVA = "0x58CF20", Offset = "0x58B520", VA = "0x18058CF20")]
			set
			{
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E43")]
		public RTCBackgroundMode BackgroundMode
		{
			[Token(Token = "0x6002F8C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return RTCBackgroundMode.LeaveRooms;
			}
			[Token(Token = "0x6002F8D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x58CE10", Offset = "0x58B410", VA = "0x18058CE10", Slot = "5")]
		public void Set(ref WindowsRTCOptions other)
		{
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x58CD20", Offset = "0x58B320", VA = "0x18058CD20", Slot = "6")]
		public void Set(ref WindowsRTCOptions? other)
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x58CCB0", Offset = "0x58B2B0", VA = "0x18058CCB0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x58CD00", Offset = "0x58B300", VA = "0x18058CD00", Slot = "4")]
		public void Get(out WindowsRTCOptions output)
		{
		}

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformSpecificOptions;

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x10")]
		private RTCBackgroundMode m_BackgroundMode;
	}
}
