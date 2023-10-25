using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	public sealed class P2PInterface : Handle
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public P2PInterface()
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public P2PInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x51D090", Offset = "0x51B690", VA = "0x18051D090")]
		public Result AcceptConnection(ref AcceptConnectionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x51D130", Offset = "0x51B730", VA = "0x18051D130")]
		public ulong AddNotifyIncomingPacketQueueFull(ref AddNotifyIncomingPacketQueueFullOptions options, object clientData, OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler)
		{
			return 0UL;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x51D300", Offset = "0x51B900", VA = "0x18051D300")]
		public ulong AddNotifyPeerConnectionClosed(ref AddNotifyPeerConnectionClosedOptions options, object clientData, OnRemoteConnectionClosedCallback connectionClosedHandler)
		{
			return 0UL;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x51D4E0", Offset = "0x51BAE0", VA = "0x18051D4E0")]
		public ulong AddNotifyPeerConnectionEstablished(ref AddNotifyPeerConnectionEstablishedOptions options, object clientData, OnPeerConnectionEstablishedCallback connectionEstablishedHandler)
		{
			return 0UL;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00006614 File Offset: 0x00004814
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x51D6C0", Offset = "0x51BCC0", VA = "0x18051D6C0")]
		public ulong AddNotifyPeerConnectionInterrupted(ref AddNotifyPeerConnectionInterruptedOptions options, object clientData, OnPeerConnectionInterruptedCallback connectionInterruptedHandler)
		{
			return 0UL;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x51D8A0", Offset = "0x51BEA0", VA = "0x18051D8A0")]
		public ulong AddNotifyPeerConnectionRequest(ref AddNotifyPeerConnectionRequestOptions options, object clientData, OnIncomingConnectionRequestCallback connectionRequestHandler)
		{
			return 0UL;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x51DA00", Offset = "0x51C000", VA = "0x18051DA00")]
		public Result ClearPacketQueue(ref ClearPacketQueueOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x51DAA0", Offset = "0x51C0A0", VA = "0x18051DAA0")]
		public Result CloseConnection(ref CloseConnectionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x51DB40", Offset = "0x51C140", VA = "0x18051DB40")]
		public Result CloseConnections(ref CloseConnectionsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x51DBE0", Offset = "0x51C1E0", VA = "0x18051DBE0")]
		public Result GetNATType(ref GetNATTypeOptions options, out NATType outNATType)
		{
			return Result.Success;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x51DCA0", Offset = "0x51C2A0", VA = "0x18051DCA0")]
		public Result GetNextReceivedPacketSize(ref GetNextReceivedPacketSizeOptions options, out uint outPacketSizeBytes)
		{
			return Result.Success;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x51DD70", Offset = "0x51C370", VA = "0x18051DD70")]
		public Result GetPacketQueueInfo(ref GetPacketQueueInfoOptions options, out PacketQueueInfo outPacketQueueInfo)
		{
			return Result.Success;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x51DE90", Offset = "0x51C490", VA = "0x18051DE90")]
		public Result GetPortRange(ref GetPortRangeOptions options, out ushort outPort, out ushort outNumAdditionalPortsToTry)
		{
			return Result.Success;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x51DF80", Offset = "0x51C580", VA = "0x18051DF80")]
		public Result GetRelayControl(ref GetRelayControlOptions options, out RelayControl outRelayControl)
		{
			return Result.Success;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x51E450", Offset = "0x51CA50", VA = "0x18051E450")]
		public void QueryNATType(ref QueryNATTypeOptions options, object clientData, OnQueryNATTypeCompleteCallback completionDelegate)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00006704 File Offset: 0x00004904
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x51E600", Offset = "0x51CC00", VA = "0x18051E600")]
		public Result ReceivePacket(ref ReceivePacketOptions options, out ProductUserId outPeerId, out SocketId outSocketId, out byte outChannel, ArraySegment<byte> outData, out uint outBytesWritten)
		{
			return Result.Success;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x51E7C0", Offset = "0x51CDC0", VA = "0x18051E7C0")]
		public void RemoveNotifyIncomingPacketQueueFull(ulong notificationId)
		{
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x51E830", Offset = "0x51CE30", VA = "0x18051E830")]
		public void RemoveNotifyPeerConnectionClosed(ulong notificationId)
		{
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x51E8A0", Offset = "0x51CEA0", VA = "0x18051E8A0")]
		public void RemoveNotifyPeerConnectionEstablished(ulong notificationId)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x51E910", Offset = "0x51CF10", VA = "0x18051E910")]
		public void RemoveNotifyPeerConnectionInterrupted(ulong notificationId)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x51E980", Offset = "0x51CF80", VA = "0x18051E980")]
		public void RemoveNotifyPeerConnectionRequest(ulong notificationId)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x51E9F0", Offset = "0x51CFF0", VA = "0x18051E9F0")]
		public Result SendPacket(ref SendPacketOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x51EAA0", Offset = "0x51D0A0", VA = "0x18051EAA0")]
		public Result SetPacketQueueSize(ref SetPacketQueueSizeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x51EB40", Offset = "0x51D140", VA = "0x18051EB40")]
		public Result SetPortRange(ref SetPortRangeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x51EBE0", Offset = "0x51D1E0", VA = "0x18051EBE0")]
		public Result SetRelayControl(ref SetRelayControlOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x51E040", Offset = "0x51C640", VA = "0x18051E040")]
		[MonoPInvokeCallback(typeof(OnIncomingConnectionRequestCallbackInternal))]
		internal static void OnIncomingConnectionRequestCallbackInternalImplementation(ref OnIncomingConnectionRequestInfoInternal data)
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x51E0F0", Offset = "0x51C6F0", VA = "0x18051E0F0")]
		[MonoPInvokeCallback(typeof(OnIncomingPacketQueueFullCallbackInternal))]
		internal static void OnIncomingPacketQueueFullCallbackInternalImplementation(ref OnIncomingPacketQueueFullInfoInternal data)
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x51E1A0", Offset = "0x51C7A0", VA = "0x18051E1A0")]
		[MonoPInvokeCallback(typeof(OnPeerConnectionEstablishedCallbackInternal))]
		internal static void OnPeerConnectionEstablishedCallbackInternalImplementation(ref OnPeerConnectionEstablishedInfoInternal data)
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x51E250", Offset = "0x51C850", VA = "0x18051E250")]
		[MonoPInvokeCallback(typeof(OnPeerConnectionInterruptedCallbackInternal))]
		internal static void OnPeerConnectionInterruptedCallbackInternalImplementation(ref OnPeerConnectionInterruptedInfoInternal data)
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x51E300", Offset = "0x51C900", VA = "0x18051E300")]
		[MonoPInvokeCallback(typeof(OnQueryNATTypeCompleteCallbackInternal))]
		internal static void OnQueryNATTypeCompleteCallbackInternalImplementation(ref OnQueryNATTypeCompleteInfoInternal data)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x51E3A0", Offset = "0x51C9A0", VA = "0x18051E3A0")]
		[MonoPInvokeCallback(typeof(OnRemoteConnectionClosedCallbackInternal))]
		internal static void OnRemoteConnectionClosedCallbackInternalImplementation(ref OnRemoteConnectionClosedInfoInternal data)
		{
		}

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		public const int AcceptconnectionApiLatest = 1;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		public const int AddnotifyincomingpacketqueuefullApiLatest = 1;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		public const int AddnotifypeerconnectionclosedApiLatest = 1;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		public const int AddnotifypeerconnectionestablishedApiLatest = 1;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		public const int AddnotifypeerconnectioninterruptedApiLatest = 1;

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		public const int AddnotifypeerconnectionrequestApiLatest = 1;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		public const int ClearpacketqueueApiLatest = 1;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		public const int CloseconnectionApiLatest = 1;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		public const int CloseconnectionsApiLatest = 1;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		public const int GetnattypeApiLatest = 1;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		public const int GetnextreceivedpacketsizeApiLatest = 2;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		public const int GetpacketqueueinfoApiLatest = 1;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		public const int GetportrangeApiLatest = 1;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		public const int GetrelaycontrolApiLatest = 1;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		public const int MaxConnections = 32;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		public const int MaxPacketSize = 1170;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		public const int MaxQueueSizeUnlimited = 0;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		public const int QuerynattypeApiLatest = 1;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		public const int ReceivepacketApiLatest = 2;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		public const int SendpacketApiLatest = 3;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		public const int SetpacketqueuesizeApiLatest = 1;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		public const int SetportrangeApiLatest = 1;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		public const int SetrelaycontrolApiLatest = 1;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		public const int SocketidApiLatest = 1;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		public const int SocketidSocketnameSize = 33;
	}
}
