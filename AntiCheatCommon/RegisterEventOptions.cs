using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E2 RID: 1762
	[Token(Token = "0x20006E2")]
	public struct RegisterEventOptions
	{
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x0000BAEC File Offset: 0x00009CEC
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D78")]
		public uint EventId
		{
			[Token(Token = "0x6002D47")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002D48")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D79")]
		public Utf8String EventName
		{
			[Token(Token = "0x6002D49")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002D4A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0000BB04 File Offset: 0x00009D04
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7A")]
		public AntiCheatCommonEventType EventType
		{
			[Token(Token = "0x6002D4B")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonEventType.Invalid;
			}
			[Token(Token = "0x6002D4C")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7B")]
		public RegisterEventParamDef[] ParamDefs
		{
			[Token(Token = "0x6002D4D")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002D4E")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
