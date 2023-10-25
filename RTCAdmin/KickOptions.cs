using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	public struct KickOptions
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000404")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600100A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000405")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
