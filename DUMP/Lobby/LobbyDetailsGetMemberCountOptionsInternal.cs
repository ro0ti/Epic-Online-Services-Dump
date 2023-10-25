using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	internal struct LobbyDetailsGetMemberCountOptionsInternal : ISettable<LobbyDetailsGetMemberCountOptions>, IDisposable
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref LobbyDetailsGetMemberCountOptions other)
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x511D70", Offset = "0x510370", VA = "0x180511D70", Slot = "5")]
		public void Set(ref LobbyDetailsGetMemberCountOptions? other)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
