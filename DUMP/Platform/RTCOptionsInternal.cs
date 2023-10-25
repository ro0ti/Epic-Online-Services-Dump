using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	internal struct RTCOptionsInternal : IGettable<RTCOptions>, ISettable<RTCOptions>, IDisposable
	{
		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E20")]
		public IntPtr PlatformSpecificOptions
		{
			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E21")]
		public RTCBackgroundMode BackgroundMode
		{
			[Token(Token = "0x6002F4F")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return RTCBackgroundMode.LeaveRooms;
			}
			[Token(Token = "0x6002F50")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x57D4D0", Offset = "0x57BAD0", VA = "0x18057D4D0", Slot = "5")]
		public void Set(ref RTCOptions other)
		{
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x57D440", Offset = "0x57BA40", VA = "0x18057D440", Slot = "6")]
		public void Set(ref RTCOptions? other)
		{
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x57D3D0", Offset = "0x57B9D0", VA = "0x18057D3D0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x57D420", Offset = "0x57BA20", VA = "0x18057D420", Slot = "4")]
		public void Get(out RTCOptions output)
		{
		}

		// Token: 0x04001539 RID: 5433
		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformSpecificOptions;

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x10")]
		private RTCBackgroundMode m_BackgroundMode;
	}
}
