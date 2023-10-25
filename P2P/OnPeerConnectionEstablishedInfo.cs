using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public struct OnPeerConnectionEstablishedInfo : ICallbackInfo
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000601")]
		public object ClientData
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000602")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600162E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000603")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x600162F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001630")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00006374 File Offset: 0x00004574
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000604")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x51A4C0", Offset = "0x518AC0", VA = "0x18051A4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0000638C File Offset: 0x0000458C
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000605")]
		public ConnectionEstablishedType ConnectionType
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			[CompilerGenerated]
			readonly get
			{
				return ConnectionEstablishedType.NewConnection;
			}
			[Token(Token = "0x6001634")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000063A4 File Offset: 0x000045A4
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000606")]
		public NetworkConnectionType NetworkType
		{
			[Token(Token = "0x6001635")]
			[Address(RVA = "0x3D2E90", Offset = "0x3D1490", VA = "0x1803D2E90")]
			[CompilerGenerated]
			readonly get
			{
				return NetworkConnectionType.NoConnection;
			}
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x3D2EC0", Offset = "0x3D14C0", VA = "0x1803D2EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x51B510", Offset = "0x519B10", VA = "0x18051B510")]
		internal void Set(ref OnPeerConnectionEstablishedInfoInternal other)
		{
		}
	}
}
