using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DA RID: 1498
	[Token(Token = "0x20005DA")]
	public struct RequestToJoinResponseReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B18")]
		public object ClientData
		{
			[Token(Token = "0x600265E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600265F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B19")]
		public ProductUserId FromUserId
		{
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002661")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B1A")]
		public ProductUserId ToUserId
		{
			[Token(Token = "0x6002662")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002663")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x00009CD4 File Offset: 0x00007ED4
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B1B")]
		public RequestToJoinResponse Response
		{
			[Token(Token = "0x6002664")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return RequestToJoinResponse.Accepted;
			}
			[Token(Token = "0x6002665")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00009CEC File Offset: 0x00007EEC
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x566600", Offset = "0x564C00", VA = "0x180566600")]
		internal void Set(ref RequestToJoinResponseReceivedCallbackInfoInternal other)
		{
		}
	}
}
