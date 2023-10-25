using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	internal struct OnIncomingConnectionRequestInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingConnectionRequestInfo>, ISettable<OnIncomingConnectionRequestInfo>, IDisposable
	{
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005EF")]
		public object ClientData
		{
			[Token(Token = "0x60015EF")]
			[Address(RVA = "0x51A000", Offset = "0x518600", VA = "0x18051A000")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F0")]
			[Address(RVA = "0x51A1F0", Offset = "0x5187F0", VA = "0x18051A1F0")]
			set
			{
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x170005F0")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x51A070", Offset = "0x518670", VA = "0x18051A070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F3")]
			[Address(RVA = "0x51A250", Offset = "0x518850", VA = "0x18051A250")]
			set
			{
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F2")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015F4")]
			[Address(RVA = "0x51A0F0", Offset = "0x5186F0", VA = "0x18051A0F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F5")]
			[Address(RVA = "0x51A2B0", Offset = "0x5188B0", VA = "0x18051A2B0")]
			set
			{
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0000626C File Offset: 0x0000446C
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F3")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015F6")]
			[Address(RVA = "0x51A170", Offset = "0x518770", VA = "0x18051A170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x51A310", Offset = "0x518910", VA = "0x18051A310")]
			set
			{
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x519EA0", Offset = "0x5184A0", VA = "0x180519EA0", Slot = "6")]
		public void Set(ref OnIncomingConnectionRequestInfo other)
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x519CD0", Offset = "0x5182D0", VA = "0x180519CD0", Slot = "7")]
		public void Set(ref OnIncomingConnectionRequestInfo? other)
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x519C30", Offset = "0x518230", VA = "0x180519C30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x519CA0", Offset = "0x5182A0", VA = "0x180519CA0", Slot = "5")]
		public void Get(out OnIncomingConnectionRequestInfo output)
		{
		}

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;
	}
}
