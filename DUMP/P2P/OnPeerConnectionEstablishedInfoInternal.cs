using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	internal struct OnPeerConnectionEstablishedInfoInternal : ICallbackInfoInternal, IGettable<OnPeerConnectionEstablishedInfo>, ISettable<OnPeerConnectionEstablishedInfo>, IDisposable
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000607")]
		public object ClientData
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x51B190", Offset = "0x519790", VA = "0x18051B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x600163A")]
			[Address(RVA = "0x51B380", Offset = "0x519980", VA = "0x18051B380")]
			set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x17000608")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600163B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000609")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x51B200", Offset = "0x519800", VA = "0x18051B200")]
			get
			{
				return null;
			}
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x51B3E0", Offset = "0x5199E0", VA = "0x18051B3E0")]
			set
			{
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060A")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x600163E")]
			[Address(RVA = "0x51B280", Offset = "0x519880", VA = "0x18051B280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600163F")]
			[Address(RVA = "0x51B440", Offset = "0x519A40", VA = "0x18051B440")]
			set
			{
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x000063EC File Offset: 0x000045EC
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060B")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001640")]
			[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001641")]
			[Address(RVA = "0x51B4A0", Offset = "0x519AA0", VA = "0x18051B4A0")]
			set
			{
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00006404 File Offset: 0x00004604
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060C")]
		public ConnectionEstablishedType ConnectionType
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return ConnectionEstablishedType.NewConnection;
			}
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0000641C File Offset: 0x0000461C
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060D")]
		public NetworkConnectionType NetworkType
		{
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			get
			{
				return NetworkConnectionType.NoConnection;
			}
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			set
			{
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x51B030", Offset = "0x519630", VA = "0x18051B030", Slot = "6")]
		public void Set(ref OnPeerConnectionEstablishedInfo other)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x51AE30", Offset = "0x519430", VA = "0x18051AE30", Slot = "7")]
		public void Set(ref OnPeerConnectionEstablishedInfo? other)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x51ADA0", Offset = "0x5193A0", VA = "0x18051ADA0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x51AE10", Offset = "0x519410", VA = "0x18051AE10", Slot = "5")]
		public void Get(out OnPeerConnectionEstablishedInfo output)
		{
		}

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x20")]
		private ConnectionEstablishedType m_ConnectionType;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x24")]
		private NetworkConnectionType m_NetworkType;
	}
}
