using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	public struct WindowsRTCOptions
	{
		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E40")]
		public WindowsRTCOptionsPlatformSpecificOptions? PlatformSpecificOptions
		{
			[Token(Token = "0x6002F85")]
			[Address(RVA = "0x57C890", Offset = "0x57AE90", VA = "0x18057C890")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F86")]
			[Address(RVA = "0x58D2F0", Offset = "0x58B8F0", VA = "0x18058D2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E41")]
		public RTCBackgroundMode BackgroundMode
		{
			[Token(Token = "0x6002F87")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return RTCBackgroundMode.LeaveRooms;
			}
			[Token(Token = "0x6002F88")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x58D250", Offset = "0x58B850", VA = "0x18058D250")]
		internal void Set(ref WindowsRTCOptionsInternal other)
		{
		}
	}
}
