using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public struct LeaveSessionRequestedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F8")]
		public object ClientData
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FA")]
		public Utf8String SessionName
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x4BF2D0", Offset = "0x4BD8D0", VA = "0x1804BF2D0")]
		internal void Set(ref LeaveSessionRequestedCallbackInfoInternal other)
		{
		}
	}
}
