using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public struct HasPresenceOptions
	{
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E3")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012AB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012AC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E4")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012AD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
