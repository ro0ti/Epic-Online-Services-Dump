using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public struct EndPlayerSessionOptions
	{
		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AE")]
		public EndPlayerSessionOptionsAccountId AccountId
		{
			[Token(Token = "0x6001831")]
			[Address(RVA = "0x5083F0", Offset = "0x5069F0", VA = "0x1805083F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(EndPlayerSessionOptionsAccountId);
			}
			[Token(Token = "0x6001832")]
			[Address(RVA = "0x508410", Offset = "0x506A10", VA = "0x180508410")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
