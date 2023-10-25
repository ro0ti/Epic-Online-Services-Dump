using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public struct GetJoinInfoOptions
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004DF")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012A2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012A3")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E0")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012A4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012A5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
