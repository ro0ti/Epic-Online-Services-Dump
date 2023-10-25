using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	internal struct GetLeaderboardDefinitionCountOptionsInternal : ISettable<GetLeaderboardDefinitionCountOptions>, IDisposable
	{
		// Token: 0x06001E0F RID: 7695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetLeaderboardDefinitionCountOptions other)
		{
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x523A00", Offset = "0x522000", VA = "0x180523A00", Slot = "5")]
		public void Set(ref GetLeaderboardDefinitionCountOptions? other)
		{
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
