using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000727 RID: 1831
	[Token(Token = "0x2000727")]
	public struct DesktopCrossplayStatusInfo
	{
		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DE0")]
		public DesktopCrossplayStatus Status
		{
			[Token(Token = "0x6002EC8")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return DesktopCrossplayStatus.Ok;
			}
			[Token(Token = "0x6002EC9")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x0000C20C File Offset: 0x0000A40C
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DE1")]
		public int ServiceInitResult
		{
			[Token(Token = "0x6002ECA")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002ECB")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x570300", Offset = "0x56E900", VA = "0x180570300")]
		internal void Set(ref DesktopCrossplayStatusInfoInternal other)
		{
		}
	}
}
