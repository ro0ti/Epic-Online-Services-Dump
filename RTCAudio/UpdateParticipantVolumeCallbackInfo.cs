using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	public struct UpdateParticipantVolumeCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00004DE4 File Offset: 0x00002FE4
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039A")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039B")]
		public object ClientData
		{
			[Token(Token = "0x6000F19")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F1A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039D")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039E")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00004DFC File Offset: 0x00002FFC
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039F")]
		public float Volume
		{
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x3E3FE0", Offset = "0x3E25E0", VA = "0x1803E3FE0")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x3E4020", Offset = "0x3E2620", VA = "0x1803E4020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x4E7C70", Offset = "0x4E6270", VA = "0x1804E7C70", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x4E7CC0", Offset = "0x4E62C0", VA = "0x1804E7CC0")]
		internal void Set(ref UpdateParticipantVolumeCallbackInfoInternal other)
		{
		}
	}
}
