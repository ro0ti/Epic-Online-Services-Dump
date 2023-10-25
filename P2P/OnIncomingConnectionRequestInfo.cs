using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	public struct OnIncomingConnectionRequestInfo : ICallbackInfo
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005EB")]
		public object ClientData
		{
			[Token(Token = "0x60015E5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015E6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005EC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015E7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015E8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005ED")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015E9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015EA")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00006224 File Offset: 0x00004424
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005EE")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015EB")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x51A4C0", Offset = "0x518AC0", VA = "0x18051A4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x51A380", Offset = "0x518980", VA = "0x18051A380")]
		internal void Set(ref OnIncomingConnectionRequestInfoInternal other)
		{
		}
	}
}
