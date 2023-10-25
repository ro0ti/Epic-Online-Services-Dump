using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public struct SendInviteOptions
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000992")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60021B0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60021B1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000993")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
