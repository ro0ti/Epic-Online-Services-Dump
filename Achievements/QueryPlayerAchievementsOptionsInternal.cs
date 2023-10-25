using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	internal struct QueryPlayerAchievementsOptionsInternal : ISettable<QueryPlayerAchievementsOptions>, IDisposable
	{
		// Token: 0x17000ED3 RID: 3795
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6003139")]
			[Address(RVA = "0x58C150", Offset = "0x58A750", VA = "0x18058C150")]
			set
			{
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600313A")]
			[Address(RVA = "0x58C0F0", Offset = "0x58A6F0", VA = "0x18058C0F0")]
			set
			{
			}
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x58C030", Offset = "0x58A630", VA = "0x18058C030", Slot = "4")]
		public void Set(ref QueryPlayerAchievementsOptions other)
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x58BF20", Offset = "0x58A520", VA = "0x18058BF20", Slot = "5")]
		public void Set(ref QueryPlayerAchievementsOptions? other)
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x58BEC0", Offset = "0x58A4C0", VA = "0x18058BEC0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
