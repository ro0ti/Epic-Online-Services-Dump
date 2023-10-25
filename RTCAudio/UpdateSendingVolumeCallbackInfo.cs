using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public struct UpdateSendingVolumeCallbackInfo : ICallbackInfo
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00005084 File Offset: 0x00003284
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E6")]
		public Result ResultCode
		{
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E7")]
		public object ClientData
		{
			[Token(Token = "0x6000FC3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FC4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FC5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FC6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E9")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FC7")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FC8")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0000509C File Offset: 0x0000329C
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003EA")]
		public float Volume
		{
			[Token(Token = "0x6000FC9")]
			[Address(RVA = "0x3E4000", Offset = "0x3E2600", VA = "0x1803E4000")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000FCA")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x4EABA0", Offset = "0x4E91A0", VA = "0x1804EABA0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x4EABF0", Offset = "0x4E91F0", VA = "0x1804EABF0")]
		internal void Set(ref UpdateSendingVolumeCallbackInfoInternal other)
		{
		}
	}
}
