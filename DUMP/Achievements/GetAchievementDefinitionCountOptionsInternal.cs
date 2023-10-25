using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	internal struct GetAchievementDefinitionCountOptionsInternal : ISettable<GetAchievementDefinitionCountOptions>, IDisposable
	{
		// Token: 0x06003059 RID: 12377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003059")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetAchievementDefinitionCountOptions other)
		{
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600305A")]
		[Address(RVA = "0x5883E0", Offset = "0x5869E0", VA = "0x1805883E0", Slot = "5")]
		public void Set(ref GetAchievementDefinitionCountOptions? other)
		{
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600305B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040015D1 RID: 5585
		[Token(Token = "0x40015D1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
