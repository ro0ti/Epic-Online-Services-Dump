using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	public struct UserToken
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000428")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x600107D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600107E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000429")]
		public Utf8String Token
		{
			[Token(Token = "0x600107F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001080")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x4EBEA0", Offset = "0x4EA4A0", VA = "0x1804EBEA0")]
		internal void Set(ref UserTokenInternal other)
		{
		}
	}
}
