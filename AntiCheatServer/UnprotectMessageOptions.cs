using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x20006AE")]
	public struct UnprotectMessageOptions
	{
		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x0000B0E4 File Offset: 0x000092E4
		// (set) Token: 0x06002BEA RID: 11242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDA")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BE9")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BEA")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x0000B0FC File Offset: 0x000092FC
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDB")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BEB")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002BEC")]
			[Address(RVA = "0x5790E0", Offset = "0x5776E0", VA = "0x1805790E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x0000B114 File Offset: 0x00009314
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDC")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002BED")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002BEE")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
