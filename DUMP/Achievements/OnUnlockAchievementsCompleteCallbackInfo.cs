using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	public struct OnUnlockAchievementsCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x0000C95C File Offset: 0x0000AB5C
		// (set) Token: 0x060030DD RID: 12509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EAC")]
		public Result ResultCode
		{
			[Token(Token = "0x60030DC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030DD")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EAD")]
		public object ClientData
		{
			[Token(Token = "0x60030DE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60030DF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EAE")]
		public ProductUserId UserId
		{
			[Token(Token = "0x60030E0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60030E1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0000C974 File Offset: 0x0000AB74
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EAF")]
		public uint AchievementsCount
		{
			[Token(Token = "0x60030E2")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60030E3")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0000C98C File Offset: 0x0000AB8C
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x58A730", Offset = "0x588D30", VA = "0x18058A730", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x58A780", Offset = "0x588D80", VA = "0x18058A780")]
		internal void Set(ref OnUnlockAchievementsCompleteCallbackInfoInternal other)
		{
		}
	}
}
