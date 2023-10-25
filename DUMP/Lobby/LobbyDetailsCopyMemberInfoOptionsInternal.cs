using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	internal struct LobbyDetailsCopyMemberInfoOptionsInternal : ISettable<LobbyDetailsCopyMemberInfoOptions>, IDisposable
	{
		// Token: 0x17000780 RID: 1920
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000780")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001A67")]
			[Address(RVA = "0x511A60", Offset = "0x510060", VA = "0x180511A60")]
			set
			{
			}
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x511960", Offset = "0x50FF60", VA = "0x180511960", Slot = "4")]
		public void Set(ref LobbyDetailsCopyMemberInfoOptions other)
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x5119C0", Offset = "0x50FFC0", VA = "0x1805119C0", Slot = "5")]
		public void Set(ref LobbyDetailsCopyMemberInfoOptions? other)
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x511910", Offset = "0x50FF10", VA = "0x180511910", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
