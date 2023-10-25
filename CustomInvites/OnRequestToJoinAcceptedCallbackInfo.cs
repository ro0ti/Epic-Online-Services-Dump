using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x20005C3")]
	public struct OnRequestToJoinAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF6")]
		public object ClientData
		{
			[Token(Token = "0x60025D5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025D6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF7")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60025D7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025D8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60025D9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025DA")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00009BE4 File Offset: 0x00007DE4
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x562EA0", Offset = "0x5614A0", VA = "0x180562EA0")]
		internal void Set(ref OnRequestToJoinAcceptedCallbackInfoInternal other)
		{
		}
	}
}
