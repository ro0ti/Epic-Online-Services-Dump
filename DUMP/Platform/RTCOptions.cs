using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000736")]
	public struct RTCOptions
	{
		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1E")]
		public IntPtr PlatformSpecificOptions
		{
			[Token(Token = "0x6002F48")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002F49")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1F")]
		public RTCBackgroundMode BackgroundMode
		{
			[Token(Token = "0x6002F4A")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return RTCBackgroundMode.LeaveRooms;
			}
			[Token(Token = "0x6002F4B")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x57D4F0", Offset = "0x57BAF0", VA = "0x18057D4F0")]
		internal void Set(ref RTCOptionsInternal other)
		{
		}
	}
}
