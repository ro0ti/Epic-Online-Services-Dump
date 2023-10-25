using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	internal struct OnRemoteConnectionClosedInfoInternal : ICallbackInfoInternal, IGettable<OnRemoteConnectionClosedInfo>, ISettable<OnRemoteConnectionClosedInfo>, IDisposable
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000623")]
		public object ClientData
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x51C9A0", Offset = "0x51AFA0", VA = "0x18051C9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x51CB90", Offset = "0x51B190", VA = "0x18051CB90")]
			set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x17000624")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600169A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000625")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600169B")]
			[Address(RVA = "0x51CA10", Offset = "0x51B010", VA = "0x18051CA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600169C")]
			[Address(RVA = "0x51CBF0", Offset = "0x51B1F0", VA = "0x18051CBF0")]
			set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600169E RID: 5790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000626")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x51CA90", Offset = "0x51B090", VA = "0x18051CA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600169E")]
			[Address(RVA = "0x51CC50", Offset = "0x51B250", VA = "0x18051CC50")]
			set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00006584 File Offset: 0x00004784
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000627")]
		public SocketId? SocketId
		{
			[Token(Token = "0x600169F")]
			[Address(RVA = "0x51CB10", Offset = "0x51B110", VA = "0x18051CB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016A0")]
			[Address(RVA = "0x51CCB0", Offset = "0x51B2B0", VA = "0x18051CCB0")]
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0000659C File Offset: 0x0000479C
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000628")]
		public ConnectionClosedReason Reason
		{
			[Token(Token = "0x60016A1")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return ConnectionClosedReason.Unknown;
			}
			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x51C840", Offset = "0x51AE40", VA = "0x18051C840", Slot = "6")]
		public void Set(ref OnRemoteConnectionClosedInfo other)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x51C650", Offset = "0x51AC50", VA = "0x18051C650", Slot = "7")]
		public void Set(ref OnRemoteConnectionClosedInfo? other)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x51C5C0", Offset = "0x51ABC0", VA = "0x18051C5C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x51C630", Offset = "0x51AC30", VA = "0x18051C630", Slot = "5")]
		public void Get(out OnRemoteConnectionClosedInfo output)
		{
		}

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x20")]
		private ConnectionClosedReason m_Reason;
	}
}
