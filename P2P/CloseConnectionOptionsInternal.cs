using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	internal struct CloseConnectionOptionsInternal : ISettable<CloseConnectionOptions>, IDisposable
	{
		// Token: 0x170005E0 RID: 1504
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x4EDE00", Offset = "0x4EC400", VA = "0x1804EDE00")]
			set
			{
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E1")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015BA")]
			[Address(RVA = "0x4EDE60", Offset = "0x4EC460", VA = "0x1804EDE60")]
			set
			{
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E2")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015BB")]
			[Address(RVA = "0x4EDEC0", Offset = "0x4EC4C0", VA = "0x1804EDEC0")]
			set
			{
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x4EDB60", Offset = "0x4EC160", VA = "0x1804EDB60", Slot = "4")]
		public void Set(ref CloseConnectionOptions other)
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x4EDC80", Offset = "0x4EC280", VA = "0x1804EDC80", Slot = "5")]
		public void Set(ref CloseConnectionOptions? other)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x4EDAF0", Offset = "0x4EC0F0", VA = "0x1804EDAF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;
	}
}
