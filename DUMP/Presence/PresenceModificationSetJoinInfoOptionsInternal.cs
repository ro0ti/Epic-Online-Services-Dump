using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	internal struct PresenceModificationSetJoinInfoOptionsInternal : ISettable<PresenceModificationSetJoinInfoOptions>, IDisposable
	{
		// Token: 0x17000512 RID: 1298
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000512")]
		public Utf8String JoinInfo
		{
			[Token(Token = "0x6001353")]
			[Address(RVA = "0x4FC4C0", Offset = "0x4FAAC0", VA = "0x1804FC4C0")]
			set
			{
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x4FC3C0", Offset = "0x4FA9C0", VA = "0x1804FC3C0", Slot = "4")]
		public void Set(ref PresenceModificationSetJoinInfoOptions other)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x4FC420", Offset = "0x4FAA20", VA = "0x1804FC420", Slot = "5")]
		public void Set(ref PresenceModificationSetJoinInfoOptions? other)
		{
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x4FC370", Offset = "0x4FA970", VA = "0x1804FC370", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_JoinInfo;
	}
}
