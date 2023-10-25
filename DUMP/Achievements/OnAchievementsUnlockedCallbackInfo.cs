using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public struct OnAchievementsUnlockedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E90")]
		public object ClientData
		{
			[Token(Token = "0x6003070")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003071")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E91")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6003072")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003073")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E92")]
		public Utf8String[] AchievementIds
		{
			[Token(Token = "0x6003074")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003075")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0000C80C File Offset: 0x0000AA0C
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x588CE0", Offset = "0x5872E0", VA = "0x180588CE0")]
		internal void Set(ref OnAchievementsUnlockedCallbackInfoInternal other)
		{
		}
	}
}
