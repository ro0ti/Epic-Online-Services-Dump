using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005AE RID: 1454
	[Token(Token = "0x20005AE")]
	public struct CustomInviteRejectedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACD")]
		public object ClientData
		{
			[Token(Token = "0x6002521")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002522")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACE")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002523")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002524")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002525")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD0")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x6002527")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD1")]
		public Utf8String Payload
		{
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600252A")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00009A4C File Offset: 0x00007C4C
		[Token(Token = "0x600252B")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x5402C0", Offset = "0x53E8C0", VA = "0x1805402C0")]
		internal void Set(ref CustomInviteRejectedCallbackInfoInternal other)
		{
		}
	}
}
