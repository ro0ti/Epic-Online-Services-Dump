using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	internal struct OnPeerConnectionInterruptedInfoInternal : ICallbackInfoInternal, IGettable<OnPeerConnectionInterruptedInfo>, ISettable<OnPeerConnectionInterruptedInfo>, IDisposable
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000612")]
		public object ClientData
		{
			[Token(Token = "0x600165C")]
			[Address(RVA = "0x51BB40", Offset = "0x51A140", VA = "0x18051BB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x51BD30", Offset = "0x51A330", VA = "0x18051BD30")]
			set
			{
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x17000613")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600165E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000614")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600165F")]
			[Address(RVA = "0x51BBB0", Offset = "0x51A1B0", VA = "0x18051BBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001660")]
			[Address(RVA = "0x51BD90", Offset = "0x51A390", VA = "0x18051BD90")]
			set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000615")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x6001661")]
			[Address(RVA = "0x51BC30", Offset = "0x51A230", VA = "0x18051BC30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001662")]
			[Address(RVA = "0x51BDF0", Offset = "0x51A3F0", VA = "0x18051BDF0")]
			set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x0000647C File Offset: 0x0000467C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000616")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001663")]
			[Address(RVA = "0x51BCB0", Offset = "0x51A2B0", VA = "0x18051BCB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001664")]
			[Address(RVA = "0x51BE50", Offset = "0x51A450", VA = "0x18051BE50")]
			set
			{
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x51B9E0", Offset = "0x519FE0", VA = "0x18051B9E0", Slot = "6")]
		public void Set(ref OnPeerConnectionInterruptedInfo other)
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x51B810", Offset = "0x519E10", VA = "0x18051B810", Slot = "7")]
		public void Set(ref OnPeerConnectionInterruptedInfo? other)
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x51B770", Offset = "0x519D70", VA = "0x18051B770", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x51B7E0", Offset = "0x519DE0", VA = "0x18051B7E0", Slot = "5")]
		public void Get(out OnPeerConnectionInterruptedInfo output)
		{
		}

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;
	}
}
