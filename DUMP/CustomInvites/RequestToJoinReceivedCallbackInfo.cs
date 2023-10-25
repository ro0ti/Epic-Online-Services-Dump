using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	public struct RequestToJoinReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B11")]
		public object ClientData
		{
			[Token(Token = "0x600264B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B12")]
		public ProductUserId FromUserId
		{
			[Token(Token = "0x600264D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600264E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B13")]
		public ProductUserId ToUserId
		{
			[Token(Token = "0x600264F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002650")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x565FB0", Offset = "0x5645B0", VA = "0x180565FB0")]
		internal void Set(ref RequestToJoinReceivedCallbackInfoInternal other)
		{
		}
	}
}
