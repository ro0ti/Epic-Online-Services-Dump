using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C9 RID: 1481
	[Token(Token = "0x20005C9")]
	public struct OnRequestToJoinRejectedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AFD")]
		public object ClientData
		{
			[Token(Token = "0x60025F8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AFE")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60025FA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025FB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AFF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60025FC")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025FD")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00009C14 File Offset: 0x00007E14
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x563710", Offset = "0x561D10", VA = "0x180563710")]
		internal void Set(ref OnRequestToJoinRejectedCallbackInfoInternal other)
		{
		}
	}
}
