using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200034C RID: 844
	[Token(Token = "0x200034C")]
	public struct OnRemoteConnectionClosedInfo : ICallbackInfo
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700061E")]
		public object ClientData
		{
			[Token(Token = "0x600168C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600168D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700061F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600168E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600168F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000620")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x6001690")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001691")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x00006524 File Offset: 0x00004724
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000621")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001692")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001693")]
			[Address(RVA = "0x51A4C0", Offset = "0x518AC0", VA = "0x18051A4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0000653C File Offset: 0x0000473C
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000622")]
		public ConnectionClosedReason Reason
		{
			[Token(Token = "0x6001694")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			[CompilerGenerated]
			readonly get
			{
				return ConnectionClosedReason.Unknown;
			}
			[Token(Token = "0x6001695")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x51CD20", Offset = "0x51B320", VA = "0x18051CD20")]
		internal void Set(ref OnRemoteConnectionClosedInfoInternal other)
		{
		}
	}
}
