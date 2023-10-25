using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200076B RID: 1899
	[Token(Token = "0x200076B")]
	public struct OnQueryPlayerAchievementsCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA5")]
		public Result ResultCode
		{
			[Token(Token = "0x60030C1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030C2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA6")]
		public object ClientData
		{
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60030C4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA7")]
		public ProductUserId UserId
		{
			[Token(Token = "0x60030C5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60030C6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0000C914 File Offset: 0x0000AB14
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x58A0D0", Offset = "0x5886D0", VA = "0x18058A0D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x58A120", Offset = "0x588720", VA = "0x18058A120")]
		internal void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal other)
		{
		}
	}
}
