using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	public struct SetParticipantHardMuteCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000052C4 File Offset: 0x000034C4
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041D")]
		public Result ResultCode
		{
			[Token(Token = "0x6001062")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001063")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041E")]
		public object ClientData
		{
			[Token(Token = "0x6001064")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x4E60B0", Offset = "0x4E46B0", VA = "0x1804E60B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x4E6100", Offset = "0x4E4700", VA = "0x1804E6100")]
		internal void Set(ref SetParticipantHardMuteCompleteCallbackInfoInternal other)
		{
		}
	}
}
