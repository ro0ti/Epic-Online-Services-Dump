using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000711 RID: 1809
	[Token(Token = "0x2000711")]
	public struct ProtectMessageOptions
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA8")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E19")]
			[Address(RVA = "0x57C890", Offset = "0x57AE90", VA = "0x18057C890")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002E1A")]
			[Address(RVA = "0x57C8A0", Offset = "0x57AEA0", VA = "0x18057C8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA9")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002E1B")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002E1C")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
