using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	public struct CopyUserTokenByUserIdOptions
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FB")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000FF1")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0000515C File Offset: 0x0000335C
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FC")]
		public uint QueryId
		{
			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000FF4")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
