using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A6 RID: 1702
	[Token(Token = "0x20006A6")]
	public struct ProtectMessageOptions
	{
		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0000AFF4 File Offset: 0x000091F4
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC0")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BB6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BB7")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0000B00C File Offset: 0x0000920C
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC1")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BB8")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002BB9")]
			[Address(RVA = "0x5790E0", Offset = "0x5776E0", VA = "0x1805790E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0000B024 File Offset: 0x00009224
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC2")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002BBA")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002BBB")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
