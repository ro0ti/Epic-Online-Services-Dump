using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public struct QueryJoinRoomTokenCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x000051D4 File Offset: 0x000033D4
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000408")]
		public Result ResultCode
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000409")]
		public object ClientData
		{
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040A")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040B")]
		public Utf8String ClientBaseUrl
		{
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001031")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x000051EC File Offset: 0x000033EC
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040C")]
		public uint QueryId
		{
			[Token(Token = "0x6001032")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001033")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00005204 File Offset: 0x00003404
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040D")]
		public uint TokenCount
		{
			[Token(Token = "0x6001034")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001035")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x4DFD10", Offset = "0x4DE310", VA = "0x1804DFD10", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x4DFD60", Offset = "0x4DE360", VA = "0x1804DFD60")]
		internal void Set(ref QueryJoinRoomTokenCompleteCallbackInfoInternal other)
		{
		}
	}
}
